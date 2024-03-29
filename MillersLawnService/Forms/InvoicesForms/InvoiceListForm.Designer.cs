﻿namespace MillersLawnService.Forms.InvoicesForms
{
    partial class InvoiceListForm
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
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label invoiceIDLabel1;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label customerLNameLabel1;
            System.Windows.Forms.Label customerFNameLabel;
            System.Windows.Forms.Label customerPhoneNumLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label serviceNumOfHoursLabel;
            System.Windows.Forms.Label invoiceIDLabel;
            System.Windows.Forms.Label employeeFNameLabel;
            System.Windows.Forms.Label employeeLNameLabel;
            System.Windows.Forms.Label serviceIDLabel;
            System.Windows.Forms.Label serviceNameLabel;
            System.Windows.Forms.Label serviceCostPerHourLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.selectedInvoiceIDTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.invoiceLineItemDataGridView = new System.Windows.Forms.DataGridView();
            this.InvLineItemDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceLineItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblInvoiceLineItemsTitle = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cboCustNameFilter = new System.Windows.Forms.ToolStripComboBox();
            this.btnFilterByCustName = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnShowAllInvoices = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInvoiceBtns = new System.Windows.Forms.GroupBox();
            this.customerPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.customerFNameTextBox = new System.Windows.Forms.TextBox();
            this.customerLNameTextBox1 = new System.Windows.Forms.TextBox();
            this.customerIDComboBox = new System.Windows.Forms.ComboBox();
            this.invoiceIDTextBox = new System.Windows.Forms.TextBox();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnInvoiceEdit = new System.Windows.Forms.Button();
            this.btnInvoiceAdd = new System.Windows.Forms.Button();
            this.groupBoxInvoiceLineItemBtns = new System.Windows.Forms.GroupBox();
            this.btnAddInvLineItemSave = new System.Windows.Forms.Button();
            this.empLastNameTextBox = new System.Windows.Forms.TextBox();
            this.empFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.serviceCostTextBox = new System.Windows.Forms.TextBox();
            this.servNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btnInvLineItemCancel = new System.Windows.Forms.Button();
            this.btnInvLineItemSave = new System.Windows.Forms.Button();
            this.serviceIDComboBox = new System.Windows.Forms.ComboBox();
            this.invoiceIDTextBox1 = new System.Windows.Forms.TextBox();
            this.lblServiceCostMoneySign = new System.Windows.Forms.Label();
            this.serviceNumOfHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteInvLineItem = new System.Windows.Forms.Button();
            this.btnEditInvLineItem = new System.Windows.Forms.Button();
            this.btnAddInvLineItem = new System.Windows.Forms.Button();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInvoicesExit = new System.Windows.Forms.Button();
            invoiceDateLabel = new System.Windows.Forms.Label();
            invoiceIDLabel1 = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            customerLNameLabel1 = new System.Windows.Forms.Label();
            customerFNameLabel = new System.Windows.Forms.Label();
            customerPhoneNumLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            serviceNumOfHoursLabel = new System.Windows.Forms.Label();
            invoiceIDLabel = new System.Windows.Forms.Label();
            employeeFNameLabel = new System.Windows.Forms.Label();
            employeeLNameLabel = new System.Windows.Forms.Label();
            serviceIDLabel = new System.Windows.Forms.Label();
            serviceNameLabel = new System.Windows.Forms.Label();
            serviceCostPerHourLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInvoiceBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.groupBoxInvoiceLineItemBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceNumOfHoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(102, 77);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(107, 20);
            invoiceDateLabel.TabIndex = 12;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // invoiceIDLabel1
            // 
            invoiceIDLabel1.AutoSize = true;
            invoiceIDLabel1.Location = new System.Drawing.Point(121, 38);
            invoiceIDLabel1.Name = "invoiceIDLabel1";
            invoiceIDLabel1.Size = new System.Drawing.Size(88, 20);
            invoiceIDLabel1.TabIndex = 13;
            invoiceIDLabel1.Text = "Invoice ID:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(100, 108);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(109, 20);
            customerIDLabel.TabIndex = 18;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerLNameLabel1
            // 
            customerLNameLabel1.AutoSize = true;
            customerLNameLabel1.Location = new System.Drawing.Point(35, 176);
            customerLNameLabel1.Name = "customerLNameLabel1";
            customerLNameLabel1.Size = new System.Drawing.Size(174, 20);
            customerLNameLabel1.TabIndex = 20;
            customerLNameLabel1.Text = "Customer Last Name:";
            // 
            // customerFNameLabel
            // 
            customerFNameLabel.AutoSize = true;
            customerFNameLabel.Location = new System.Drawing.Point(34, 144);
            customerFNameLabel.Name = "customerFNameLabel";
            customerFNameLabel.Size = new System.Drawing.Size(175, 20);
            customerFNameLabel.TabIndex = 21;
            customerFNameLabel.Text = "Customer First Name:";
            // 
            // customerPhoneNumLabel
            // 
            customerPhoneNumLabel.AutoSize = true;
            customerPhoneNumLabel.Location = new System.Drawing.Point(6, 209);
            customerPhoneNumLabel.Name = "customerPhoneNumLabel";
            customerPhoneNumLabel.Size = new System.Drawing.Size(203, 20);
            customerPhoneNumLabel.TabIndex = 23;
            customerPhoneNumLabel.Text = "Customer Phone Number:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(437, 41);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(109, 20);
            employeeIDLabel.TabIndex = 16;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // serviceNumOfHoursLabel
            // 
            serviceNumOfHoursLabel.AutoSize = true;
            serviceNumOfHoursLabel.Location = new System.Drawing.Point(6, 76);
            serviceNumOfHoursLabel.Name = "serviceNumOfHoursLabel";
            serviceNumOfHoursLabel.Size = new System.Drawing.Size(208, 20);
            serviceNumOfHoursLabel.TabIndex = 21;
            serviceNumOfHoursLabel.Text = "Service Number Of Hours:";
            // 
            // invoiceIDLabel
            // 
            invoiceIDLabel.AutoSize = true;
            invoiceIDLabel.Location = new System.Drawing.Point(6, 41);
            invoiceIDLabel.Name = "invoiceIDLabel";
            invoiceIDLabel.Size = new System.Drawing.Size(88, 20);
            invoiceIDLabel.TabIndex = 23;
            invoiceIDLabel.Text = "Invoice ID:";
            // 
            // employeeFNameLabel
            // 
            employeeFNameLabel.AutoSize = true;
            employeeFNameLabel.Location = new System.Drawing.Point(6, 186);
            employeeFNameLabel.Name = "employeeFNameLabel";
            employeeFNameLabel.Size = new System.Drawing.Size(175, 20);
            employeeFNameLabel.TabIndex = 24;
            employeeFNameLabel.Text = "Employee First Name:";
            // 
            // employeeLNameLabel
            // 
            employeeLNameLabel.AutoSize = true;
            employeeLNameLabel.Location = new System.Drawing.Point(6, 227);
            employeeLNameLabel.Name = "employeeLNameLabel";
            employeeLNameLabel.Size = new System.Drawing.Size(174, 20);
            employeeLNameLabel.TabIndex = 25;
            employeeLNameLabel.Text = "Employee Last Name:";
            // 
            // serviceIDLabel
            // 
            serviceIDLabel.AutoSize = true;
            serviceIDLabel.Location = new System.Drawing.Point(212, 40);
            serviceIDLabel.Name = "serviceIDLabel";
            serviceIDLabel.Size = new System.Drawing.Size(92, 20);
            serviceIDLabel.TabIndex = 26;
            serviceIDLabel.Text = "Service ID:";
            // 
            // serviceNameLabel
            // 
            serviceNameLabel.AutoSize = true;
            serviceNameLabel.Location = new System.Drawing.Point(6, 110);
            serviceNameLabel.Name = "serviceNameLabel";
            serviceNameLabel.Size = new System.Drawing.Size(119, 20);
            serviceNameLabel.TabIndex = 27;
            serviceNameLabel.Text = "Service Name:";
            // 
            // serviceCostPerHourLabel
            // 
            serviceCostPerHourLabel.AutoSize = true;
            serviceCostPerHourLabel.Location = new System.Drawing.Point(6, 145);
            serviceCostPerHourLabel.Name = "serviceCostPerHourLabel";
            serviceCostPerHourLabel.Size = new System.Drawing.Size(183, 20);
            serviceCostPerHourLabel.TabIndex = 28;
            serviceCostPerHourLabel.Text = "Service Cost Per Hour:";
            // 
            // invoiceBindingNavigator
            // 
            this.invoiceBindingNavigator.AddNewItem = null;
            this.invoiceBindingNavigator.BindingSource = this.invoiceBindingSource;
            this.invoiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoiceBindingNavigator.DeleteItem = null;
            this.invoiceBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.invoiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.selectedInvoiceIDTextBox,
            this.toolStripSeparator4,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(1844, 27);
            this.invoiceBindingNavigator.TabIndex = 0;
            this.invoiceBindingNavigator.Text = "bindingNavigator1";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(MillersLawnService.Invoice);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(139, 24);
            this.toolStripLabel2.Text = "Invoice ID Selected:";
            // 
            // selectedInvoiceIDTextBox
            // 
            this.selectedInvoiceIDTextBox.Name = "selectedInvoiceIDTextBox";
            this.selectedInvoiceIDTextBox.ReadOnly = true;
            this.selectedInvoiceIDTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
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
            // invoiceLineItemDataGridView
            // 
            this.invoiceLineItemDataGridView.AllowUserToAddRows = false;
            this.invoiceLineItemDataGridView.AllowUserToDeleteRows = false;
            this.invoiceLineItemDataGridView.AutoGenerateColumns = false;
            this.invoiceLineItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceLineItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvLineItemDetailID,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.EmployeeFirstName,
            this.EmployeeLastName,
            this.dataGridViewTextBoxColumn9,
            this.Cost});
            this.invoiceLineItemDataGridView.DataSource = this.invoiceLineItemBindingSource;
            this.invoiceLineItemDataGridView.Enabled = false;
            this.invoiceLineItemDataGridView.Location = new System.Drawing.Point(706, 562);
            this.invoiceLineItemDataGridView.Name = "invoiceLineItemDataGridView";
            this.invoiceLineItemDataGridView.ReadOnly = true;
            this.invoiceLineItemDataGridView.RowTemplate.Height = 24;
            this.invoiceLineItemDataGridView.Size = new System.Drawing.Size(1118, 309);
            this.invoiceLineItemDataGridView.TabIndex = 2;
            this.invoiceLineItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceLineItemDataGridView_CellContentClick);
            this.invoiceLineItemDataGridView.SelectionChanged += new System.EventHandler(this.invoiceLineItemDataGridView_SelectionChanged);
            // 
            // InvLineItemDetailID
            // 
            this.InvLineItemDetailID.DataPropertyName = "InvLineItemDetailID";
            this.InvLineItemDetailID.HeaderText = "Line Item Detail ID";
            this.InvLineItemDetailID.Name = "InvLineItemDetailID";
            this.InvLineItemDetailID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "InvoiceID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Invoice ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ServiceID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Service ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.HeaderText = "Employee First Name";
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            this.EmployeeFirstName.ReadOnly = true;
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.HeaderText = "Employee Last Name";
            this.EmployeeLastName.Name = "EmployeeLastName";
            this.EmployeeLastName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ServiceNumOfHours";
            this.dataGridViewTextBoxColumn9.HeaderText = "Number of Hours Service Performed";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Cost
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "$0.00";
            this.Cost.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // invoiceLineItemBindingSource
            // 
            this.invoiceLineItemBindingSource.DataSource = typeof(MillersLawnService.InvoiceLineItem);
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AllowUserToAddRows = false;
            this.invoiceDataGridView.AllowUserToDeleteRows = false;
            this.invoiceDataGridView.AutoGenerateColumns = false;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.CustomerFirstName,
            this.CustomerLastName,
            this.CustomerPhoneNum,
            this.InvoiceTotal});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            this.invoiceDataGridView.Enabled = false;
            this.invoiceDataGridView.Location = new System.Drawing.Point(706, 185);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.ReadOnly = true;
            this.invoiceDataGridView.RowTemplate.Height = 24;
            this.invoiceDataGridView.Size = new System.Drawing.Size(1118, 317);
            this.invoiceDataGridView.TabIndex = 1;
            this.invoiceDataGridView.SelectionChanged += new System.EventHandler(this.invoiceDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "InvoiceDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Invoice Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // CustomerFirstName
            // 
            this.CustomerFirstName.HeaderText = "Customer First Name";
            this.CustomerFirstName.Name = "CustomerFirstName";
            this.CustomerFirstName.ReadOnly = true;
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.HeaderText = "Customer Last Name";
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.ReadOnly = true;
            // 
            // CustomerPhoneNum
            // 
            this.CustomerPhoneNum.HeaderText = "Customer Phone Number";
            this.CustomerPhoneNum.Name = "CustomerPhoneNum";
            this.CustomerPhoneNum.ReadOnly = true;
            // 
            // InvoiceTotal
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "$0.00";
            this.InvoiceTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.InvoiceTotal.HeaderText = "Invoice Total";
            this.InvoiceTotal.Name = "InvoiceTotal";
            this.InvoiceTotal.ReadOnly = true;
            // 
            // LblInvoiceLineItemsTitle
            // 
            this.LblInvoiceLineItemsTitle.AutoSize = true;
            this.LblInvoiceLineItemsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvoiceLineItemsTitle.Location = new System.Drawing.Point(700, 527);
            this.LblInvoiceLineItemsTitle.Name = "LblInvoiceLineItemsTitle";
            this.LblInvoiceLineItemsTitle.Size = new System.Drawing.Size(242, 32);
            this.LblInvoiceLineItemsTitle.TabIndex = 3;
            this.LblInvoiceLineItemsTitle.Text = "Invoice Line Items";
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTitle.Location = new System.Drawing.Point(700, 150);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(119, 32);
            this.lblInvoiceTitle.TabIndex = 4;
            this.lblInvoiceTitle.Text = "Invoices";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.invoiceLineItemBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 27);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1844, 27);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 24);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(185, 24);
            this.toolStripLabel3.Text = "Invoice Line Item Selected:";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.cboCustNameFilter,
            this.btnFilterByCustName,
            this.toolStripSeparator5,
            this.toolStripLabel5,
            this.btnShowAllInvoices});
            this.toolStrip1.Location = new System.Drawing.Point(0, 54);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1844, 28);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(189, 25);
            this.toolStripLabel4.Text = "Filter Invoices By Customer:";
            // 
            // cboCustNameFilter
            // 
            this.cboCustNameFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustNameFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustNameFilter.Name = "cboCustNameFilter";
            this.cboCustNameFilter.Size = new System.Drawing.Size(200, 28);
            // 
            // btnFilterByCustName
            // 
            this.btnFilterByCustName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilterByCustName.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterByCustName.Image")));
            this.btnFilterByCustName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterByCustName.Name = "btnFilterByCustName";
            this.btnFilterByCustName.Size = new System.Drawing.Size(24, 25);
            this.btnFilterByCustName.Text = "toolStripButton5";
            this.btnFilterByCustName.Click += new System.EventHandler(this.btnFilterByCustName_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(127, 25);
            this.toolStripLabel5.Text = "Show All Invoices:";
            // 
            // btnShowAllInvoices
            // 
            this.btnShowAllInvoices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowAllInvoices.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAllInvoices.Image")));
            this.btnShowAllInvoices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAllInvoices.Name = "btnShowAllInvoices";
            this.btnShowAllInvoices.Size = new System.Drawing.Size(24, 25);
            this.btnShowAllInvoices.Text = "toolStripButton6";
            this.btnShowAllInvoices.Click += new System.EventHandler(this.btnShowAllInvoices_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1719, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxInvoiceBtns
            // 
            this.groupBoxInvoiceBtns.Controls.Add(customerPhoneNumLabel);
            this.groupBoxInvoiceBtns.Controls.Add(this.customerPhoneNumTextBox);
            this.groupBoxInvoiceBtns.Controls.Add(this.btnSaveInvoice);
            this.groupBoxInvoiceBtns.Controls.Add(customerFNameLabel);
            this.groupBoxInvoiceBtns.Controls.Add(this.customerFNameTextBox);
            this.groupBoxInvoiceBtns.Controls.Add(customerLNameLabel1);
            this.groupBoxInvoiceBtns.Controls.Add(this.customerLNameTextBox1);
            this.groupBoxInvoiceBtns.Controls.Add(customerIDLabel);
            this.groupBoxInvoiceBtns.Controls.Add(this.customerIDComboBox);
            this.groupBoxInvoiceBtns.Controls.Add(invoiceIDLabel1);
            this.groupBoxInvoiceBtns.Controls.Add(this.invoiceIDTextBox);
            this.groupBoxInvoiceBtns.Controls.Add(invoiceDateLabel);
            this.groupBoxInvoiceBtns.Controls.Add(this.invoiceDateDateTimePicker);
            this.groupBoxInvoiceBtns.Controls.Add(this.btnDeleteInvoice);
            this.groupBoxInvoiceBtns.Controls.Add(this.btnInvoiceEdit);
            this.groupBoxInvoiceBtns.Controls.Add(this.btnInvoiceAdd);
            this.groupBoxInvoiceBtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInvoiceBtns.Location = new System.Drawing.Point(12, 98);
            this.groupBoxInvoiceBtns.Name = "groupBoxInvoiceBtns";
            this.groupBoxInvoiceBtns.Size = new System.Drawing.Size(682, 394);
            this.groupBoxInvoiceBtns.TabIndex = 8;
            this.groupBoxInvoiceBtns.TabStop = false;
            this.groupBoxInvoiceBtns.Text = "Invoices";
            // 
            // customerPhoneNumTextBox
            // 
            this.customerPhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerPhoneNum", true));
            this.customerPhoneNumTextBox.Location = new System.Drawing.Point(244, 206);
            this.customerPhoneNumTextBox.Name = "customerPhoneNumTextBox";
            this.customerPhoneNumTextBox.ReadOnly = true;
            this.customerPhoneNumTextBox.Size = new System.Drawing.Size(227, 27);
            this.customerPhoneNumTextBox.TabIndex = 24;
            this.customerPhoneNumTextBox.TabStop = false;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MillersLawnService.Customer);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.Location = new System.Drawing.Point(456, 254);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(220, 57);
            this.btnSaveInvoice.TabIndex = 5;
            this.btnSaveInvoice.Text = "Save";
            this.btnSaveInvoice.UseVisualStyleBackColor = true;
            this.btnSaveInvoice.Visible = false;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // customerFNameTextBox
            // 
            this.customerFNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerFName", true));
            this.customerFNameTextBox.Location = new System.Drawing.Point(244, 141);
            this.customerFNameTextBox.Name = "customerFNameTextBox";
            this.customerFNameTextBox.ReadOnly = true;
            this.customerFNameTextBox.Size = new System.Drawing.Size(227, 27);
            this.customerFNameTextBox.TabIndex = 22;
            this.customerFNameTextBox.TabStop = false;
            // 
            // customerLNameTextBox1
            // 
            this.customerLNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerLName", true));
            this.customerLNameTextBox1.Location = new System.Drawing.Point(244, 173);
            this.customerLNameTextBox1.Name = "customerLNameTextBox1";
            this.customerLNameTextBox1.ReadOnly = true;
            this.customerLNameTextBox1.Size = new System.Drawing.Size(227, 27);
            this.customerLNameTextBox1.TabIndex = 21;
            this.customerLNameTextBox1.TabStop = false;
            // 
            // customerIDComboBox
            // 
            this.customerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "CustomerID", true));
            this.customerIDComboBox.DataSource = this.customerBindingSource;
            this.customerIDComboBox.DisplayMember = "CustomerID";
            this.customerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerIDComboBox.Enabled = false;
            this.customerIDComboBox.FormattingEnabled = true;
            this.customerIDComboBox.Location = new System.Drawing.Point(244, 105);
            this.customerIDComboBox.Name = "customerIDComboBox";
            this.customerIDComboBox.Size = new System.Drawing.Size(227, 28);
            this.customerIDComboBox.TabIndex = 1;
            this.customerIDComboBox.ValueMember = "CustomerID";
            // 
            // invoiceIDTextBox
            // 
            this.invoiceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceID", true));
            this.invoiceIDTextBox.Location = new System.Drawing.Point(244, 35);
            this.invoiceIDTextBox.Name = "invoiceIDTextBox";
            this.invoiceIDTextBox.ReadOnly = true;
            this.invoiceIDTextBox.Size = new System.Drawing.Size(227, 27);
            this.invoiceIDTextBox.TabIndex = 14;
            this.invoiceIDTextBox.TabStop = false;
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Enabled = false;
            this.invoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(244, 72);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(227, 27);
            this.invoiceDateDateTimePicker.TabIndex = 0;
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvoice.Location = new System.Drawing.Point(456, 317);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(220, 57);
            this.btnDeleteInvoice.TabIndex = 4;
            this.btnDeleteInvoice.Text = "Delete Invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnInvoiceEdit
            // 
            this.btnInvoiceEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceEdit.Location = new System.Drawing.Point(232, 317);
            this.btnInvoiceEdit.Name = "btnInvoiceEdit";
            this.btnInvoiceEdit.Size = new System.Drawing.Size(220, 57);
            this.btnInvoiceEdit.TabIndex = 3;
            this.btnInvoiceEdit.Text = "Edit Invoice";
            this.btnInvoiceEdit.UseVisualStyleBackColor = true;
            this.btnInvoiceEdit.Click += new System.EventHandler(this.btnInvoiceEdit_Click);
            // 
            // btnInvoiceAdd
            // 
            this.btnInvoiceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceAdd.Location = new System.Drawing.Point(6, 317);
            this.btnInvoiceAdd.Name = "btnInvoiceAdd";
            this.btnInvoiceAdd.Size = new System.Drawing.Size(220, 57);
            this.btnInvoiceAdd.TabIndex = 2;
            this.btnInvoiceAdd.Text = "Add Invoice";
            this.btnInvoiceAdd.UseVisualStyleBackColor = true;
            this.btnInvoiceAdd.Click += new System.EventHandler(this.btnInvoiceAdd_Click);
            // 
            // groupBoxInvoiceLineItemBtns
            // 
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.btnAddInvLineItemSave);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.empLastNameTextBox);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.empFirstNameTextBox);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.serviceCostTextBox);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.servNameTextBox);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.textBox10);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.btnInvLineItemCancel);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.btnInvLineItemSave);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(serviceCostPerHourLabel);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(serviceNameLabel);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(serviceIDLabel);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.serviceIDComboBox);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(employeeLNameLabel);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(employeeFNameLabel);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(invoiceIDLabel);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.invoiceIDTextBox1);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.lblServiceCostMoneySign);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(serviceNumOfHoursLabel);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.serviceNumOfHoursNumericUpDown);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(employeeIDLabel);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.employeeIDComboBox);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.btnDeleteInvLineItem);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.btnEditInvLineItem);
            this.groupBoxInvoiceLineItemBtns.Controls.Add(this.btnAddInvLineItem);
            this.groupBoxInvoiceLineItemBtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInvoiceLineItemBtns.Location = new System.Drawing.Point(12, 486);
            this.groupBoxInvoiceLineItemBtns.Name = "groupBoxInvoiceLineItemBtns";
            this.groupBoxInvoiceLineItemBtns.Size = new System.Drawing.Size(682, 405);
            this.groupBoxInvoiceLineItemBtns.TabIndex = 9;
            this.groupBoxInvoiceLineItemBtns.TabStop = false;
            this.groupBoxInvoiceLineItemBtns.Text = "Invoice Line Items";
            // 
            // btnAddInvLineItemSave
            // 
            this.btnAddInvLineItemSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvLineItemSave.Location = new System.Drawing.Point(6, 265);
            this.btnAddInvLineItemSave.Name = "btnAddInvLineItemSave";
            this.btnAddInvLineItemSave.Size = new System.Drawing.Size(220, 57);
            this.btnAddInvLineItemSave.TabIndex = 14;
            this.btnAddInvLineItemSave.Text = "Save";
            this.btnAddInvLineItemSave.UseVisualStyleBackColor = true;
            this.btnAddInvLineItemSave.Visible = false;
            this.btnAddInvLineItemSave.Click += new System.EventHandler(this.btnAddInvLineItemSave_Click);
            // 
            // empLastNameTextBox
            // 
            this.empLastNameTextBox.Location = new System.Drawing.Point(186, 224);
            this.empLastNameTextBox.Name = "empLastNameTextBox";
            this.empLastNameTextBox.ReadOnly = true;
            this.empLastNameTextBox.Size = new System.Drawing.Size(244, 27);
            this.empLastNameTextBox.TabIndex = 36;
            this.empLastNameTextBox.TabStop = false;
            // 
            // empFirstNameTextBox
            // 
            this.empFirstNameTextBox.Location = new System.Drawing.Point(187, 183);
            this.empFirstNameTextBox.Name = "empFirstNameTextBox";
            this.empFirstNameTextBox.ReadOnly = true;
            this.empFirstNameTextBox.Size = new System.Drawing.Size(244, 27);
            this.empFirstNameTextBox.TabIndex = 35;
            this.empFirstNameTextBox.TabStop = false;
            // 
            // serviceCostTextBox
            // 
            this.serviceCostTextBox.Location = new System.Drawing.Point(232, 142);
            this.serviceCostTextBox.Name = "serviceCostTextBox";
            this.serviceCostTextBox.ReadOnly = true;
            this.serviceCostTextBox.Size = new System.Drawing.Size(138, 27);
            this.serviceCostTextBox.TabIndex = 34;
            this.serviceCostTextBox.TabStop = false;
            // 
            // servNameTextBox
            // 
            this.servNameTextBox.Location = new System.Drawing.Point(140, 107);
            this.servNameTextBox.Name = "servNameTextBox";
            this.servNameTextBox.ReadOnly = true;
            this.servNameTextBox.Size = new System.Drawing.Size(244, 27);
            this.servNameTextBox.TabIndex = 33;
            this.servNameTextBox.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(472, 158);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 27);
            this.textBox10.TabIndex = 32;
            // 
            // btnInvLineItemCancel
            // 
            this.btnInvLineItemCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvLineItemCancel.Location = new System.Drawing.Point(230, 265);
            this.btnInvLineItemCancel.Name = "btnInvLineItemCancel";
            this.btnInvLineItemCancel.Size = new System.Drawing.Size(220, 57);
            this.btnInvLineItemCancel.TabIndex = 12;
            this.btnInvLineItemCancel.Text = "Cancel";
            this.btnInvLineItemCancel.UseVisualStyleBackColor = true;
            this.btnInvLineItemCancel.Visible = false;
            this.btnInvLineItemCancel.Click += new System.EventHandler(this.btnInvLineItemCancel_Click);
            // 
            // btnInvLineItemSave
            // 
            this.btnInvLineItemSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvLineItemSave.Location = new System.Drawing.Point(456, 265);
            this.btnInvLineItemSave.Name = "btnInvLineItemSave";
            this.btnInvLineItemSave.Size = new System.Drawing.Size(220, 57);
            this.btnInvLineItemSave.TabIndex = 13;
            this.btnInvLineItemSave.Text = "Save";
            this.btnInvLineItemSave.UseVisualStyleBackColor = true;
            this.btnInvLineItemSave.Visible = false;
            this.btnInvLineItemSave.Click += new System.EventHandler(this.btnInvLineItemSave_Click);
            // 
            // serviceIDComboBox
            // 
            this.serviceIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceIDComboBox.Enabled = false;
            this.serviceIDComboBox.FormattingEnabled = true;
            this.serviceIDComboBox.Location = new System.Drawing.Point(319, 37);
            this.serviceIDComboBox.Name = "serviceIDComboBox";
            this.serviceIDComboBox.Size = new System.Drawing.Size(112, 28);
            this.serviceIDComboBox.TabIndex = 6;
            this.serviceIDComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceIDComboBox_SelectedIndexChanged);
            // 
            // invoiceIDTextBox1
            // 
            this.invoiceIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceLineItemBindingSource, "InvoiceID", true));
            this.invoiceIDTextBox1.Location = new System.Drawing.Point(106, 38);
            this.invoiceIDTextBox1.Name = "invoiceIDTextBox1";
            this.invoiceIDTextBox1.ReadOnly = true;
            this.invoiceIDTextBox1.Size = new System.Drawing.Size(100, 27);
            this.invoiceIDTextBox1.TabIndex = 24;
            this.invoiceIDTextBox1.TabStop = false;
            // 
            // lblServiceCostMoneySign
            // 
            this.lblServiceCostMoneySign.AutoSize = true;
            this.lblServiceCostMoneySign.Location = new System.Drawing.Point(208, 148);
            this.lblServiceCostMoneySign.Name = "lblServiceCostMoneySign";
            this.lblServiceCostMoneySign.Size = new System.Drawing.Size(18, 20);
            this.lblServiceCostMoneySign.TabIndex = 23;
            this.lblServiceCostMoneySign.Text = "$";
            // 
            // serviceNumOfHoursNumericUpDown
            // 
            this.serviceNumOfHoursNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceLineItemBindingSource, "ServiceNumOfHours", true));
            this.serviceNumOfHoursNumericUpDown.Enabled = false;
            this.serviceNumOfHoursNumericUpDown.Location = new System.Drawing.Point(237, 74);
            this.serviceNumOfHoursNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.serviceNumOfHoursNumericUpDown.Name = "serviceNumOfHoursNumericUpDown";
            this.serviceNumOfHoursNumericUpDown.Size = new System.Drawing.Size(120, 27);
            this.serviceNumOfHoursNumericUpDown.TabIndex = 8;
            this.serviceNumOfHoursNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // employeeIDComboBox
            // 
            this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceLineItemBindingSource, "EmployeeID", true));
            this.employeeIDComboBox.DataSource = this.employeeBindingSource;
            this.employeeIDComboBox.DisplayMember = "EmployeeID";
            this.employeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeIDComboBox.Enabled = false;
            this.employeeIDComboBox.FormattingEnabled = true;
            this.employeeIDComboBox.Location = new System.Drawing.Point(562, 37);
            this.employeeIDComboBox.Name = "employeeIDComboBox";
            this.employeeIDComboBox.Size = new System.Drawing.Size(99, 28);
            this.employeeIDComboBox.TabIndex = 7;
            this.employeeIDComboBox.ValueMember = "EmployeeID";
            this.employeeIDComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeIDComboBox_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(MillersLawnService.Employee);
            // 
            // btnDeleteInvLineItem
            // 
            this.btnDeleteInvLineItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvLineItem.Location = new System.Drawing.Point(456, 328);
            this.btnDeleteInvLineItem.Name = "btnDeleteInvLineItem";
            this.btnDeleteInvLineItem.Size = new System.Drawing.Size(220, 57);
            this.btnDeleteInvLineItem.TabIndex = 11;
            this.btnDeleteInvLineItem.Text = "Delete Line Item";
            this.btnDeleteInvLineItem.UseVisualStyleBackColor = true;
            this.btnDeleteInvLineItem.Click += new System.EventHandler(this.btnDeleteInvLineItem_Click);
            // 
            // btnEditInvLineItem
            // 
            this.btnEditInvLineItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInvLineItem.Location = new System.Drawing.Point(232, 328);
            this.btnEditInvLineItem.Name = "btnEditInvLineItem";
            this.btnEditInvLineItem.Size = new System.Drawing.Size(220, 57);
            this.btnEditInvLineItem.TabIndex = 10;
            this.btnEditInvLineItem.Text = "Edit Line Item";
            this.btnEditInvLineItem.UseVisualStyleBackColor = true;
            this.btnEditInvLineItem.Click += new System.EventHandler(this.btnEditInvLineItem_Click);
            // 
            // btnAddInvLineItem
            // 
            this.btnAddInvLineItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvLineItem.Location = new System.Drawing.Point(6, 328);
            this.btnAddInvLineItem.Name = "btnAddInvLineItem";
            this.btnAddInvLineItem.Size = new System.Drawing.Size(220, 57);
            this.btnAddInvLineItem.TabIndex = 9;
            this.btnAddInvLineItem.Text = "Add Line Item";
            this.btnAddInvLineItem.UseVisualStyleBackColor = true;
            this.btnAddInvLineItem.Click += new System.EventHandler(this.btnAddInvLineItem_Click);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(MillersLawnService.Service);
            // 
            // btnInvoicesExit
            // 
            this.btnInvoicesExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoicesExit.Location = new System.Drawing.Point(1475, 98);
            this.btnInvoicesExit.Name = "btnInvoicesExit";
            this.btnInvoicesExit.Size = new System.Drawing.Size(220, 57);
            this.btnInvoicesExit.TabIndex = 15;
            this.btnInvoicesExit.Text = "Exit";
            this.btnInvoicesExit.UseVisualStyleBackColor = true;
            this.btnInvoicesExit.Click += new System.EventHandler(this.btnInvoicesExit_Click);
            // 
            // InvoiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 891);
            this.Controls.Add(this.btnInvoicesExit);
            this.Controls.Add(this.groupBoxInvoiceLineItemBtns);
            this.Controls.Add(this.groupBoxInvoiceBtns);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.lblInvoiceTitle);
            this.Controls.Add(this.LblInvoiceLineItemsTitle);
            this.Controls.Add(this.invoiceLineItemDataGridView);
            this.Controls.Add(this.invoiceDataGridView);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceListForm";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.InvoiceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInvoiceBtns.ResumeLayout(false);
            this.groupBoxInvoiceBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.groupBoxInvoiceLineItemBtns.ResumeLayout(false);
            this.groupBoxInvoiceLineItemBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceNumOfHoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource invoiceLineItemBindingSource;
        private System.Windows.Forms.DataGridView invoiceLineItemDataGridView;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.Label LblInvoiceLineItemsTitle;
        private System.Windows.Forms.Label lblInvoiceTitle;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox selectedInvoiceIDTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cboCustNameFilter;
        private System.Windows.Forms.ToolStripButton btnFilterByCustName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btnShowAllInvoices;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInvoiceBtns;
        private System.Windows.Forms.GroupBox groupBoxInvoiceLineItemBtns;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnInvoiceEdit;
        private System.Windows.Forms.Button btnInvoiceAdd;
        private System.Windows.Forms.Button btnDeleteInvLineItem;
        private System.Windows.Forms.Button btnEditInvLineItem;
        private System.Windows.Forms.Button btnAddInvLineItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceTotal;
        private System.Windows.Forms.ComboBox customerIDComboBox;
        private System.Windows.Forms.TextBox invoiceIDTextBox;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.TextBox customerLNameTextBox1;
        private System.Windows.Forms.TextBox customerFNameTextBox;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.TextBox customerPhoneNumTextBox;
        private System.Windows.Forms.Button btnInvoicesExit;
        private System.Windows.Forms.NumericUpDown serviceNumOfHoursNumericUpDown;
        private System.Windows.Forms.ComboBox employeeIDComboBox;
        private System.Windows.Forms.Label lblServiceCostMoneySign;
        private System.Windows.Forms.TextBox invoiceIDTextBox1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.ComboBox serviceIDComboBox;
        private System.Windows.Forms.Button btnInvLineItemSave;
        private System.Windows.Forms.Button btnInvLineItemCancel;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvLineItemDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.TextBox servNameTextBox;
        private System.Windows.Forms.TextBox empLastNameTextBox;
        private System.Windows.Forms.TextBox empFirstNameTextBox;
        private System.Windows.Forms.TextBox serviceCostTextBox;
        private System.Windows.Forms.Button btnAddInvLineItemSave;
    }
}