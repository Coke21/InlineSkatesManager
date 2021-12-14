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

                .PersistOn(nameof(Closed));
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
            //PopulateCustomers();
            PopulateProducts();

            //Customers Tab
            //DataGrid
            sfDataGridCustomers.SearchController.SearchColor = Color.LightGreen;

            sfDataGridCustomers.RecordContextMenu = new ContextMenuStrip();
            sfDataGridCustomers.RecordContextMenu.Items.Add("Delete", null, OnDeleteCustomerClicked);

            sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "CustomerId", HeaderText = "Customer ID" });
            sfDataGridCustomers.Columns[0].AllowEditing = false;

            sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "CustomerName", HeaderText = "Customer Name" });
            sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "ProductName", HeaderText = "Product" });
            sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "Product Price" });
            sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "Invoice" });
            sfDataGridCustomers.Columns.Add(new GridTextColumn() { MappingName = "Purchase Date" });

            sfDataGridCustomers.DataSource = CustomerItems;

            //Customer Name
            sfButtonCustomer.Enabled = !string.IsNullOrWhiteSpace(textBoxExtCustomerName.Text);

            //Product Selection
            comboDropDownProduct.MaxDropDownItems = 5;

            comboDropDownProduct.DataSource = ProductItems.Select(i => i.ProductName).ToList();

            //Products Tab
            //DataGrid
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

        private void PopulateCustomers()
        {
            //var customersTable = customersTableAdapter1.GetData();
            //var ordersTable = ordersTableAdapter1.GetData();
            //foreach (DataRow customersTableRow in customersTable.Rows)
            //{

            //}
        }

        private void PopulateProducts()
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

        //Customers Tab
        public ObservableCollection<CustomerModel> CustomerItems { get; set; } = new ObservableCollection<CustomerModel>();

        private void textBoxExtSearchCustomers_TextChanged(object sender, EventArgs e) => sfDataGridCustomers.SearchController.Search(textBoxExtSearchCustomers.Text);
        private void checkBoxAdvCaseSensitiveCustomers_CheckStateChanged(object sender, EventArgs e) => sfDataGridCustomers.SearchController.AllowCaseSensitiveSearch = checkBoxAdvCaseSensitiveCustomers.Checked;

        private void OnDeleteCustomerClicked(object sender, EventArgs e)
        {
            CustomerItems.Remove(sfDataGridCustomers.SelectedItem as CustomerModel);
            //Update db
        }

        private void sfDataGridCustomers_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            var sfDataGrid = sender as SfDataGrid;
            var item = sfDataGrid.SelectedItem as CustomerModel;

            //Get item from db, check if different

        }

        private void textBoxCustomerName_TextChanged(object sender, EventArgs e) => sfButtonCustomer.Enabled = !string.IsNullOrWhiteSpace(textBoxExtCustomerName.Text);

        private void sfButtonAddDummy_Click(object sender, EventArgs e)
        {
            //Get latest item from db then increment customerId

            var random = new Random();
            for (int i = 0; i < 3; i++)
            {
                CustomerItems.Add(new CustomerModel()
                {
                    CustomerId = i,
                    CustomerName = _appSettings.DummyData.UserNames[random.Next(_appSettings.DummyData.UserNames.Count)],
                    ProductName = _appSettings.DummyData.Products[random.Next(_appSettings.DummyData.Products.Count)]
                });
            }
        }

        private void sfButtonAddCustomer_Click(object sender, EventArgs e)
        {

        }

        //Products Tab
        public ObservableCollection<ProductModel> ProductItems { get; set; } = new ObservableCollection<ProductModel>();

        private void textBoxExtSearchProducts_TextChanged(object sender, EventArgs e) => sfDataGridProducts.SearchController.Search(textBoxExtSearchProducts.Text);
        private void checkBoxAdvCaseSensitiveProducts_CheckStateChanged(object sender, EventArgs e) => sfDataGridProducts.SearchController.AllowCaseSensitiveSearch = checkBoxAdvCaseSensitiveProducts.Checked;

        private void OnDeleteProductClicked(object sender, EventArgs e)
        {
            ProductItems.Remove(sfDataGridProducts.SelectedItem as ProductModel);
            //Update db
        }

        private void sfDataGridProducts_CurrentCellEndEdit(object sender, Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventArgs e)
        {
            var sfDataGrid = sender as SfDataGrid;
            var item = sfDataGrid.SelectedItem as ProductModel;

            //Get item from db, check if different
        }

        private void textBoxExtProductName_TextChanged(object sender, EventArgs e) => sfButtonProduct.Enabled = !string.IsNullOrWhiteSpace(textBoxExtProductName.Text);

        private void sfButtonAddDummyProducts_Click(object sender, EventArgs e)
        {
            //Get latest item from db then increment customerId

            var random = new Random();
            for (int i = 0; i < 3; i++)
            {
                ProductItems.Add(new ProductModel()
                {
                    ProductId = i,
                    ProductName = _appSettings.DummyData.Products[random.Next(_appSettings.DummyData.Products.Count)]
                });
            }
        }

        private void sfButtonAddProduct_Click(object sender, EventArgs e)
        {
            var productItem = ProductItems.FirstOrDefault(i => i.ProductName == textBoxExtProductName.Text);
            if (productItem != null)
            {
                //var item = productsTableAdapter1.IsProductAlreadyPresent(productItem.ProductId);

                MessageBox.Show($"The item: \"{textBoxExtProductName.Text}\" is already in the database!", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string productName = textBoxExtProductName.Text;
                decimal productPrice = (decimal)sfNumericTextBoxProductPrice.Value;

                var id = productsTableAdapter1.InsertProduct(productName, productPrice);

                ProductItems.Add(new ProductModel()
                {
                    ProductId = (int)id,
                    ProductName = productName,
                    ProductPrice = productPrice
                });
            }
        }

        //Options Tab
        private void sfButtonOpenSettings_Click(object sender, EventArgs e)
        {
            string filePath = @Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/../Roaming/InlineSkatesApp/InlineSkatesApp";
            if (Directory.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            else
                MessageBox.Show("The file doesn't exist on your PC!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}