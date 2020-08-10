namespace MillersLawnService.Forms.CustomersForms
{
    partial class CustomersListForm
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
            System.Windows.Forms.Label customerAddressLabel;
            System.Windows.Forms.Label customerCityLabel;
            System.Windows.Forms.Label customerFNameLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label customerLNameLabel;
            System.Windows.Forms.Label customerPhoneNumLabel;
            System.Windows.Forms.Label customerStateLabel;
            System.Windows.Forms.Label customerZipCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersListForm));
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerZipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerCityTextBox = new System.Windows.Forms.TextBox();
            this.customerFNameTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.customerLNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.customerZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.btnCustomerFormAddCust = new System.Windows.Forms.Button();
            this.btnCustomerFormEditCust = new System.Windows.Forms.Button();
            this.btnCustomerFormDeleteCust = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomerFormSaveChanges = new System.Windows.Forms.Button();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerStateComboBox = new System.Windows.Forms.ComboBox();
            this.btnCustomerFormExit = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchByLastNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchByLastNameCbo = new System.Windows.Forms.ToolStripComboBox();
            this.btnSearchByLastName = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filterByStateLabel = new System.Windows.Forms.ToolStripLabel();
            this.filterByStateCbo = new System.Windows.Forms.ToolStripComboBox();
            this.btnFilterByState = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.searchByAllLabel = new System.Windows.Forms.ToolStripLabel();
            this.btnSearchByAll = new System.Windows.Forms.ToolStripButton();
            customerAddressLabel = new System.Windows.Forms.Label();
            customerCityLabel = new System.Windows.Forms.Label();
            customerFNameLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            customerLNameLabel = new System.Windows.Forms.Label();
            customerPhoneNumLabel = new System.Windows.Forms.Label();
            customerStateLabel = new System.Windows.Forms.Label();
            customerZipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerAddressLabel.Location = new System.Drawing.Point(8, 313);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new System.Drawing.Size(128, 17);
            customerAddressLabel.TabIndex = 2;
            customerAddressLabel.Text = "Customer Address:";
            // 
            // customerCityLabel
            // 
            customerCityLabel.AutoSize = true;
            customerCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerCityLabel.Location = new System.Drawing.Point(8, 346);
            customerCityLabel.Name = "customerCityLabel";
            customerCityLabel.Size = new System.Drawing.Size(99, 17);
            customerCityLabel.TabIndex = 4;
            customerCityLabel.Text = "Customer City:";
            // 
            // customerFNameLabel
            // 
            customerFNameLabel.AutoSize = true;
            customerFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerFNameLabel.Location = new System.Drawing.Point(8, 214);
            customerFNameLabel.Name = "customerFNameLabel";
            customerFNameLabel.Size = new System.Drawing.Size(144, 17);
            customerFNameLabel.TabIndex = 6;
            customerFNameLabel.Text = "Customer First Name:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIDLabel.Location = new System.Drawing.Point(8, 181);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(89, 17);
            customerIDLabel.TabIndex = 8;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerLNameLabel
            // 
            customerLNameLabel.AutoSize = true;
            customerLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerLNameLabel.Location = new System.Drawing.Point(8, 247);
            customerLNameLabel.Name = "customerLNameLabel";
            customerLNameLabel.Size = new System.Drawing.Size(144, 17);
            customerLNameLabel.TabIndex = 10;
            customerLNameLabel.Text = "Customer Last Name:";
            // 
            // customerPhoneNumLabel
            // 
            customerPhoneNumLabel.AutoSize = true;
            customerPhoneNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerPhoneNumLabel.Location = new System.Drawing.Point(8, 280);
            customerPhoneNumLabel.Name = "customerPhoneNumLabel";
            customerPhoneNumLabel.Size = new System.Drawing.Size(171, 17);
            customerPhoneNumLabel.TabIndex = 12;
            customerPhoneNumLabel.Text = "Customer Phone Number:";
            // 
            // customerStateLabel
            // 
            customerStateLabel.AutoSize = true;
            customerStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerStateLabel.Location = new System.Drawing.Point(8, 379);
            customerStateLabel.Name = "customerStateLabel";
            customerStateLabel.Size = new System.Drawing.Size(109, 17);
            customerStateLabel.TabIndex = 14;
            customerStateLabel.Text = "Customer State:";
            // 
            // customerZipCodeLabel
            // 
            customerZipCodeLabel.AutoSize = true;
            customerZipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerZipCodeLabel.Location = new System.Drawing.Point(8, 412);
            customerZipCodeLabel.Name = "customerZipCodeLabel";
            customerZipCodeLabel.Size = new System.Drawing.Size(133, 17);
            customerZipCodeLabel.TabIndex = 16;
            customerZipCodeLabel.Text = "Customer Zip Code:";
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToOrderColumns = true;
            this.dataGridViewCustomers.AutoGenerateColumns = false;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerFNameDataGridViewTextBoxColumn,
            this.customerLNameDataGridViewTextBoxColumn,
            this.customerPhoneNumDataGridViewTextBoxColumn,
            this.customerStateDataGridViewTextBoxColumn,
            this.customerCityDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerZipCodeDataGridViewTextBoxColumn});
            this.dataGridViewCustomers.DataSource = this.customerBindingSource;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(423, 175);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1116, 493);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerFNameDataGridViewTextBoxColumn
            // 
            this.customerFNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFName";
            this.customerFNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.customerFNameDataGridViewTextBoxColumn.Name = "customerFNameDataGridViewTextBoxColumn";
            this.customerFNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerLNameDataGridViewTextBoxColumn
            // 
            this.customerLNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLName";
            this.customerLNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.customerLNameDataGridViewTextBoxColumn.Name = "customerLNameDataGridViewTextBoxColumn";
            this.customerLNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPhoneNumDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhoneNum";
            this.customerPhoneNumDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.customerPhoneNumDataGridViewTextBoxColumn.Name = "customerPhoneNumDataGridViewTextBoxColumn";
            this.customerPhoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerStateDataGridViewTextBoxColumn
            // 
            this.customerStateDataGridViewTextBoxColumn.DataPropertyName = "CustomerState";
            this.customerStateDataGridViewTextBoxColumn.HeaderText = "State";
            this.customerStateDataGridViewTextBoxColumn.Name = "customerStateDataGridViewTextBoxColumn";
            this.customerStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerCityDataGridViewTextBoxColumn
            // 
            this.customerCityDataGridViewTextBoxColumn.DataPropertyName = "CustomerCity";
            this.customerCityDataGridViewTextBoxColumn.HeaderText = "City";
            this.customerCityDataGridViewTextBoxColumn.Name = "customerCityDataGridViewTextBoxColumn";
            this.customerCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerZipCodeDataGridViewTextBoxColumn
            // 
            this.customerZipCodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerZipCode";
            this.customerZipCodeDataGridViewTextBoxColumn.HeaderText = "Zip Code";
            this.customerZipCodeDataGridViewTextBoxColumn.Name = "customerZipCodeDataGridViewTextBoxColumn";
            this.customerZipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MillersLawnService.Customer);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.customerBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1551, 27);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerAddress", true));
            this.customerAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressTextBox.Location = new System.Drawing.Point(185, 307);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.ReadOnly = true;
            this.customerAddressTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerAddressTextBox.TabIndex = 3;
            this.customerAddressTextBox.TextChanged += new System.EventHandler(this.customerAddressTextBox_TextChanged);
            // 
            // customerCityTextBox
            // 
            this.customerCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerCity", true));
            this.customerCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCityTextBox.Location = new System.Drawing.Point(185, 340);
            this.customerCityTextBox.Name = "customerCityTextBox";
            this.customerCityTextBox.ReadOnly = true;
            this.customerCityTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerCityTextBox.TabIndex = 4;
            this.customerCityTextBox.TextChanged += new System.EventHandler(this.customerCityTextBox_TextChanged);
            // 
            // customerFNameTextBox
            // 
            this.customerFNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerFName", true));
            this.customerFNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFNameTextBox.Location = new System.Drawing.Point(185, 208);
            this.customerFNameTextBox.Name = "customerFNameTextBox";
            this.customerFNameTextBox.ReadOnly = true;
            this.customerFNameTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerFNameTextBox.TabIndex = 0;
            this.customerFNameTextBox.TextChanged += new System.EventHandler(this.customerFNameTextBox_TextChanged);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerID", true));
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(185, 175);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerIDTextBox.TabIndex = 20;
            this.customerIDTextBox.TabStop = false;
            // 
            // customerLNameTextBox
            // 
            this.customerLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerLName", true));
            this.customerLNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLNameTextBox.Location = new System.Drawing.Point(185, 241);
            this.customerLNameTextBox.Name = "customerLNameTextBox";
            this.customerLNameTextBox.ReadOnly = true;
            this.customerLNameTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerLNameTextBox.TabIndex = 1;
            this.customerLNameTextBox.TextChanged += new System.EventHandler(this.customerLNameTextBox_TextChanged);
            // 
            // customerPhoneNumTextBox
            // 
            this.customerPhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerPhoneNum", true));
            this.customerPhoneNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneNumTextBox.Location = new System.Drawing.Point(185, 274);
            this.customerPhoneNumTextBox.MaxLength = 10;
            this.customerPhoneNumTextBox.Name = "customerPhoneNumTextBox";
            this.customerPhoneNumTextBox.ReadOnly = true;
            this.customerPhoneNumTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerPhoneNumTextBox.TabIndex = 2;
            this.customerPhoneNumTextBox.TextChanged += new System.EventHandler(this.customerPhoneNumTextBox_TextChanged);
            // 
            // customerZipCodeTextBox
            // 
            this.customerZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerZipCode", true));
            this.customerZipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerZipCodeTextBox.Location = new System.Drawing.Point(185, 406);
            this.customerZipCodeTextBox.MaxLength = 10;
            this.customerZipCodeTextBox.Name = "customerZipCodeTextBox";
            this.customerZipCodeTextBox.ReadOnly = true;
            this.customerZipCodeTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerZipCodeTextBox.TabIndex = 6;
            this.customerZipCodeTextBox.TextChanged += new System.EventHandler(this.customerZipCodeTextBox_TextChanged);
            // 
            // btnCustomerFormAddCust
            // 
            this.btnCustomerFormAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerFormAddCust.Location = new System.Drawing.Point(11, 563);
            this.btnCustomerFormAddCust.Name = "btnCustomerFormAddCust";
            this.btnCustomerFormAddCust.Size = new System.Drawing.Size(369, 57);
            this.btnCustomerFormAddCust.TabIndex = 8;
            this.btnCustomerFormAddCust.Text = "Add Customer";
            this.btnCustomerFormAddCust.UseVisualStyleBackColor = true;
            this.btnCustomerFormAddCust.Click += new System.EventHandler(this.btnCustomerFormAddCust_Click);
            // 
            // btnCustomerFormEditCust
            // 
            this.btnCustomerFormEditCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerFormEditCust.Location = new System.Drawing.Point(11, 626);
            this.btnCustomerFormEditCust.Name = "btnCustomerFormEditCust";
            this.btnCustomerFormEditCust.Size = new System.Drawing.Size(369, 57);
            this.btnCustomerFormEditCust.TabIndex = 9;
            this.btnCustomerFormEditCust.Text = "Edit Customer";
            this.btnCustomerFormEditCust.UseVisualStyleBackColor = true;
            this.btnCustomerFormEditCust.Click += new System.EventHandler(this.btnCustomerFormEditCust_Click);
            // 
            // btnCustomerFormDeleteCust
            // 
            this.btnCustomerFormDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerFormDeleteCust.Location = new System.Drawing.Point(11, 689);
            this.btnCustomerFormDeleteCust.Name = "btnCustomerFormDeleteCust";
            this.btnCustomerFormDeleteCust.Size = new System.Drawing.Size(369, 57);
            this.btnCustomerFormDeleteCust.TabIndex = 10;
            this.btnCustomerFormDeleteCust.Text = "Delete Customer";
            this.btnCustomerFormDeleteCust.UseVisualStyleBackColor = true;
            this.btnCustomerFormDeleteCust.Click += new System.EventHandler(this.btnCustomerFormDeleteCust_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1416, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnCustomerFormSaveChanges
            // 
            this.btnCustomerFormSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerFormSaveChanges.Location = new System.Drawing.Point(86, 455);
            this.btnCustomerFormSaveChanges.Name = "btnCustomerFormSaveChanges";
            this.btnCustomerFormSaveChanges.Size = new System.Drawing.Size(220, 57);
            this.btnCustomerFormSaveChanges.TabIndex = 7;
            this.btnCustomerFormSaveChanges.Text = "Save Changes";
            this.btnCustomerFormSaveChanges.UseVisualStyleBackColor = true;
            this.btnCustomerFormSaveChanges.Click += new System.EventHandler(this.btnCustomerFormSaveChanges_Click);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(MillersLawnService.State);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(MillersLawnService.Customer);
            // 
            // customerStateComboBox
            // 
            this.customerStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerState", true));
            this.customerStateComboBox.DataSource = this.stateBindingSource;
            this.customerStateComboBox.DisplayMember = "StateCode";
            this.customerStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerStateComboBox.Enabled = false;
            this.customerStateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStateComboBox.FormattingEnabled = true;
            this.customerStateComboBox.Location = new System.Drawing.Point(185, 373);
            this.customerStateComboBox.Name = "customerStateComboBox";
            this.customerStateComboBox.Size = new System.Drawing.Size(216, 28);
            this.customerStateComboBox.TabIndex = 5;
            this.customerStateComboBox.ValueMember = "StateCode";
            // 
            // btnCustomerFormExit
            // 
            this.btnCustomerFormExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerFormExit.Location = new System.Drawing.Point(1319, 689);
            this.btnCustomerFormExit.Name = "btnCustomerFormExit";
            this.btnCustomerFormExit.Size = new System.Drawing.Size(220, 57);
            this.btnCustomerFormExit.TabIndex = 11;
            this.btnCustomerFormExit.Text = "Exit";
            this.btnCustomerFormExit.UseVisualStyleBackColor = true;
            this.btnCustomerFormExit.Click += new System.EventHandler(this.btnCustomerFormExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByLastNameLabel,
            this.searchByLastNameCbo,
            this.btnSearchByLastName,
            this.toolStripSeparator1,
            this.filterByStateLabel,
            this.filterByStateCbo,
            this.btnFilterByState,
            this.toolStripSeparator2,
            this.searchByAllLabel,
            this.btnSearchByAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1551, 28);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchByLastNameLabel
            // 
            this.searchByLastNameLabel.Name = "searchByLastNameLabel";
            this.searchByLastNameLabel.Size = new System.Drawing.Size(150, 25);
            this.searchByLastNameLabel.Text = "Search By Last Name:";
            // 
            // searchByLastNameCbo
            // 
            this.searchByLastNameCbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchByLastNameCbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchByLastNameCbo.Name = "searchByLastNameCbo";
            this.searchByLastNameCbo.Size = new System.Drawing.Size(121, 28);
            // 
            // btnSearchByLastName
            // 
            this.btnSearchByLastName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearchByLastName.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchByLastName.Image")));
            this.btnSearchByLastName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchByLastName.Name = "btnSearchByLastName";
            this.btnSearchByLastName.Size = new System.Drawing.Size(24, 25);
            this.btnSearchByLastName.Text = "toolStripButton1";
            this.btnSearchByLastName.Click += new System.EventHandler(this.btnSearchByLastName_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // filterByStateLabel
            // 
            this.filterByStateLabel.Name = "filterByStateLabel";
            this.filterByStateLabel.Size = new System.Drawing.Size(107, 25);
            this.filterByStateLabel.Text = "Filter By State: ";
            // 
            // filterByStateCbo
            // 
            this.filterByStateCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterByStateCbo.Name = "filterByStateCbo";
            this.filterByStateCbo.Size = new System.Drawing.Size(121, 28);
            // 
            // btnFilterByState
            // 
            this.btnFilterByState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilterByState.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterByState.Image")));
            this.btnFilterByState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterByState.Name = "btnFilterByState";
            this.btnFilterByState.Size = new System.Drawing.Size(24, 25);
            this.btnFilterByState.Text = "toolStripButton1";
            this.btnFilterByState.Click += new System.EventHandler(this.btnFilterByState_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // searchByAllLabel
            // 
            this.searchByAllLabel.Name = "searchByAllLabel";
            this.searchByAllLabel.Size = new System.Drawing.Size(140, 25);
            this.searchByAllLabel.Text = "Display All Records:";
            // 
            // btnSearchByAll
            // 
            this.btnSearchByAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearchByAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchByAll.Image")));
            this.btnSearchByAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchByAll.Name = "btnSearchByAll";
            this.btnSearchByAll.Size = new System.Drawing.Size(24, 25);
            this.btnSearchByAll.Text = "toolStripButton1";
            this.btnSearchByAll.Click += new System.EventHandler(this.btnSearchByAll_Click);
            // 
            // CustomersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 766);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCustomerFormExit);
            this.Controls.Add(this.customerStateComboBox);
            this.Controls.Add(this.btnCustomerFormSaveChanges);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCustomerFormDeleteCust);
            this.Controls.Add(this.btnCustomerFormEditCust);
            this.Controls.Add(this.btnCustomerFormAddCust);
            this.Controls.Add(customerAddressLabel);
            this.Controls.Add(this.customerAddressTextBox);
            this.Controls.Add(customerCityLabel);
            this.Controls.Add(this.customerCityTextBox);
            this.Controls.Add(customerFNameLabel);
            this.Controls.Add(this.customerFNameTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(customerLNameLabel);
            this.Controls.Add(this.customerLNameTextBox);
            this.Controls.Add(customerPhoneNumLabel);
            this.Controls.Add(this.customerPhoneNumTextBox);
            this.Controls.Add(customerStateLabel);
            this.Controls.Add(customerZipCodeLabel);
            this.Controls.Add(this.customerZipCodeTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomersListForm";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.TextBox customerCityTextBox;
        private System.Windows.Forms.TextBox customerFNameTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox customerLNameTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumTextBox;
        private System.Windows.Forms.TextBox customerZipCodeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerZipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCustomerFormAddCust;
        private System.Windows.Forms.Button btnCustomerFormEditCust;
        private System.Windows.Forms.Button btnCustomerFormDeleteCust;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCustomerFormSaveChanges;
        private System.Windows.Forms.ComboBox customerStateComboBox;
        private System.Windows.Forms.Button btnCustomerFormExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel searchByLastNameLabel;
        private System.Windows.Forms.ToolStripComboBox searchByLastNameCbo;
        private System.Windows.Forms.ToolStripButton btnSearchByLastName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel filterByStateLabel;
        private System.Windows.Forms.ToolStripComboBox filterByStateCbo;
        private System.Windows.Forms.ToolStripButton btnFilterByState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel searchByAllLabel;
        private System.Windows.Forms.ToolStripButton btnSearchByAll;
    }
}