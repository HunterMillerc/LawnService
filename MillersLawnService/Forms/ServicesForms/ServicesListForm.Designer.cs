namespace MillersLawnService.Forms.ServicesForms
{
    partial class ServicesListForm
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
            System.Windows.Forms.Label serviceCostPerHourLabel;
            System.Windows.Forms.Label serviceDescriptionLabel;
            System.Windows.Forms.Label serviceIDLabel;
            System.Windows.Forms.Label serviceNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.searchByNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchByServiceNameCbo = new System.Windows.Forms.ToolStripComboBox();
            this.btnSearchByServiceName = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filterByCostLabel = new System.Windows.Forms.ToolStripLabel();
            this.filterByCostMoneySign = new System.Windows.Forms.ToolStripLabel();
            this.filterByCostCbo = new System.Windows.Forms.ToolStripComboBox();
            this.btnFilterByCost = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.searchByAllLabel = new System.Windows.Forms.ToolStripLabel();
            this.btnSearchByAll = new System.Windows.Forms.ToolStripButton();
            this.btnServicesFormExit = new System.Windows.Forms.Button();
            this.btnServicesFormSaveChanges = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnServicesFormDeleteService = new System.Windows.Forms.Button();
            this.btnServicesFormEditService = new System.Windows.Forms.Button();
            this.btnServicesFormAddService = new System.Windows.Forms.Button();
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
            this.serviceDataGridView = new System.Windows.Forms.DataGridView();
            this.serviceCostPerHourTextBox = new System.Windows.Forms.TextBox();
            this.serviceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.serviceIDTextBox = new System.Windows.Forms.TextBox();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.labelMoneySignServiceCost = new System.Windows.Forms.Label();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceCostPerHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            serviceCostPerHourLabel = new System.Windows.Forms.Label();
            serviceDescriptionLabel = new System.Windows.Forms.Label();
            serviceIDLabel = new System.Windows.Forms.Label();
            serviceNameLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceCostPerHourLabel
            // 
            serviceCostPerHourLabel.AutoSize = true;
            serviceCostPerHourLabel.Location = new System.Drawing.Point(12, 465);
            serviceCostPerHourLabel.Name = "serviceCostPerHourLabel";
            serviceCostPerHourLabel.Size = new System.Drawing.Size(152, 17);
            serviceCostPerHourLabel.TabIndex = 51;
            serviceCostPerHourLabel.Text = "Service Cost Per Hour:";
            // 
            // serviceDescriptionLabel
            // 
            serviceDescriptionLabel.AutoSize = true;
            serviceDescriptionLabel.Location = new System.Drawing.Point(12, 251);
            serviceDescriptionLabel.Name = "serviceDescriptionLabel";
            serviceDescriptionLabel.Size = new System.Drawing.Size(134, 17);
            serviceDescriptionLabel.TabIndex = 53;
            serviceDescriptionLabel.Text = "Service Description:";
            // 
            // serviceIDLabel
            // 
            serviceIDLabel.AutoSize = true;
            serviceIDLabel.Location = new System.Drawing.Point(12, 185);
            serviceIDLabel.Name = "serviceIDLabel";
            serviceIDLabel.Size = new System.Drawing.Size(76, 17);
            serviceIDLabel.TabIndex = 55;
            serviceIDLabel.Text = "Service ID:";
            // 
            // serviceNameLabel
            // 
            serviceNameLabel.AutoSize = true;
            serviceNameLabel.Location = new System.Drawing.Point(12, 218);
            serviceNameLabel.Name = "serviceNameLabel";
            serviceNameLabel.Size = new System.Drawing.Size(100, 17);
            serviceNameLabel.TabIndex = 57;
            serviceNameLabel.Text = "Service Name:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByNameLabel,
            this.searchByServiceNameCbo,
            this.btnSearchByServiceName,
            this.toolStripSeparator1,
            this.filterByCostLabel,
            this.filterByCostMoneySign,
            this.filterByCostCbo,
            this.btnFilterByCost,
            this.toolStripSeparator2,
            this.searchByAllLabel,
            this.btnSearchByAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1559, 28);
            this.toolStrip1.TabIndex = 51;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // searchByNameLabel
            // 
            this.searchByNameLabel.Name = "searchByNameLabel";
            this.searchByNameLabel.Size = new System.Drawing.Size(171, 25);
            this.searchByNameLabel.Text = "Search By Service Name:";
            // 
            // searchByServiceNameCbo
            // 
            this.searchByServiceNameCbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchByServiceNameCbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchByServiceNameCbo.Name = "searchByServiceNameCbo";
            this.searchByServiceNameCbo.Size = new System.Drawing.Size(121, 28);
            // 
            // btnSearchByServiceName
            // 
            this.btnSearchByServiceName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearchByServiceName.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchByServiceName.Image")));
            this.btnSearchByServiceName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchByServiceName.Name = "btnSearchByServiceName";
            this.btnSearchByServiceName.Size = new System.Drawing.Size(24, 25);
            this.btnSearchByServiceName.Text = "toolStripButton1";
            this.btnSearchByServiceName.Click += new System.EventHandler(this.btnSearchByServiceName_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // filterByCostLabel
            // 
            this.filterByCostLabel.Name = "filterByCostLabel";
            this.filterByCostLabel.Size = new System.Drawing.Size(98, 25);
            this.filterByCostLabel.Text = "Filter By Cost:";
            // 
            // filterByCostMoneySign
            // 
            this.filterByCostMoneySign.Name = "filterByCostMoneySign";
            this.filterByCostMoneySign.Size = new System.Drawing.Size(17, 25);
            this.filterByCostMoneySign.Text = "$";
            // 
            // filterByCostCbo
            // 
            this.filterByCostCbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.filterByCostCbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.filterByCostCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterByCostCbo.Name = "filterByCostCbo";
            this.filterByCostCbo.Size = new System.Drawing.Size(121, 28);
            // 
            // btnFilterByCost
            // 
            this.btnFilterByCost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilterByCost.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterByCost.Image")));
            this.btnFilterByCost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterByCost.Name = "btnFilterByCost";
            this.btnFilterByCost.Size = new System.Drawing.Size(24, 25);
            this.btnFilterByCost.Text = "toolStripButton1";
            this.btnFilterByCost.Click += new System.EventHandler(this.btnFilterByCost_Click);
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
            // btnServicesFormExit
            // 
            this.btnServicesFormExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicesFormExit.Location = new System.Drawing.Point(1319, 699);
            this.btnServicesFormExit.Name = "btnServicesFormExit";
            this.btnServicesFormExit.Size = new System.Drawing.Size(220, 57);
            this.btnServicesFormExit.TabIndex = 7;
            this.btnServicesFormExit.Text = "Exit";
            this.btnServicesFormExit.UseVisualStyleBackColor = true;
            this.btnServicesFormExit.Click += new System.EventHandler(this.btnServicesFormExit_Click);
            // 
            // btnServicesFormSaveChanges
            // 
            this.btnServicesFormSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicesFormSaveChanges.Location = new System.Drawing.Point(86, 510);
            this.btnServicesFormSaveChanges.Name = "btnServicesFormSaveChanges";
            this.btnServicesFormSaveChanges.Size = new System.Drawing.Size(220, 57);
            this.btnServicesFormSaveChanges.TabIndex = 3;
            this.btnServicesFormSaveChanges.Text = "Save Changes";
            this.btnServicesFormSaveChanges.UseVisualStyleBackColor = true;
            this.btnServicesFormSaveChanges.Visible = false;
            this.btnServicesFormSaveChanges.Click += new System.EventHandler(this.btnServicesFormSaveChanges_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1424, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btnServicesFormDeleteService
            // 
            this.btnServicesFormDeleteService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicesFormDeleteService.Location = new System.Drawing.Point(11, 699);
            this.btnServicesFormDeleteService.Name = "btnServicesFormDeleteService";
            this.btnServicesFormDeleteService.Size = new System.Drawing.Size(369, 57);
            this.btnServicesFormDeleteService.TabIndex = 6;
            this.btnServicesFormDeleteService.Text = "Delete Service";
            this.btnServicesFormDeleteService.UseVisualStyleBackColor = true;
            this.btnServicesFormDeleteService.Click += new System.EventHandler(this.btnServicesFormDeleteService_Click);
            // 
            // btnServicesFormEditService
            // 
            this.btnServicesFormEditService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicesFormEditService.Location = new System.Drawing.Point(11, 636);
            this.btnServicesFormEditService.Name = "btnServicesFormEditService";
            this.btnServicesFormEditService.Size = new System.Drawing.Size(369, 57);
            this.btnServicesFormEditService.TabIndex = 5;
            this.btnServicesFormEditService.Text = "Edit Service";
            this.btnServicesFormEditService.UseVisualStyleBackColor = true;
            this.btnServicesFormEditService.Click += new System.EventHandler(this.btnServicesFormEditService_Click);
            // 
            // btnServicesFormAddService
            // 
            this.btnServicesFormAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicesFormAddService.Location = new System.Drawing.Point(11, 573);
            this.btnServicesFormAddService.Name = "btnServicesFormAddService";
            this.btnServicesFormAddService.Size = new System.Drawing.Size(369, 57);
            this.btnServicesFormAddService.TabIndex = 4;
            this.btnServicesFormAddService.Text = "Add Service";
            this.btnServicesFormAddService.UseVisualStyleBackColor = true;
            this.btnServicesFormAddService.Click += new System.EventHandler(this.btnServicesFormAddService_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.serviceBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1559, 27);
            this.bindingNavigator1.TabIndex = 31;
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
            // serviceDataGridView
            // 
            this.serviceDataGridView.AllowUserToAddRows = false;
            this.serviceDataGridView.AllowUserToDeleteRows = false;
            this.serviceDataGridView.AllowUserToOrderColumns = true;
            this.serviceDataGridView.AutoGenerateColumns = false;
            this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.serviceDescriptionDataGridViewTextBoxColumn,
            this.serviceCostPerHourDataGridViewTextBoxColumn});
            this.serviceDataGridView.DataSource = this.serviceBindingSource;
            this.serviceDataGridView.Location = new System.Drawing.Point(445, 179);
            this.serviceDataGridView.Name = "serviceDataGridView";
            this.serviceDataGridView.ReadOnly = true;
            this.serviceDataGridView.RowTemplate.Height = 24;
            this.serviceDataGridView.Size = new System.Drawing.Size(1094, 499);
            this.serviceDataGridView.TabIndex = 51;
            // 
            // serviceCostPerHourTextBox
            // 
            this.serviceCostPerHourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "ServiceCostPerHour", true));
            this.serviceCostPerHourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCostPerHourTextBox.Location = new System.Drawing.Point(186, 459);
            this.serviceCostPerHourTextBox.MaxLength = 7;
            this.serviceCostPerHourTextBox.Name = "serviceCostPerHourTextBox";
            this.serviceCostPerHourTextBox.ReadOnly = true;
            this.serviceCostPerHourTextBox.Size = new System.Drawing.Size(231, 27);
            this.serviceCostPerHourTextBox.TabIndex = 2;
            this.serviceCostPerHourTextBox.TextChanged += new System.EventHandler(this.serviceCostPerHourTextBox_TextChanged);
            // 
            // serviceDescriptionTextBox
            // 
            this.serviceDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "ServiceDescription", true));
            this.serviceDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceDescriptionTextBox.Location = new System.Drawing.Point(186, 245);
            this.serviceDescriptionTextBox.MaxLength = 300;
            this.serviceDescriptionTextBox.Multiline = true;
            this.serviceDescriptionTextBox.Name = "serviceDescriptionTextBox";
            this.serviceDescriptionTextBox.ReadOnly = true;
            this.serviceDescriptionTextBox.Size = new System.Drawing.Size(231, 208);
            this.serviceDescriptionTextBox.TabIndex = 1;
            this.serviceDescriptionTextBox.TextChanged += new System.EventHandler(this.serviceDescriptionTextBox_TextChanged);
            // 
            // serviceIDTextBox
            // 
            this.serviceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "ServiceID", true));
            this.serviceIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceIDTextBox.Location = new System.Drawing.Point(186, 179);
            this.serviceIDTextBox.Name = "serviceIDTextBox";
            this.serviceIDTextBox.ReadOnly = true;
            this.serviceIDTextBox.Size = new System.Drawing.Size(231, 27);
            this.serviceIDTextBox.TabIndex = 56;
            this.serviceIDTextBox.TabStop = false;
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "ServiceName", true));
            this.serviceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameTextBox.Location = new System.Drawing.Point(186, 212);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.ReadOnly = true;
            this.serviceNameTextBox.Size = new System.Drawing.Size(231, 27);
            this.serviceNameTextBox.TabIndex = 0;
            this.serviceNameTextBox.TextChanged += new System.EventHandler(this.serviceNameTextBox_TextChanged);
            // 
            // labelMoneySignServiceCost
            // 
            this.labelMoneySignServiceCost.AutoSize = true;
            this.labelMoneySignServiceCost.Location = new System.Drawing.Point(164, 465);
            this.labelMoneySignServiceCost.Name = "labelMoneySignServiceCost";
            this.labelMoneySignServiceCost.Size = new System.Drawing.Size(16, 17);
            this.labelMoneySignServiceCost.TabIndex = 59;
            this.labelMoneySignServiceCost.Text = "$";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(MillersLawnService.Service);
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "Service ID";
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceDescriptionDataGridViewTextBoxColumn
            // 
            this.serviceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.serviceDescriptionDataGridViewTextBoxColumn.Name = "serviceDescriptionDataGridViewTextBoxColumn";
            this.serviceDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceDescriptionDataGridViewTextBoxColumn.Width = 400;
            // 
            // serviceCostPerHourDataGridViewTextBoxColumn
            // 
            this.serviceCostPerHourDataGridViewTextBoxColumn.DataPropertyName = "ServiceCostPerHour";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.serviceCostPerHourDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.serviceCostPerHourDataGridViewTextBoxColumn.HeaderText = "Cost Per Hour";
            this.serviceCostPerHourDataGridViewTextBoxColumn.Name = "serviceCostPerHourDataGridViewTextBoxColumn";
            this.serviceCostPerHourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ServicesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 776);
            this.Controls.Add(this.labelMoneySignServiceCost);
            this.Controls.Add(serviceCostPerHourLabel);
            this.Controls.Add(this.serviceCostPerHourTextBox);
            this.Controls.Add(serviceDescriptionLabel);
            this.Controls.Add(this.serviceDescriptionTextBox);
            this.Controls.Add(serviceIDLabel);
            this.Controls.Add(this.serviceIDTextBox);
            this.Controls.Add(serviceNameLabel);
            this.Controls.Add(this.serviceNameTextBox);
            this.Controls.Add(this.serviceDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnServicesFormExit);
            this.Controls.Add(this.btnServicesFormSaveChanges);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnServicesFormDeleteService);
            this.Controls.Add(this.btnServicesFormEditService);
            this.Controls.Add(this.btnServicesFormAddService);
            this.Controls.Add(this.bindingNavigator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServicesListForm";
            this.Text = "Services";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel searchByNameLabel;
        private System.Windows.Forms.ToolStripComboBox searchByServiceNameCbo;
        private System.Windows.Forms.ToolStripButton btnSearchByServiceName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel filterByCostLabel;
        private System.Windows.Forms.ToolStripComboBox filterByCostCbo;
        private System.Windows.Forms.ToolStripButton btnFilterByCost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel searchByAllLabel;
        private System.Windows.Forms.ToolStripButton btnSearchByAll;
        private System.Windows.Forms.Button btnServicesFormExit;
        private System.Windows.Forms.Button btnServicesFormSaveChanges;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnServicesFormDeleteService;
        private System.Windows.Forms.Button btnServicesFormEditService;
        private System.Windows.Forms.Button btnServicesFormAddService;
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
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.DataGridView serviceDataGridView;
        private System.Windows.Forms.TextBox serviceCostPerHourTextBox;
        private System.Windows.Forms.TextBox serviceDescriptionTextBox;
        private System.Windows.Forms.TextBox serviceIDTextBox;
        private System.Windows.Forms.TextBox serviceNameTextBox;
        private System.Windows.Forms.Label labelMoneySignServiceCost;
        private System.Windows.Forms.ToolStripLabel filterByCostMoneySign;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceCostPerHourDataGridViewTextBoxColumn;
    }
}