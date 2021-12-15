using System.Windows.Forms;
using InlineSkatesApp.Db.DbMapTableAdapters;

namespace InlineSkatesApp
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.comboDropDownProduct = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sfDataGridCustomers = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxExtSearchCustomers = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.checkBoxAdvCaseSensitiveCustomers = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sfButtonDummy = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBoxExtCustomerName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfButtonGenerateInvoice = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButtonCustomer = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButtonOpenFolder = new Syncfusion.WinForms.Controls.SfButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.sfDataGridProducts = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxExtSearchProducts = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.checkBoxAdvCaseSensitiveProducts = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.sfNumericTextBoxProductPrice = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.textBoxExtProductName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.sfButtonProduct = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButtonDummyProducts = new Syncfusion.WinForms.Controls.SfButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.sfButtonOpenSettings = new Syncfusion.WinForms.Controls.SfButton();
            this.sfToolTip1 = new Syncfusion.Windows.Forms.SfToolTip(this.components);
            this.productsTableAdapter1 = new InlineSkatesApp.Db.DbMapTableAdapters.ProductsTableAdapter();
            this.ordersTableAdapter1 = new InlineSkatesApp.Db.DbMapTableAdapters.OrdersTableAdapter();
            this.customersTableAdapter1 = new InlineSkatesApp.Db.DbMapTableAdapters.CustomersTableAdapter();
            this.invoiceTableAdapter1 = new InlineSkatesApp.Db.DbMapTableAdapters.InvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDownProduct)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridCustomers)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExtSearchCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdvCaseSensitiveCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExtCustomerName)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridProducts)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExtSearchProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdvCaseSensitiveProducts)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExtProductName)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboDropDownProduct
            // 
            this.comboDropDownProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDropDownProduct.BeforeTouchSize = new System.Drawing.Size(513, 23);
            this.comboDropDownProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDropDownProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboDropDownProduct.Location = new System.Drawing.Point(106, 36);
            this.comboDropDownProduct.Name = "comboDropDownProduct";
            this.comboDropDownProduct.Size = new System.Drawing.Size(513, 23);
            this.comboDropDownProduct.TabIndex = 16;
            this.sfToolTip1.SetToolTip(this.comboDropDownProduct, "Select appropriate product to sell");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 539);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanelMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(870, 493);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(864, 357);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customers";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.sfDataGridCustomers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(858, 335);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // sfDataGridCustomers
            // 
            this.sfDataGridCustomers.AccessibleName = "Table";
            this.sfDataGridCustomers.AllowFiltering = true;
            this.sfDataGridCustomers.AutoGenerateColumns = false;
            this.sfDataGridCustomers.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGridCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridCustomers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sfDataGridCustomers.Location = new System.Drawing.Point(3, 41);
            this.sfDataGridCustomers.Name = "sfDataGridCustomers";
            this.sfDataGridCustomers.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.sfDataGridCustomers.SerializationController = null;
            this.sfDataGridCustomers.Size = new System.Drawing.Size(852, 291);
            this.sfDataGridCustomers.TabIndex = 1;
            this.sfDataGridCustomers.Text = "sfDataGrid1";
            this.sfDataGridCustomers.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.sfDataGridCustomers_CurrentCellEndEdit);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.textBoxExtSearchCustomers, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.autoLabel5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.checkBoxAdvCaseSensitiveCustomers, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(852, 32);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // textBoxExtSearchCustomers
            // 
            this.textBoxExtSearchCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtSearchCustomers.BeforeTouchSize = new System.Drawing.Size(411, 23);
            this.textBoxExtSearchCustomers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxExtSearchCustomers.Location = new System.Drawing.Point(54, 4);
            this.textBoxExtSearchCustomers.Name = "textBoxExtSearchCustomers";
            this.textBoxExtSearchCustomers.Size = new System.Drawing.Size(688, 23);
            this.textBoxExtSearchCustomers.TabIndex = 2;
            this.sfToolTip1.SetToolTip(this.textBoxExtSearchCustomers, "Enter a word that you would like to search for");
            this.textBoxExtSearchCustomers.TextChanged += new System.EventHandler(this.textBoxExtSearchCustomers_TextChanged);
            // 
            // autoLabel5
            // 
            this.autoLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.autoLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autoLabel5.Location = new System.Drawing.Point(3, 8);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(45, 15);
            this.autoLabel5.TabIndex = 17;
            this.autoLabel5.Text = "Search:";
            // 
            // checkBoxAdvCaseSensitiveCustomers
            // 
            this.checkBoxAdvCaseSensitiveCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdvCaseSensitiveCustomers.BeforeTouchSize = new System.Drawing.Size(101, 18);
            this.checkBoxAdvCaseSensitiveCustomers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxAdvCaseSensitiveCustomers.Location = new System.Drawing.Point(748, 7);
            this.checkBoxAdvCaseSensitiveCustomers.Name = "checkBoxAdvCaseSensitiveCustomers";
            this.checkBoxAdvCaseSensitiveCustomers.Size = new System.Drawing.Size(101, 18);
            this.checkBoxAdvCaseSensitiveCustomers.TabIndex = 18;
            this.checkBoxAdvCaseSensitiveCustomers.Text = "Case Sensitive";
            this.sfToolTip1.SetToolTip(this.checkBoxAdvCaseSensitiveCustomers, "Search for case sensitive item");
            this.checkBoxAdvCaseSensitiveCustomers.CheckStateChanged += new System.EventHandler(this.checkBoxAdvCaseSensitiveCustomers_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Settings";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.sfButtonDummy, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.autoLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxExtCustomerName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboDropDownProduct, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.autoLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sfButtonGenerateInvoice, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.sfButtonCustomer, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.sfButtonOpenFolder, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(858, 102);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // sfButtonDummy
            // 
            this.sfButtonDummy.AccessibleName = "Button";
            this.sfButtonDummy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sfButtonDummy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonDummy.Location = new System.Drawing.Point(290, 69);
            this.sfButtonDummy.Name = "sfButtonDummy";
            this.sfButtonDummy.Size = new System.Drawing.Size(144, 27);
            this.sfButtonDummy.TabIndex = 2;
            this.sfButtonDummy.Text = "Add Dummy Customers";
            this.sfToolTip1.SetToolTip(this.sfButtonDummy, "Add dummy data to the Customers above");
            this.sfButtonDummy.UseVisualStyleBackColor = true;
            this.sfButtonDummy.Click += new System.EventHandler(this.sfButtonAddDummyCustomers_Click);
            // 
            // autoLabel2
            // 
            this.autoLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.autoLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autoLabel2.Location = new System.Drawing.Point(48, 39);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(52, 15);
            this.autoLabel2.TabIndex = 9;
            this.autoLabel2.Text = "Product:";
            // 
            // textBoxExtCustomerName
            // 
            this.textBoxExtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtCustomerName.BeforeTouchSize = new System.Drawing.Size(411, 23);
            this.textBoxExtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxExtCustomerName.Location = new System.Drawing.Point(106, 3);
            this.textBoxExtCustomerName.Name = "textBoxExtCustomerName";
            this.textBoxExtCustomerName.Size = new System.Drawing.Size(513, 23);
            this.textBoxExtCustomerName.TabIndex = 4;
            this.sfToolTip1.SetToolTip(this.textBoxExtCustomerName, "Enter customer\'s name");
            this.textBoxExtCustomerName.TextChanged += new System.EventHandler(this.textBoxCustomerName_TextChanged);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.autoLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autoLabel1.Location = new System.Drawing.Point(3, 7);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(97, 15);
            this.autoLabel1.TabIndex = 8;
            this.autoLabel1.Text = "Customer Name:";
            // 
            // sfButtonGenerateInvoice
            // 
            this.sfButtonGenerateInvoice.AccessibleName = "Button";
            this.sfButtonGenerateInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sfButtonGenerateInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonGenerateInvoice.Location = new System.Drawing.Point(625, 33);
            this.sfButtonGenerateInvoice.Name = "sfButtonGenerateInvoice";
            this.sfButtonGenerateInvoice.Size = new System.Drawing.Size(104, 28);
            this.sfButtonGenerateInvoice.TabIndex = 17;
            this.sfButtonGenerateInvoice.Text = "Generate Invoice";
            this.sfToolTip1.SetToolTip(this.sfButtonGenerateInvoice, "Generate Invoice from the selected Customer");
            this.sfButtonGenerateInvoice.Click += new System.EventHandler(this.sfButtonGenerateInvoice_Click);
            // 
            // sfButtonCustomer
            // 
            this.sfButtonCustomer.AccessibleName = "Button";
            this.sfButtonCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.sfButtonCustomer, 2);
            this.sfButtonCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonCustomer.Location = new System.Drawing.Point(691, 3);
            this.sfButtonCustomer.Name = "sfButtonCustomer";
            this.sfButtonCustomer.Size = new System.Drawing.Size(97, 24);
            this.sfButtonCustomer.TabIndex = 3;
            this.sfButtonCustomer.Text = "Add Customer";
            this.sfToolTip1.SetToolTip(this.sfButtonCustomer, "Add a new customer with the entered information on the left ");
            this.sfButtonCustomer.UseVisualStyleBackColor = true;
            this.sfButtonCustomer.Click += new System.EventHandler(this.sfButtonAddCustomer_Click);
            // 
            // sfButtonOpenFolder
            // 
            this.sfButtonOpenFolder.AccessibleName = "Button";
            this.sfButtonOpenFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sfButtonOpenFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonOpenFolder.Location = new System.Drawing.Point(735, 33);
            this.sfButtonOpenFolder.Name = "sfButtonOpenFolder";
            this.sfButtonOpenFolder.Size = new System.Drawing.Size(120, 28);
            this.sfButtonOpenFolder.TabIndex = 18;
            this.sfButtonOpenFolder.Text = "Open Invoice Folder";
            this.sfToolTip1.SetToolTip(this.sfButtonOpenFolder, "Open folder with invoices");
            this.sfButtonOpenFolder.Click += new System.EventHandler(this.sfButtonOpenFolder_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel7);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(870, 493);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(133, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(603, 357);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products ";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.sfDataGridProducts, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(597, 335);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // sfDataGridProducts
            // 
            this.sfDataGridProducts.AccessibleName = "Table";
            this.sfDataGridProducts.AllowFiltering = true;
            this.sfDataGridProducts.AutoGenerateColumns = false;
            this.sfDataGridProducts.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.sfDataGridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGridProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sfDataGridProducts.Location = new System.Drawing.Point(3, 41);
            this.sfDataGridProducts.Name = "sfDataGridProducts";
            this.sfDataGridProducts.NotifyEventsToParentDataGrid = true;
            this.sfDataGridProducts.SelectionMode = Syncfusion.WinForms.DataGrid.Enums.GridSelectionMode.Extended;
            this.sfDataGridProducts.SerializationController = null;
            this.sfDataGridProducts.Size = new System.Drawing.Size(591, 291);
            this.sfDataGridProducts.TabIndex = 5;
            this.sfDataGridProducts.Text = "sfDataGrid1";
            this.sfDataGridProducts.CurrentCellEndEdit += new Syncfusion.WinForms.DataGrid.Events.CurrentCellEndEditEventHandler(this.sfDataGridProducts_CurrentCellEndEdit);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.textBoxExtSearchProducts, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.autoLabel3, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.checkBoxAdvCaseSensitiveProducts, 2, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(591, 32);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // textBoxExtSearchProducts
            // 
            this.textBoxExtSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtSearchProducts.BeforeTouchSize = new System.Drawing.Size(411, 23);
            this.textBoxExtSearchProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxExtSearchProducts.Location = new System.Drawing.Point(54, 4);
            this.textBoxExtSearchProducts.Name = "textBoxExtSearchProducts";
            this.textBoxExtSearchProducts.Size = new System.Drawing.Size(424, 23);
            this.textBoxExtSearchProducts.TabIndex = 2;
            this.sfToolTip1.SetToolTip(this.textBoxExtSearchProducts, "Enter a word that you would like to search for");
            this.textBoxExtSearchProducts.TextChanged += new System.EventHandler(this.textBoxExtSearchProducts_TextChanged);
            // 
            // autoLabel3
            // 
            this.autoLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.autoLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autoLabel3.Location = new System.Drawing.Point(3, 8);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(45, 15);
            this.autoLabel3.TabIndex = 17;
            this.autoLabel3.Text = "Search:";
            // 
            // checkBoxAdvCaseSensitiveProducts
            // 
            this.checkBoxAdvCaseSensitiveProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdvCaseSensitiveProducts.BeforeTouchSize = new System.Drawing.Size(104, 18);
            this.checkBoxAdvCaseSensitiveProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxAdvCaseSensitiveProducts.Location = new System.Drawing.Point(484, 7);
            this.checkBoxAdvCaseSensitiveProducts.Name = "checkBoxAdvCaseSensitiveProducts";
            this.checkBoxAdvCaseSensitiveProducts.Size = new System.Drawing.Size(104, 18);
            this.checkBoxAdvCaseSensitiveProducts.TabIndex = 18;
            this.checkBoxAdvCaseSensitiveProducts.Text = "Case Sensitive";
            this.sfToolTip1.SetToolTip(this.checkBoxAdvCaseSensitiveProducts, "Search for case sensitive item");
            this.checkBoxAdvCaseSensitiveProducts.CheckStateChanged += new System.EventHandler(this.checkBoxAdvCaseSensitiveProducts_CheckStateChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel10);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(133, 366);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(603, 124);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Product Settings";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.Controls.Add(this.autoLabel6, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.autoLabel4, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.sfNumericTextBoxProductPrice, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.textBoxExtProductName, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.sfButtonProduct, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.sfButtonDummyProducts, 1, 2);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(597, 102);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // autoLabel6
            // 
            this.autoLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.autoLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autoLabel6.Location = new System.Drawing.Point(9, 36);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(81, 15);
            this.autoLabel6.TabIndex = 10;
            this.autoLabel6.Text = "Product Price:";
            // 
            // autoLabel4
            // 
            this.autoLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.autoLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.autoLabel4.Location = new System.Drawing.Point(3, 7);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(87, 15);
            this.autoLabel4.TabIndex = 9;
            this.autoLabel4.Text = "Product Name:";
            // 
            // sfNumericTextBoxProductPrice
            // 
            this.sfNumericTextBoxProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sfNumericTextBoxProductPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sfNumericTextBoxProductPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sfNumericTextBoxProductPrice.FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency;
            this.sfNumericTextBoxProductPrice.Location = new System.Drawing.Point(96, 32);
            this.sfNumericTextBoxProductPrice.MinValue = 1D;
            this.sfNumericTextBoxProductPrice.Name = "sfNumericTextBoxProductPrice";
            this.sfNumericTextBoxProductPrice.Size = new System.Drawing.Size(411, 23);
            this.sfNumericTextBoxProductPrice.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sfNumericTextBoxProductPrice.TabIndex = 2;
            this.sfNumericTextBoxProductPrice.Text = "$1.00";
            this.sfToolTip1.SetToolTip(this.sfNumericTextBoxProductPrice, "Enter product\'s price");
            this.sfNumericTextBoxProductPrice.Value = 1D;
            // 
            // textBoxExtProductName
            // 
            this.textBoxExtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtProductName.BeforeTouchSize = new System.Drawing.Size(411, 23);
            this.textBoxExtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxExtProductName.Location = new System.Drawing.Point(96, 3);
            this.textBoxExtProductName.Name = "textBoxExtProductName";
            this.textBoxExtProductName.Size = new System.Drawing.Size(411, 23);
            this.textBoxExtProductName.TabIndex = 11;
            this.sfToolTip1.SetToolTip(this.textBoxExtProductName, "Enter product\'s name");
            this.textBoxExtProductName.TextChanged += new System.EventHandler(this.textBoxExtProductName_TextChanged);
            // 
            // sfButtonProduct
            // 
            this.sfButtonProduct.AccessibleName = "Button";
            this.sfButtonProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sfButtonProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonProduct.Location = new System.Drawing.Point(513, 17);
            this.sfButtonProduct.Name = "sfButtonProduct";
            this.tableLayoutPanel10.SetRowSpan(this.sfButtonProduct, 2);
            this.sfButtonProduct.Size = new System.Drawing.Size(81, 24);
            this.sfButtonProduct.TabIndex = 13;
            this.sfButtonProduct.Text = "Add Product";
            this.sfToolTip1.SetToolTip(this.sfButtonProduct, "Add a new product with the entered information on the left ");
            this.sfButtonProduct.UseVisualStyleBackColor = true;
            this.sfButtonProduct.Click += new System.EventHandler(this.sfButtonAddProduct_Click);
            // 
            // sfButtonDummyProducts
            // 
            this.sfButtonDummyProducts.AccessibleName = "Button";
            this.sfButtonDummyProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sfButtonDummyProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonDummyProducts.Location = new System.Drawing.Point(234, 68);
            this.sfButtonDummyProducts.Name = "sfButtonDummyProducts";
            this.sfButtonDummyProducts.Size = new System.Drawing.Size(134, 24);
            this.sfButtonDummyProducts.TabIndex = 14;
            this.sfButtonDummyProducts.Text = "Add Dummy Products";
            this.sfToolTip1.SetToolTip(this.sfButtonDummyProducts, "Add dummy data to the Products above");
            this.sfButtonDummyProducts.UseVisualStyleBackColor = true;
            this.sfButtonDummyProducts.Click += new System.EventHandler(this.sfButtonAddDummyProducts_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(870, 493);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(293, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 240);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.sfButtonOpenSettings, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(278, 218);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // sfButtonOpenSettings
            // 
            this.sfButtonOpenSettings.AccessibleName = "Button";
            this.sfButtonOpenSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sfButtonOpenSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButtonOpenSettings.Location = new System.Drawing.Point(82, 97);
            this.sfButtonOpenSettings.Name = "sfButtonOpenSettings";
            this.sfButtonOpenSettings.Size = new System.Drawing.Size(113, 24);
            this.sfButtonOpenSettings.TabIndex = 0;
            this.sfButtonOpenSettings.Text = "Open App Settings";
            this.sfToolTip1.SetToolTip(this.sfButtonOpenSettings, "Open application settings; you can delete this folder if you want to get rid of a" +
        "pplication settings");
            this.sfButtonOpenSettings.UseVisualStyleBackColor = true;
            this.sfButtonOpenSettings.Click += new System.EventHandler(this.sfButtonOpenSettings_Click);
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter1
            // 
            this.invoiceTableAdapter1.ClearBeforeFill = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 543);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(688, 439);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDownProduct)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridCustomers)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExtSearchCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdvCaseSensitiveCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExtCustomerName)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGridProducts)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExtSearchProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdvCaseSensitiveProducts)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExtProductName)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboDropDownProduct;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanelMain;
        private Syncfusion.Windows.Forms.SfToolTip sfToolTip1;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel6;
        private Syncfusion.WinForms.Controls.SfButton sfButtonOpenSettings;
        private TableLayoutPanel tableLayoutPanel7;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel8;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridProducts;
        private TableLayoutPanel tableLayoutPanel9;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExtSearchProducts;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdvCaseSensitiveProducts;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGridCustomers;
        private TableLayoutPanel tableLayoutPanel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExtSearchCustomers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdvCaseSensitiveCustomers;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Syncfusion.WinForms.Controls.SfButton sfButtonDummy;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExtCustomerName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton sfButtonCustomer;
        private GroupBox groupBox5;
        private TableLayoutPanel tableLayoutPanel10;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExtProductName;
        private Syncfusion.WinForms.Controls.SfButton sfButtonProduct;
        private Syncfusion.WinForms.Controls.SfButton sfButtonDummyProducts;
        private Syncfusion.WinForms.Input.SfNumericTextBox sfNumericTextBoxProductPrice;
        private ProductsTableAdapter productsTableAdapter1;
        private OrdersTableAdapter ordersTableAdapter1;
        private CustomersTableAdapter customersTableAdapter1;
        private InvoiceTableAdapter invoiceTableAdapter1;
        private Syncfusion.WinForms.Controls.SfButton sfButtonGenerateInvoice;
        private Syncfusion.WinForms.Controls.SfButton sfButtonOpenFolder;
    }
}