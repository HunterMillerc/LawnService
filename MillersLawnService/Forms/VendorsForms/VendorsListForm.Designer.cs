namespace MillersLawnService.Forms.VendorsForms
{
    partial class VendorsListForm
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
            System.Windows.Forms.Label vendorAddressLabel;
            System.Windows.Forms.Label vendorCityLabel;
            System.Windows.Forms.Label vendorIDLabel;
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label vendorPhoneNumLabel;
            System.Windows.Forms.Label vendorStateLabel;
            System.Windows.Forms.Label vendorZipCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsListForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchByNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchByNameCbo = new System.Windows.Forms.ToolStripComboBox();
            this.btnSearchByName = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filterByStateLabel = new System.Windows.Forms.ToolStripLabel();
            this.filterByStateCbo = new System.Windows.Forms.ToolStripComboBox();
            this.btnFilterByState = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.searchByAllLabel = new System.Windows.Forms.ToolStripLabel();
            this.btnSearchByAll = new System.Windows.Forms.ToolStripButton();
            this.btnVendorsFormExit = new System.Windows.Forms.Button();
            this.btnVendorFormSaveChanges = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVendorsFormDeleteVend = new System.Windows.Forms.Button();
            this.btnVendorsFormEditVend = new System.Windows.Forms.Button();
            this.btnVendorsFormAddVend = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vendorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorAddressTextBox = new System.Windows.Forms.TextBox();
            this.vendorCityTextBox = new System.Windows.Forms.TextBox();
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.vendorPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.vendorStateComboBox = new System.Windows.Forms.ComboBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorZipCodeTextBox = new System.Windows.Forms.TextBox();
            vendorAddressLabel = new System.Windows.Forms.Label();
            vendorCityLabel = new System.Windows.Forms.Label();
            vendorIDLabel = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            vendorPhoneNumLabel = new System.Windows.Forms.Label();
            vendorStateLabel = new System.Windows.Forms.Label();
            vendorZipCodeLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorAddressLabel
            // 
            vendorAddressLabel.AutoSize = true;
            vendorAddressLabel.Location = new System.Drawing.Point(12, 291);
            vendorAddressLabel.Name = "vendorAddressLabel";
            vendorAddressLabel.Size = new System.Drawing.Size(114, 17);
            vendorAddressLabel.TabIndex = 98;
            vendorAddressLabel.Text = "Vendor Address:";
            // 
            // vendorCityLabel
            // 
            vendorCityLabel.AutoSize = true;
            vendorCityLabel.Location = new System.Drawing.Point(12, 324);
            vendorCityLabel.Name = "vendorCityLabel";
            vendorCityLabel.Size = new System.Drawing.Size(85, 17);
            vendorCityLabel.TabIndex = 100;
            vendorCityLabel.Text = "Vendor City:";
            // 
            // vendorIDLabel
            // 
            vendorIDLabel.AutoSize = true;
            vendorIDLabel.Location = new System.Drawing.Point(12, 189);
            vendorIDLabel.Name = "vendorIDLabel";
            vendorIDLabel.Size = new System.Drawing.Size(75, 17);
            vendorIDLabel.TabIndex = 102;
            vendorIDLabel.Text = "Vendor ID:";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Location = new System.Drawing.Point(12, 225);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(99, 17);
            vendorNameLabel.TabIndex = 104;
            vendorNameLabel.Text = "Vendor Name:";
            // 
            // vendorPhoneNumLabel
            // 
            vendorPhoneNumLabel.AutoSize = true;
            vendorPhoneNumLabel.Location = new System.Drawing.Point(12, 258);
            vendorPhoneNumLabel.Name = "vendorPhoneNumLabel";
            vendorPhoneNumLabel.Size = new System.Drawing.Size(157, 17);
            vendorPhoneNumLabel.TabIndex = 106;
            vendorPhoneNumLabel.Text = "Vendor Phone Number:";
            // 
            // vendorStateLabel
            // 
            vendorStateLabel.AutoSize = true;
            vendorStateLabel.Location = new System.Drawing.Point(12, 357);
            vendorStateLabel.Name = "vendorStateLabel";
            vendorStateLabel.Size = new System.Drawing.Size(95, 17);
            vendorStateLabel.TabIndex = 108;
            vendorStateLabel.Text = "Vendor State:";
            // 
            // vendorZipCodeLabel
            // 
            vendorZipCodeLabel.AutoSize = true;
            vendorZipCodeLabel.Location = new System.Drawing.Point(12, 391);
            vendorZipCodeLabel.Name = "vendorZipCodeLabel";
            vendorZipCodeLabel.Size = new System.Drawing.Size(119, 17);
            vendorZipCodeLabel.TabIndex = 110;
            vendorZipCodeLabel.Text = "Vendor Zip Code:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByNameLabel,
            this.searchByNameCbo,
            this.btnSearchByName,
            this.toolStripSeparator1,
            this.filterByStateLabel,
            this.filterByStateCbo,
            this.btnFilterByState,
            this.toolStripSeparator2,
            this.searchByAllLabel,
            this.btnSearchByAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1587, 28);
            this.toolStrip1.TabIndex = 87;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchByNameLabel
            // 
            this.searchByNameLabel.Name = "searchByNameLabel";
            this.searchByNameLabel.Size = new System.Drawing.Size(171, 25);
            this.searchByNameLabel.Text = "Search By Vendor Name:";
            // 
            // searchByNameCbo
            // 
            this.searchByNameCbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchByNameCbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchByNameCbo.Name = "searchByNameCbo";
            this.searchByNameCbo.Size = new System.Drawing.Size(121, 28);
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearchByName.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchByName.Image")));
            this.btnSearchByName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(24, 25);
            this.btnSearchByName.Text = "toolStripButton1";
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
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
            // btnVendorsFormExit
            // 
            this.btnVendorsFormExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorsFormExit.Location = new System.Drawing.Point(1347, 709);
            this.btnVendorsFormExit.Name = "btnVendorsFormExit";
            this.btnVendorsFormExit.Size = new System.Drawing.Size(220, 57);
            this.btnVendorsFormExit.TabIndex = 10;
            this.btnVendorsFormExit.Text = "Exit";
            this.btnVendorsFormExit.UseVisualStyleBackColor = true;
            this.btnVendorsFormExit.Click += new System.EventHandler(this.btnVendorsFormExit_Click);
            // 
            // btnVendorFormSaveChanges
            // 
            this.btnVendorFormSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorFormSaveChanges.Location = new System.Drawing.Point(77, 466);
            this.btnVendorFormSaveChanges.Name = "btnVendorFormSaveChanges";
            this.btnVendorFormSaveChanges.Size = new System.Drawing.Size(220, 57);
            this.btnVendorFormSaveChanges.TabIndex = 6;
            this.btnVendorFormSaveChanges.Text = "Save Changes";
            this.btnVendorFormSaveChanges.UseVisualStyleBackColor = true;
            this.btnVendorFormSaveChanges.Visible = false;
            this.btnVendorFormSaveChanges.Click += new System.EventHandler(this.btnVendorFormSaveChanges_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1452, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // btnVendorsFormDeleteVend
            // 
            this.btnVendorsFormDeleteVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorsFormDeleteVend.Location = new System.Drawing.Point(11, 709);
            this.btnVendorsFormDeleteVend.Name = "btnVendorsFormDeleteVend";
            this.btnVendorsFormDeleteVend.Size = new System.Drawing.Size(369, 57);
            this.btnVendorsFormDeleteVend.TabIndex = 9;
            this.btnVendorsFormDeleteVend.Text = "Delete Vendor";
            this.btnVendorsFormDeleteVend.UseVisualStyleBackColor = true;
            this.btnVendorsFormDeleteVend.Click += new System.EventHandler(this.btnVendorsFormDeleteVend_Click);
            // 
            // btnVendorsFormEditVend
            // 
            this.btnVendorsFormEditVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorsFormEditVend.Location = new System.Drawing.Point(11, 646);
            this.btnVendorsFormEditVend.Name = "btnVendorsFormEditVend";
            this.btnVendorsFormEditVend.Size = new System.Drawing.Size(369, 57);
            this.btnVendorsFormEditVend.TabIndex = 8;
            this.btnVendorsFormEditVend.Text = "Edit Vendor";
            this.btnVendorsFormEditVend.UseVisualStyleBackColor = true;
            this.btnVendorsFormEditVend.Click += new System.EventHandler(this.btnVendorsFormEditVend_Click);
            // 
            // btnVendorsFormAddVend
            // 
            this.btnVendorsFormAddVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendorsFormAddVend.Location = new System.Drawing.Point(11, 583);
            this.btnVendorsFormAddVend.Name = "btnVendorsFormAddVend";
            this.btnVendorsFormAddVend.Size = new System.Drawing.Size(369, 57);
            this.btnVendorsFormAddVend.TabIndex = 7;
            this.btnVendorsFormAddVend.Text = "Add Vendor";
            this.btnVendorsFormAddVend.UseVisualStyleBackColor = true;
            this.btnVendorsFormAddVend.Click += new System.EventHandler(this.btnVendorsFormAddVend_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.vendorBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1587, 27);
            this.bindingNavigator1.TabIndex = 84;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(MillersLawnService.Vendor);
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
            // vendorDataGridView
            // 
            this.vendorDataGridView.AllowUserToAddRows = false;
            this.vendorDataGridView.AllowUserToDeleteRows = false;
            this.vendorDataGridView.AllowUserToOrderColumns = true;
            this.vendorDataGridView.AutoGenerateColumns = false;
            this.vendorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.vendorDataGridView.DataSource = this.vendorBindingSource;
            this.vendorDataGridView.Location = new System.Drawing.Point(405, 189);
            this.vendorDataGridView.Name = "vendorDataGridView";
            this.vendorDataGridView.ReadOnly = true;
            this.vendorDataGridView.RowTemplate.Height = 24;
            this.vendorDataGridView.Size = new System.Drawing.Size(1162, 493);
            this.vendorDataGridView.TabIndex = 98;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VendorID";
            this.dataGridViewTextBoxColumn1.HeaderText = "VendorID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VendorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "VendorName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VendorPhoneNum";
            this.dataGridViewTextBoxColumn3.HeaderText = "VendorPhoneNum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VendorState";
            this.dataGridViewTextBoxColumn4.HeaderText = "VendorState";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VendorCity";
            this.dataGridViewTextBoxColumn5.HeaderText = "VendorCity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VendorAddress";
            this.dataGridViewTextBoxColumn6.HeaderText = "VendorAddress";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "VendorZipCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "VendorZipCode";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // vendorAddressTextBox
            // 
            this.vendorAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorAddress", true));
            this.vendorAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorAddressTextBox.Location = new System.Drawing.Point(175, 285);
            this.vendorAddressTextBox.MaxLength = 300;
            this.vendorAddressTextBox.Name = "vendorAddressTextBox";
            this.vendorAddressTextBox.ReadOnly = true;
            this.vendorAddressTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorAddressTextBox.TabIndex = 2;
            this.vendorAddressTextBox.TextChanged += new System.EventHandler(this.vendorAddressTextBox_TextChanged);
            // 
            // vendorCityTextBox
            // 
            this.vendorCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorCity", true));
            this.vendorCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorCityTextBox.Location = new System.Drawing.Point(175, 318);
            this.vendorCityTextBox.MaxLength = 100;
            this.vendorCityTextBox.Name = "vendorCityTextBox";
            this.vendorCityTextBox.ReadOnly = true;
            this.vendorCityTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorCityTextBox.TabIndex = 3;
            this.vendorCityTextBox.TextChanged += new System.EventHandler(this.vendorCityTextBox_TextChanged);
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorID", true));
            this.vendorIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorIDTextBox.Location = new System.Drawing.Point(175, 186);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.ReadOnly = true;
            this.vendorIDTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorIDTextBox.TabIndex = 103;
            this.vendorIDTextBox.TabStop = false;
            this.vendorIDTextBox.TextChanged += new System.EventHandler(this.vendorIDTextBox_TextChanged);
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorName", true));
            this.vendorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorNameTextBox.Location = new System.Drawing.Point(175, 219);
            this.vendorNameTextBox.MaxLength = 200;
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.ReadOnly = true;
            this.vendorNameTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorNameTextBox.TabIndex = 0;
            this.vendorNameTextBox.TextChanged += new System.EventHandler(this.vendorNameTextBox_TextChanged);
            // 
            // vendorPhoneNumTextBox
            // 
            this.vendorPhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorPhoneNum", true));
            this.vendorPhoneNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorPhoneNumTextBox.Location = new System.Drawing.Point(175, 252);
            this.vendorPhoneNumTextBox.MaxLength = 10;
            this.vendorPhoneNumTextBox.Name = "vendorPhoneNumTextBox";
            this.vendorPhoneNumTextBox.ReadOnly = true;
            this.vendorPhoneNumTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorPhoneNumTextBox.TabIndex = 1;
            this.vendorPhoneNumTextBox.TextChanged += new System.EventHandler(this.vendorPhoneNumTextBox_TextChanged);
            // 
            // vendorStateComboBox
            // 
            this.vendorStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorState", true));
            this.vendorStateComboBox.DataSource = this.stateBindingSource;
            this.vendorStateComboBox.DisplayMember = "StateCode";
            this.vendorStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendorStateComboBox.Enabled = false;
            this.vendorStateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorStateComboBox.FormattingEnabled = true;
            this.vendorStateComboBox.Location = new System.Drawing.Point(175, 351);
            this.vendorStateComboBox.Name = "vendorStateComboBox";
            this.vendorStateComboBox.Size = new System.Drawing.Size(216, 28);
            this.vendorStateComboBox.TabIndex = 4;
            this.vendorStateComboBox.ValueMember = "StateCode";
            this.vendorStateComboBox.SelectedIndexChanged += new System.EventHandler(this.vendorStateComboBox_SelectedIndexChanged);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(MillersLawnService.State);
            // 
            // vendorZipCodeTextBox
            // 
            this.vendorZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorZipCode", true));
            this.vendorZipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorZipCodeTextBox.Location = new System.Drawing.Point(175, 385);
            this.vendorZipCodeTextBox.MaxLength = 10;
            this.vendorZipCodeTextBox.Name = "vendorZipCodeTextBox";
            this.vendorZipCodeTextBox.ReadOnly = true;
            this.vendorZipCodeTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorZipCodeTextBox.TabIndex = 5;
            this.vendorZipCodeTextBox.TextChanged += new System.EventHandler(this.vendorZipCodeTextBox_TextChanged);
            // 
            // VendorsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 786);
            this.Controls.Add(vendorAddressLabel);
            this.Controls.Add(this.vendorAddressTextBox);
            this.Controls.Add(vendorCityLabel);
            this.Controls.Add(this.vendorCityTextBox);
            this.Controls.Add(vendorIDLabel);
            this.Controls.Add(this.vendorIDTextBox);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(vendorPhoneNumLabel);
            this.Controls.Add(this.vendorPhoneNumTextBox);
            this.Controls.Add(vendorStateLabel);
            this.Controls.Add(this.vendorStateComboBox);
            this.Controls.Add(vendorZipCodeLabel);
            this.Controls.Add(this.vendorZipCodeTextBox);
            this.Controls.Add(this.vendorDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnVendorsFormExit);
            this.Controls.Add(this.btnVendorFormSaveChanges);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVendorsFormDeleteVend);
            this.Controls.Add(this.btnVendorsFormEditVend);
            this.Controls.Add(this.btnVendorsFormAddVend);
            this.Controls.Add(this.bindingNavigator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VendorsListForm";
            this.Text = "Vendors";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel searchByNameLabel;
        private System.Windows.Forms.ToolStripComboBox searchByNameCbo;
        private System.Windows.Forms.ToolStripButton btnSearchByName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel filterByStateLabel;
        private System.Windows.Forms.ToolStripComboBox filterByStateCbo;
        private System.Windows.Forms.ToolStripButton btnFilterByState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel searchByAllLabel;
        private System.Windows.Forms.ToolStripButton btnSearchByAll;
        private System.Windows.Forms.Button btnVendorsFormExit;
        private System.Windows.Forms.Button btnVendorFormSaveChanges;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVendorsFormDeleteVend;
        private System.Windows.Forms.Button btnVendorsFormEditVend;
        private System.Windows.Forms.Button btnVendorsFormAddVend;
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
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.DataGridView vendorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox vendorAddressTextBox;
        private System.Windows.Forms.TextBox vendorCityTextBox;
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox vendorPhoneNumTextBox;
        private System.Windows.Forms.ComboBox vendorStateComboBox;
        private System.Windows.Forms.TextBox vendorZipCodeTextBox;
        private System.Windows.Forms.BindingSource stateBindingSource;
    }
}