namespace MillersLawnService.Forms.InvoicesForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.invoiceLineItemDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblInvoiceLineItemsTitle = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.selectedInvoiceIDTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cboCustNameFilter = new System.Windows.Forms.ToolStripComboBox();
            this.btnFilterByCustName = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnShowAllInvoices = new System.Windows.Forms.ToolStripButton();
            this.invoiceLineItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // invoiceLineItemDataGridView
            // 
            this.invoiceLineItemDataGridView.AllowUserToAddRows = false;
            this.invoiceLineItemDataGridView.AllowUserToDeleteRows = false;
            this.invoiceLineItemDataGridView.AutoGenerateColumns = false;
            this.invoiceLineItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceLineItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.EmployeeFirstName,
            this.EmployeeLastName,
            this.dataGridViewTextBoxColumn9,
            this.Cost});
            this.invoiceLineItemDataGridView.DataSource = this.invoiceLineItemBindingSource;
            this.invoiceLineItemDataGridView.Location = new System.Drawing.Point(706, 562);
            this.invoiceLineItemDataGridView.Name = "invoiceLineItemDataGridView";
            this.invoiceLineItemDataGridView.ReadOnly = true;
            this.invoiceLineItemDataGridView.RowTemplate.Height = 24;
            this.invoiceLineItemDataGridView.Size = new System.Drawing.Size(1118, 309);
            this.invoiceLineItemDataGridView.TabIndex = 2;
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
            // Cost
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.Cost.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
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
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0";
            this.InvoiceTotal.DefaultCellStyle = dataGridViewCellStyle5;
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(139, 24);
            this.toolStripLabel2.Text = "Invoice ID Selected:";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(185, 24);
            this.toolStripLabel3.Text = "Invoice Line Item Selected:";
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
            // 
            // invoiceLineItemBindingSource
            // 
            this.invoiceLineItemBindingSource.DataSource = typeof(MillersLawnService.InvoiceLineItem);
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ServiceNumOfHours";
            this.dataGridViewTextBoxColumn9.HeaderText = "Number of Hours Service Performed";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
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
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
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
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(MillersLawnService.Invoice);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MillersLawnService.Customer);
            // 
            // InvoiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 891);
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
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceLineItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceTotal;
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
    }
}