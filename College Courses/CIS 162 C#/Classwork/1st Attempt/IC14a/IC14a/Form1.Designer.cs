namespace IC14a
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label e_mail_AddressLabel;
            System.Windows.Forms.Label job_TitleLabel;
            System.Windows.Forms.Label business_PhoneLabel;
            System.Windows.Forms.Label home_PhoneLabel;
            System.Windows.Forms.Label mobile_PhoneLabel;
            System.Windows.Forms.Label fax_NumberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label state_ProvinceLabel;
            System.Windows.Forms.Label zIP_Postal_CodeLabel;
            System.Windows.Forms.Label country_RegionLabel;
            System.Windows.Forms.Label web_PageLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label attachmentsLabel;
            this.northwindDataSet = new IC14a.NorthwindDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new IC14a.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new IC14a.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.e_mail_AddressTextBox = new System.Windows.Forms.TextBox();
            this.job_TitleTextBox = new System.Windows.Forms.TextBox();
            this.business_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.home_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.mobile_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.fax_NumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.state_ProvinceTextBox = new System.Windows.Forms.TextBox();
            this.zIP_Postal_CodeTextBox = new System.Windows.Forms.TextBox();
            this.country_RegionTextBox = new System.Windows.Forms.TextBox();
            this.web_PageTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.attachmentsTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            e_mail_AddressLabel = new System.Windows.Forms.Label();
            job_TitleLabel = new System.Windows.Forms.Label();
            business_PhoneLabel = new System.Windows.Forms.Label();
            home_PhoneLabel = new System.Windows.Forms.Label();
            mobile_PhoneLabel = new System.Windows.Forms.Label();
            fax_NumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            state_ProvinceLabel = new System.Windows.Forms.Label();
            zIP_Postal_CodeLabel = new System.Windows.Forms.Label();
            country_RegionLabel = new System.Windows.Forms.Label();
            web_PageLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            attachmentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.northwindDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.Employee_PrivilegesTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Inventory_Transaction_TypesTableAdapter = null;
            this.tableAdapterManager.Inventory_TransactionsTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.Order_Details_StatusTableAdapter = null;
            this.tableAdapterManager.Order_DetailsTableAdapter = null;
            this.tableAdapterManager.Orders_StatusTableAdapter = null;
            this.tableAdapterManager.Orders_Tax_StatusTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PrivilegesTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.Purchase_Order_DetailsTableAdapter = null;
            this.tableAdapterManager.Purchase_Order_StatusTableAdapter = null;
            this.tableAdapterManager.Purchase_OrdersTableAdapter = null;
            this.tableAdapterManager.Sales_ReportsTableAdapter = null;
            this.tableAdapterManager.ShippersTableAdapter = null;
            this.tableAdapterManager.StringsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IC14a.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(519, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(156, 60);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(251, 57);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(156, 86);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 3;
            companyLabel.Text = "Company:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(251, 83);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 4;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(156, 112);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Last Name:";
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(251, 109);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.last_NameTextBox.TabIndex = 6;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(156, 138);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 7;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(251, 135);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_NameTextBox.TabIndex = 8;
            // 
            // e_mail_AddressLabel
            // 
            e_mail_AddressLabel.AutoSize = true;
            e_mail_AddressLabel.Location = new System.Drawing.Point(156, 164);
            e_mail_AddressLabel.Name = "e_mail_AddressLabel";
            e_mail_AddressLabel.Size = new System.Drawing.Size(79, 13);
            e_mail_AddressLabel.TabIndex = 9;
            e_mail_AddressLabel.Text = "E-mail Address:";
            // 
            // e_mail_AddressTextBox
            // 
            this.e_mail_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "E-mail Address", true));
            this.e_mail_AddressTextBox.Location = new System.Drawing.Point(251, 161);
            this.e_mail_AddressTextBox.Name = "e_mail_AddressTextBox";
            this.e_mail_AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.e_mail_AddressTextBox.TabIndex = 10;
            // 
            // job_TitleLabel
            // 
            job_TitleLabel.AutoSize = true;
            job_TitleLabel.Location = new System.Drawing.Point(156, 190);
            job_TitleLabel.Name = "job_TitleLabel";
            job_TitleLabel.Size = new System.Drawing.Size(50, 13);
            job_TitleLabel.TabIndex = 11;
            job_TitleLabel.Text = "Job Title:";
            // 
            // job_TitleTextBox
            // 
            this.job_TitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Job Title", true));
            this.job_TitleTextBox.Location = new System.Drawing.Point(251, 187);
            this.job_TitleTextBox.Name = "job_TitleTextBox";
            this.job_TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.job_TitleTextBox.TabIndex = 12;
            // 
            // business_PhoneLabel
            // 
            business_PhoneLabel.AutoSize = true;
            business_PhoneLabel.Location = new System.Drawing.Point(156, 216);
            business_PhoneLabel.Name = "business_PhoneLabel";
            business_PhoneLabel.Size = new System.Drawing.Size(86, 13);
            business_PhoneLabel.TabIndex = 13;
            business_PhoneLabel.Text = "Business Phone:";
            // 
            // business_PhoneTextBox
            // 
            this.business_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Business Phone", true));
            this.business_PhoneTextBox.Location = new System.Drawing.Point(251, 213);
            this.business_PhoneTextBox.Name = "business_PhoneTextBox";
            this.business_PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.business_PhoneTextBox.TabIndex = 14;
            // 
            // home_PhoneLabel
            // 
            home_PhoneLabel.AutoSize = true;
            home_PhoneLabel.Location = new System.Drawing.Point(156, 242);
            home_PhoneLabel.Name = "home_PhoneLabel";
            home_PhoneLabel.Size = new System.Drawing.Size(72, 13);
            home_PhoneLabel.TabIndex = 15;
            home_PhoneLabel.Text = "Home Phone:";
            // 
            // home_PhoneTextBox
            // 
            this.home_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Home Phone", true));
            this.home_PhoneTextBox.Location = new System.Drawing.Point(251, 239);
            this.home_PhoneTextBox.Name = "home_PhoneTextBox";
            this.home_PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.home_PhoneTextBox.TabIndex = 16;
            // 
            // mobile_PhoneLabel
            // 
            mobile_PhoneLabel.AutoSize = true;
            mobile_PhoneLabel.Location = new System.Drawing.Point(156, 268);
            mobile_PhoneLabel.Name = "mobile_PhoneLabel";
            mobile_PhoneLabel.Size = new System.Drawing.Size(75, 13);
            mobile_PhoneLabel.TabIndex = 17;
            mobile_PhoneLabel.Text = "Mobile Phone:";
            // 
            // mobile_PhoneTextBox
            // 
            this.mobile_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Mobile Phone", true));
            this.mobile_PhoneTextBox.Location = new System.Drawing.Point(251, 265);
            this.mobile_PhoneTextBox.Name = "mobile_PhoneTextBox";
            this.mobile_PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobile_PhoneTextBox.TabIndex = 18;
            // 
            // fax_NumberLabel
            // 
            fax_NumberLabel.AutoSize = true;
            fax_NumberLabel.Location = new System.Drawing.Point(156, 294);
            fax_NumberLabel.Name = "fax_NumberLabel";
            fax_NumberLabel.Size = new System.Drawing.Size(67, 13);
            fax_NumberLabel.TabIndex = 19;
            fax_NumberLabel.Text = "Fax Number:";
            // 
            // fax_NumberTextBox
            // 
            this.fax_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Fax Number", true));
            this.fax_NumberTextBox.Location = new System.Drawing.Point(251, 291);
            this.fax_NumberTextBox.Name = "fax_NumberTextBox";
            this.fax_NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.fax_NumberTextBox.TabIndex = 20;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(156, 320);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 21;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(251, 317);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 22;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(156, 346);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 23;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(251, 343);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 24;
            // 
            // state_ProvinceLabel
            // 
            state_ProvinceLabel.AutoSize = true;
            state_ProvinceLabel.Location = new System.Drawing.Point(156, 372);
            state_ProvinceLabel.Name = "state_ProvinceLabel";
            state_ProvinceLabel.Size = new System.Drawing.Size(82, 13);
            state_ProvinceLabel.TabIndex = 25;
            state_ProvinceLabel.Text = "State/Province:";
            // 
            // state_ProvinceTextBox
            // 
            this.state_ProvinceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "State/Province", true));
            this.state_ProvinceTextBox.Location = new System.Drawing.Point(251, 369);
            this.state_ProvinceTextBox.Name = "state_ProvinceTextBox";
            this.state_ProvinceTextBox.Size = new System.Drawing.Size(100, 20);
            this.state_ProvinceTextBox.TabIndex = 26;
            // 
            // zIP_Postal_CodeLabel
            // 
            zIP_Postal_CodeLabel.AutoSize = true;
            zIP_Postal_CodeLabel.Location = new System.Drawing.Point(156, 398);
            zIP_Postal_CodeLabel.Name = "zIP_Postal_CodeLabel";
            zIP_Postal_CodeLabel.Size = new System.Drawing.Size(89, 13);
            zIP_Postal_CodeLabel.TabIndex = 27;
            zIP_Postal_CodeLabel.Text = "ZIP/Postal Code:";
            // 
            // zIP_Postal_CodeTextBox
            // 
            this.zIP_Postal_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ZIP/Postal Code", true));
            this.zIP_Postal_CodeTextBox.Location = new System.Drawing.Point(251, 395);
            this.zIP_Postal_CodeTextBox.Name = "zIP_Postal_CodeTextBox";
            this.zIP_Postal_CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zIP_Postal_CodeTextBox.TabIndex = 28;
            // 
            // country_RegionLabel
            // 
            country_RegionLabel.AutoSize = true;
            country_RegionLabel.Location = new System.Drawing.Point(156, 424);
            country_RegionLabel.Name = "country_RegionLabel";
            country_RegionLabel.Size = new System.Drawing.Size(85, 13);
            country_RegionLabel.TabIndex = 29;
            country_RegionLabel.Text = "Country/Region:";
            // 
            // country_RegionTextBox
            // 
            this.country_RegionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Country/Region", true));
            this.country_RegionTextBox.Location = new System.Drawing.Point(251, 421);
            this.country_RegionTextBox.Name = "country_RegionTextBox";
            this.country_RegionTextBox.Size = new System.Drawing.Size(100, 20);
            this.country_RegionTextBox.TabIndex = 30;
            // 
            // web_PageLabel
            // 
            web_PageLabel.AutoSize = true;
            web_PageLabel.Location = new System.Drawing.Point(156, 450);
            web_PageLabel.Name = "web_PageLabel";
            web_PageLabel.Size = new System.Drawing.Size(61, 13);
            web_PageLabel.TabIndex = 31;
            web_PageLabel.Text = "Web Page:";
            // 
            // web_PageTextBox
            // 
            this.web_PageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Web Page", true));
            this.web_PageTextBox.Location = new System.Drawing.Point(251, 447);
            this.web_PageTextBox.Name = "web_PageTextBox";
            this.web_PageTextBox.Size = new System.Drawing.Size(100, 20);
            this.web_PageTextBox.TabIndex = 32;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(156, 476);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 33;
            notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(251, 473);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(100, 20);
            this.notesTextBox.TabIndex = 34;
            // 
            // attachmentsLabel
            // 
            attachmentsLabel.AutoSize = true;
            attachmentsLabel.Location = new System.Drawing.Point(156, 502);
            attachmentsLabel.Name = "attachmentsLabel";
            attachmentsLabel.Size = new System.Drawing.Size(69, 13);
            attachmentsLabel.TabIndex = 35;
            attachmentsLabel.Text = "Attachments:";
            // 
            // attachmentsTextBox
            // 
            this.attachmentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Attachments", true));
            this.attachmentsTextBox.Location = new System.Drawing.Point(251, 499);
            this.attachmentsTextBox.Name = "attachmentsTextBox";
            this.attachmentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.attachmentsTextBox.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 611);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(e_mail_AddressLabel);
            this.Controls.Add(this.e_mail_AddressTextBox);
            this.Controls.Add(job_TitleLabel);
            this.Controls.Add(this.job_TitleTextBox);
            this.Controls.Add(business_PhoneLabel);
            this.Controls.Add(this.business_PhoneTextBox);
            this.Controls.Add(home_PhoneLabel);
            this.Controls.Add(this.home_PhoneTextBox);
            this.Controls.Add(mobile_PhoneLabel);
            this.Controls.Add(this.mobile_PhoneTextBox);
            this.Controls.Add(fax_NumberLabel);
            this.Controls.Add(this.fax_NumberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(state_ProvinceLabel);
            this.Controls.Add(this.state_ProvinceTextBox);
            this.Controls.Add(zIP_Postal_CodeLabel);
            this.Controls.Add(this.zIP_Postal_CodeTextBox);
            this.Controls.Add(country_RegionLabel);
            this.Controls.Add(this.country_RegionTextBox);
            this.Controls.Add(web_PageLabel);
            this.Controls.Add(this.web_PageTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(attachmentsLabel);
            this.Controls.Add(this.attachmentsTextBox);
            this.Controls.Add(this.customersBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox e_mail_AddressTextBox;
        private System.Windows.Forms.TextBox job_TitleTextBox;
        private System.Windows.Forms.TextBox business_PhoneTextBox;
        private System.Windows.Forms.TextBox home_PhoneTextBox;
        private System.Windows.Forms.TextBox mobile_PhoneTextBox;
        private System.Windows.Forms.TextBox fax_NumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox state_ProvinceTextBox;
        private System.Windows.Forms.TextBox zIP_Postal_CodeTextBox;
        private System.Windows.Forms.TextBox country_RegionTextBox;
        private System.Windows.Forms.TextBox web_PageTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox attachmentsTextBox;
    }
}

