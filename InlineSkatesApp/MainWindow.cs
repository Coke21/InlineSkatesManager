using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using InlineSkatesApp.Models;
using Jot;
using Microsoft.Extensions.Configuration;
using Syncfusion.Data.Extensions;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using DataRow = System.Data.DataRow;

namespace InlineSkatesApp
{
    public partial class MainWindow : SfForm
    {
        private readonly AppSettingsModel _appSettings;
        public MainWindow()
        {
            InitializeComponent();

            _appSettings = Program.Configuration.GetSection("AppSettings").Get<AppSettingsModel>();

            var tracker = new Tracker();
            tracker.Configure<MainWindow>()
                .Id(p => "MainWindow", includeType: false)
                .Property(p => p.Height, 500, "Window Height")
                .Property(p => p.Width, 800, "Window Width")

                .Property(p => p.checkBoxAdvCaseSensitiveCustomers.Checked, false, "Search for case sensitive customers")
                .Property(p => p.textBoxExtCustomerName.Text, string.Empty, "Customer name field")

                .Property(p => p.checkBoxAdvCaseSensitiveProducts.Checked, false, "Search for case sensitive products")
                .Property(p => p.textBoxExtProductName.Text, string.Empty, "Product name field")
                .Property(p => p.sfNumericTextBoxProductPrice.Value, 1, "Product price field")

                .PersistOn(nameof(Move), nameof(ResizeEnd), nameof(Closing))
                .StopTrackingOn(nameof(FormClosing));

            tracker.Track(this);

            SetUpControls();
        }

        #region ControlsSetUp
        private void SetUpControls()
        {
            //Dirty trick to hide lag when resizing
            ResizeBegin += (s, e) => { SuspendLayout(); };
            ResizeEnd += (s, e) => { ResumeLayout(true); };

            //Form's title
            Text = $"Inline Skates Manager | {_appSettings.Version}";

            //DB Actions
            UpdateCustomerItems();
            UpdateProductItems();

            //Customers Tab
            //DataGrid
            sfDataGridCustomers.SearchController.SearchColor = Color.LightGreen;

            sfDataGridCustomers.RecordContextMenu = new ContextMenuStrip();
            sfDataGridCustomers.RecordContextMenu.Items.Add("Delete", null, OnDeleteCustomerClicked);

            //sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "CustomerId", HeaderText = "Customer ID", AllowEditing = false});
            sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "CustomerName", HeaderText = "Customer Name" });
            sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "OrderId", HeaderText = "Order ID", AllowEditing = false });
            sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "ProductName", HeaderText = "Product Name" });
            sfDataGridCustomers.Columns.Add(new GridNumericColumn() { MappingName = "ProductPrice", HeaderText = "Product Price (zł)"});
            sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "InvoiceId", HeaderText = "Invoice ID", AllowEditing = false});
            sfDataGridCustomers.Columns.Add(new GridDateTimeColumn() { MappingName = "PurchaseDate", HeaderText = "Purchase Date", Format = "dd/MM/yyyy HH:mm:ss" });

            sfDataGridCustomers.DataSource = CustomerItems;

            //Customer Name
            sfButtonCustomer.Enabled = !string.IsNullOrWhiteSpace(textBoxExtCustomerName.Text);

            //Product Selection
            comboDropDownProduct.MaxDropDownItems = 5;

            comboDropDownProduct.DataSource = ProductItems.Select(i => $"{i.ProductName} - {i.ProductPrice}zł").ToList();

            //Products Tab
            //DataGrid
            ProductItems.CollectionChanged += ProductItems_CollectionChanged;

            sfDataGridProducts.SearchController.SearchColor = Color.LightGreen;

            sfDataGridProducts.RecordContextMenu = new ContextMenuStrip();
            sfDataGridProducts.RecordContextMenu.Items.Add("Delete", null, OnDeleteProductClicked);

            sfDataGridProducts.Columns.Add(new GridTextColumn() { MappingName = "ProductId", HeaderText = "Product ID", AllowEditing = false});
            sfDataGridProducts.Columns.Add(new GridTextColumn() { MappingName = "ProductName", HeaderText = "Product Name" });
            sfDataGridProducts.Columns.Add(new GridNumericColumn() { MappingName = "ProductPrice", HeaderText = "Product Price (zł)" });

            sfDataGridProducts.DataSource = ProductItems;

            //Product Name
            sfButtonProduct.Enabled = !string.IsNullOrWhiteSpace(textBoxExtProductName.Text);

            //Product Price
            sfNumericTextBoxProductPrice.NumberFormatInfo = new CultureInfo("pl-PL").NumberFormat;
        }
        #endregion

        //Customers Tab
        private void UpdateCustomerItems()
        {
            var customersTable = customersTableAdapter1.GetData();
            foreach (DataRow tableRow in customersTable.Rows)
            {
                CustomerItems.Add(new CustomerModel()
                {
                    CustomerId = (int)tableRow.ItemArray[0],
                    CustomerName = tableRow.ItemArray[1].ToString(),
                    PurchaseDate = (DateTime)tableRow.ItemArray[2]
                });
            }

            var ordersTable = ordersTableAdapter1.GetData();
            foreach (DataRow tableRow in ordersTable.Rows)
            {
                var customerItem = CustomerItems.First(i => i.CustomerId == (int)tableRow.ItemArray[1]);
                customerItem.OrderId = (int)tableRow.ItemArray[0];
                customerItem.ProductName = tableRow.ItemArray[2].ToString();
                customerItem.ProductPrice = (decimal)tableRow.ItemArray[3];
            }

            var invoiceTable = invoiceTableAdapter1.GetData();
            foreach (DataRow tableRow in invoiceTable.Rows)
            {
                var customerItem = CustomerItems.First(i => i.CustomerId == (int)tableRow.ItemArray[2]);
                customerItem.InvoiceId = (int)tableRow.ItemArray[0];
            }
        }

        public ObservableCollection<CustomerModel> CustomerItems { get; set; } = new ObservableCollection<CustomerModel>();

        private void textBoxExtSearchCustomers_TextChanged(object sender, EventArgs e) => sfDataGridCustomers.SearchController.Search(textBoxExtSearchCustomers.Text);
        private void checkBoxAdvCaseSensitiveCustomers_CheckStateChanged(object sender, EventArgs e) => sfDataGridCustomers.SearchController.AllowCaseSensitiveSearch = checkBoxAdvCaseSensitiveCustomers.Checked;

        private void OnDeleteCustomerClicked(object sender, EventArgs e)
        {
            var items = sfDataGridCustomers.SelectedItems.ToList<CustomerModel>().ToList();
            foreach (var item in items)
            {
                invoiceTableAdapter1.Delete(item.InvoiceId, item.OrderId, item.CustomerId);
                ordersTableAdapter1.Delete(item.OrderId, item.CustomerId, item.ProductName, item.ProductPrice);
                customersTableAdapter1.Delete(item.CustomerId, item.CustomerName, item.PurchaseDate);

                CustomerItems.Remove(item);
            }
        }

        private void sfDataGridCustomers_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            var item = sfDataGridCustomers.CurrentItem as CustomerModel;

            var customersTableItem = customersTableAdapter1.GetCustomer(item.CustomerId);
            var ordersTableItem = ordersTableAdapter1.GetOrder(item.OrderId);

            string dbCustomerName = customersTableItem.Rows[0].ItemArray[1].ToString();
            DateTime dbPurchaseDate = (DateTime)customersTableItem.Rows[0].ItemArray[2];
            string dbProductName = ordersTableItem.Rows[0].ItemArray[2].ToString();
            decimal dbProductPrice = (decimal)ordersTableItem.Rows[0].ItemArray[3];

            if (item.CustomerName != dbCustomerName || item.PurchaseDate != dbPurchaseDate)
                customersTableAdapter1.Update(item.CustomerName, item.PurchaseDate, item.CustomerId, dbCustomerName, dbPurchaseDate);

            if (item.ProductName != dbProductName || item.ProductPrice != dbProductPrice)
                ordersTableAdapter1.Update(item.CustomerId, item.ProductName, item.ProductPrice, item.OrderId, item.CustomerId, dbProductName, dbProductPrice);
        }

        private void textBoxCustomerName_TextChanged(object sender, EventArgs e) => sfButtonCustomer.Enabled = !string.IsNullOrWhiteSpace(textBoxExtCustomerName.Text);

        private void sfButtonAddDummyCustomers_Click(object sender, EventArgs e)
        {
            var customersTable = customersTableAdapter1.GetData();

            int correctId = 1;
            if (customersTable.Rows.Count != 0)
            {
                var lastItem = customersTable.Rows[customersTable.Rows.Count - 1];
                correctId = (int)lastItem.ItemArray[0] + 1;
            }

            var random = new Random();
            for (int i = correctId; i < correctId + 5; i++)
            {
                string customerName = _appSettings.DummyData.UserNames[random.Next(_appSettings.DummyData.UserNames.Count)];
                string productName = _appSettings.DummyData.Products[random.Next(_appSettings.DummyData.Products.Count)];
                int productPrice = random.Next(1, 5_000);
                var purchaseTime = DateTime.Now;

                int customerId = (int)customersTableAdapter1.InsertCustomer(customerName, purchaseTime);
                int orderId = (int)ordersTableAdapter1.InsertOrder(customerId, productName, productPrice);
                int invoiceId = (int)invoiceTableAdapter1.InsertInvoice(orderId, customerId);

                CustomerItems.Add(new CustomerModel()
                {
                    CustomerId = customerId,
                    CustomerName = customerName,
                    OrderId = orderId,
                    ProductName = productName,
                    ProductPrice = productPrice,
                    InvoiceId = invoiceId,
                    PurchaseDate = purchaseTime
                });
            }
        }

        private void sfButtonAddCustomer_Click(object sender, EventArgs e)
        {
            string selectedProduct = comboDropDownProduct.SelectedValue as string;
            if (string.IsNullOrWhiteSpace(selectedProduct))
            {
                MessageBox.Show("Add a new product in the second tab!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string customerName = textBoxExtCustomerName.Text;
            string selectedProductName = selectedProduct.Split('-')[0].TrimEnd();
            ProductModel product = ProductItems.FirstOrDefault(i => i.ProductName == selectedProductName);
            if (product is null)
            {
                MessageBox.Show($"The product \"{selectedProductName}\" that you provided is incorrect! Make sure to not add any \"-\" letters.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var purchaseTime = DateTime.Now;

            int customerId = (int)customersTableAdapter1.InsertCustomer(customerName, purchaseTime);
            int orderId = (int)ordersTableAdapter1.InsertOrder(customerId, product.ProductName, product.ProductPrice);
            int invoiceId = (int)invoiceTableAdapter1.InsertInvoice(orderId, customerId);

            CustomerItems.Add(new CustomerModel()
            {
                CustomerId = customerId,
                CustomerName = customerName,
                OrderId = orderId,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                InvoiceId = invoiceId,
                PurchaseDate = purchaseTime
            });
        }

        private void sfButtonGenerateInvoice_Click(object sender, EventArgs e)
        {
            if (sfDataGridCustomers.SelectedItem is null)
            {
                MessageBox.Show("You need to select appropriate customer first!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string invoiceLocation = AppDomain.CurrentDomain.BaseDirectory + "AppInvoices";
            if (Directory.Exists(invoiceLocation) is false)
                Directory.CreateDirectory(invoiceLocation);

            var item = sfDataGridCustomers.CurrentItem as CustomerModel;
            var list = CustomerItems.Where(i => i.CustomerName == item.CustomerName).ToList();

            string customerName = list[0].CustomerName;
            string orderIds = string.Join(", ", list.Select(x => x.OrderId));
            string boughtProducts = string.Join(", ", list.Select(x => x.ProductName));
            decimal totalPrice = list.Sum(i => i.ProductPrice);
            string invoiceIds = string.Join(", ", list.Select(x => x.InvoiceId));
            string purchaseDate = string.Join(", ", list.Select(x => x.PurchaseDate));

            string invoice = $"Customer Name: {customerName}\n" +
                             $"Order ID(s): {orderIds}\n" +
                             $"Bought Product(s): {boughtProducts}\n" +
                             $"Total Price: {totalPrice}zł\n" +
                             $"Invoice ID(s): {invoiceIds}\n" +
                             $"Purchase Date(s): {purchaseDate}";

            string folderLocation = invoiceLocation + $"\\{DateTime.Now:dd_MM_yyyy_HH_mm_ss}.txt";
            File.AppendAllText(folderLocation, invoice);

            MessageBox.Show("An invoice file has been created! Click the button on the right to see it.", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sfButtonOpenFolder_Click(object sender, EventArgs e)
        {
            string invoiceLocation = AppDomain.CurrentDomain.BaseDirectory + "AppInvoices";
            if (Directory.Exists(invoiceLocation) is false)
            {
                var result = MessageBox.Show("The folder doesn't exist. Create it?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                Directory.CreateDirectory(invoiceLocation);
            }

            Process.Start(new ProcessStartInfo() { FileName = invoiceLocation });
        }

        //Products Tab
        private void UpdateProductItems()
        {
            var productsTable = productsTableAdapter1.GetData();
            foreach (DataRow productsTableRow in productsTable.Rows)
            {
                ProductItems.Add(new ProductModel()
                {
                    ProductId = (int)productsTableRow.ItemArray[0],
                    ProductName = productsTableRow.ItemArray[1].ToString(),
                    ProductPrice = (decimal)productsTableRow.ItemArray[2]
                });
            }
        }

        public ObservableCollection<ProductModel> ProductItems { get; set; } = new ObservableCollection<ProductModel>();

        private void ProductItems_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            comboDropDownProduct.DataSource = ProductItems.Select(i => $"{i.ProductName} - {i.ProductPrice}zł").ToList();
        }

        private void textBoxExtSearchProducts_TextChanged(object sender, EventArgs e) => sfDataGridProducts.SearchController.Search(textBoxExtSearchProducts.Text);
        private void checkBoxAdvCaseSensitiveProducts_CheckStateChanged(object sender, EventArgs e) => sfDataGridProducts.SearchController.AllowCaseSensitiveSearch = checkBoxAdvCaseSensitiveProducts.Checked;

        private void OnDeleteProductClicked(object sender, EventArgs e)
        {
            var items = sfDataGridProducts.SelectedItems.ToList<ProductModel>().ToList();
            foreach (var item in items)
            {
                productsTableAdapter1.DeleteProduct(item.ProductId);
                ProductItems.Remove(item);
            }
        }

        private void sfDataGridProducts_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            var item = sfDataGridProducts.CurrentItem as ProductModel;

            var productsTableItem = productsTableAdapter1.GetProduct(item.ProductId);
            string dbProductName = productsTableItem.Rows[0].ItemArray[1].ToString();
            decimal dbProductPrice = (decimal)productsTableItem.Rows[0].ItemArray[2];

            if (item.ProductName != dbProductName || item.ProductPrice != dbProductPrice)
            {
                productsTableAdapter1.Update(item.ProductName, item.ProductPrice, item.ProductId, dbProductName, dbProductPrice);

                ProductItems_CollectionChanged(null, null);
            }
        }

        private void textBoxExtProductName_TextChanged(object sender, EventArgs e) => sfButtonProduct.Enabled = !string.IsNullOrWhiteSpace(textBoxExtProductName.Text);

        private void sfButtonAddDummyProducts_Click(object sender, EventArgs e)
        {
            var productsTable = productsTableAdapter1.GetData();

            int correctId = 1;
            if (productsTable.Rows.Count != 0)
            {
                var lastItem = productsTable.Rows[productsTable.Rows.Count - 1];
                correctId = (int)lastItem.ItemArray[0] + 1;
            }

            var random = new Random();
            for (int i = correctId; i < correctId + 5; i++)
            {
                string productName = _appSettings.DummyData.Products[random.Next(_appSettings.DummyData.Products.Count)];
                decimal productPrice = random.Next(1, 5_000);

                int id = (int)productsTableAdapter1.InsertProduct(productName, productPrice);

                ProductItems.Add(new ProductModel()
                {
                    ProductId = id,
                    ProductName = productName,
                    ProductPrice = productPrice
                });
            }
        }

        private void sfButtonAddProduct_Click(object sender, EventArgs e)
        {
            var productItem = ProductItems.FirstOrDefault(i => i.ProductName == textBoxExtProductName.Text);
            if (productItem != null)
            {
                MessageBox.Show($"The product: \"{textBoxExtProductName.Text}\" is already in the database!", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string productName = textBoxExtProductName.Text;
                decimal productPrice = (decimal)sfNumericTextBoxProductPrice.Value;

                int id = (int)productsTableAdapter1.InsertProduct(productName, productPrice);

                ProductItems.Add(new ProductModel()
                {
                    ProductId = id,
                    ProductName = productName,
                    ProductPrice = productPrice
                });
            }
        }

        //Options Tab
        private void sfButtonOpenSettings_Click(object sender, EventArgs e)
        {
            string folderPath = @Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/../Roaming/InlineSkatesApp";
            if (Directory.Exists(folderPath))
                Process.Start(new ProcessStartInfo() { FileName = folderPath });
            else
                MessageBox.Show("The file doesn't exist on your PC!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}