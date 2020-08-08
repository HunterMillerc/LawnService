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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersListForm));
            System.Windows.Forms.Label customerAddressLabel;
            System.Windows.Forms.Label customerCityLabel;
            System.Windows.Forms.Label customerFNameLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label customerLNameLabel;
            System.Windows.Forms.Label customerPhoneNumLabel;
            System.Windows.Forms.Label customerStateLabel;
            System.Windows.Forms.Label customerZipCodeLabel;
            System.Windows.Forms.Label stateCodeLabel;
            System.Windows.Forms.Label stateNameLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
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
            this.customerStateTextBox = new System.Windows.Forms.TextBox();
            this.customerZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.stateCodeTextBox = new System.Windows.Forms.TextBox();
            this.stateNameTextBox = new System.Windows.Forms.TextBox();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerZipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            customerAddressLabel = new System.Windows.Forms.Label();
            customerCityLabel = new System.Windows.Forms.Label();
            customerFNameLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            customerLNameLabel = new System.Windows.Forms.Label();
            customerPhoneNumLabel = new System.Windows.Forms.Label();
            customerStateLabel = new System.Windows.Forms.Label();
            customerZipCodeLabel = new System.Windows.Forms.Label();
            stateCodeLabel = new System.Windows.Forms.Label();
            stateNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerFNameDataGridViewTextBoxColumn,
            this.customerLNameDataGridViewTextBoxColumn,
            this.customerPhoneNumDataGridViewTextBoxColumn,
            this.customerStateDataGridViewTextBoxColumn,
            this.customerCityDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerZipCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(481, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.customerBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1543, 27);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Location = new System.Drawing.Point(110, 190);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new System.Drawing.Size(128, 17);
            customerAddressLabel.TabIndex = 2;
            customerAddressLabel.Text = "Customer Address:";
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerAddress", true));
            this.customerAddressTextBox.Location = new System.Drawing.Point(266, 187);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerAddressTextBox.TabIndex = 3;
            // 
            // customerCityLabel
            // 
            customerCityLabel.AutoSize = true;
            customerCityLabel.Location = new System.Drawing.Point(110, 218);
            customerCityLabel.Name = "customerCityLabel";
            customerCityLabel.Size = new System.Drawing.Size(99, 17);
            customerCityLabel.TabIndex = 4;
            customerCityLabel.Text = "Customer City:";
            // 
            // customerCityTextBox
            // 
            this.customerCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerCity", true));
            this.customerCityTextBox.Location = new System.Drawing.Point(266, 215);
            this.customerCityTextBox.Name = "customerCityTextBox";
            this.customerCityTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerCityTextBox.TabIndex = 5;
            // 
            // customerFNameLabel
            // 
            customerFNameLabel.AutoSize = true;
            customerFNameLabel.Location = new System.Drawing.Point(110, 246);
            customerFNameLabel.Name = "customerFNameLabel";
            customerFNameLabel.Size = new System.Drawing.Size(121, 17);
            customerFNameLabel.TabIndex = 6;
            customerFNameLabel.Text = "Customer FName:";
            // 
            // customerFNameTextBox
            // 
            this.customerFNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerFName", true));
            this.customerFNameTextBox.Location = new System.Drawing.Point(266, 243);
            this.customerFNameTextBox.Name = "customerFNameTextBox";
            this.customerFNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerFNameTextBox.TabIndex = 7;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(110, 274);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(89, 17);
            customerIDLabel.TabIndex = 8;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(266, 271);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerIDTextBox.TabIndex = 9;
            // 
            // customerLNameLabel
            // 
            customerLNameLabel.AutoSize = true;
            customerLNameLabel.Location = new System.Drawing.Point(110, 302);
            customerLNameLabel.Name = "customerLNameLabel";
            customerLNameLabel.Size = new System.Drawing.Size(121, 17);
            customerLNameLabel.TabIndex = 10;
            customerLNameLabel.Text = "Customer LName:";
            // 
            // customerLNameTextBox
            // 
            this.customerLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerLName", true));
            this.customerLNameTextBox.Location = new System.Drawing.Point(266, 299);
            this.customerLNameTextBox.Name = "customerLNameTextBox";
            this.customerLNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerLNameTextBox.TabIndex = 11;
            // 
            // customerPhoneNumLabel
            // 
            customerPhoneNumLabel.AutoSize = true;
            customerPhoneNumLabel.Location = new System.Drawing.Point(110, 330);
            customerPhoneNumLabel.Name = "customerPhoneNumLabel";
            customerPhoneNumLabel.Size = new System.Drawing.Size(150, 17);
            customerPhoneNumLabel.TabIndex = 12;
            customerPhoneNumLabel.Text = "Customer Phone Num:";
            // 
            // customerPhoneNumTextBox
            // 
            this.customerPhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerPhoneNum", true));
            this.customerPhoneNumTextBox.Location = new System.Drawing.Point(266, 327);
            this.customerPhoneNumTextBox.Name = "customerPhoneNumTextBox";
            this.customerPhoneNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerPhoneNumTextBox.TabIndex = 13;
            // 
            // customerStateLabel
            // 
            customerStateLabel.AutoSize = true;
            customerStateLabel.Location = new System.Drawing.Point(110, 358);
            customerStateLabel.Name = "customerStateLabel";
            customerStateLabel.Size = new System.Drawing.Size(109, 17);
            customerStateLabel.TabIndex = 14;
            customerStateLabel.Text = "Customer State:";
            // 
            // customerStateTextBox
            // 
            this.customerStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerState", true));
            this.customerStateTextBox.Location = new System.Drawing.Point(266, 355);
            this.customerStateTextBox.Name = "customerStateTextBox";
            this.customerStateTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerStateTextBox.TabIndex = 15;
            // 
            // customerZipCodeLabel
            // 
            customerZipCodeLabel.AutoSize = true;
            customerZipCodeLabel.Location = new System.Drawing.Point(110, 386);
            customerZipCodeLabel.Name = "customerZipCodeLabel";
            customerZipCodeLabel.Size = new System.Drawing.Size(133, 17);
            customerZipCodeLabel.TabIndex = 16;
            customerZipCodeLabel.Text = "Customer Zip Code:";
            // 
            // customerZipCodeTextBox
            // 
            this.customerZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerZipCode", true));
            this.customerZipCodeTextBox.Location = new System.Drawing.Point(266, 383);
            this.customerZipCodeTextBox.Name = "customerZipCodeTextBox";
            this.customerZipCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.customerZipCodeTextBox.TabIndex = 17;
            // 
            // stateCodeLabel
            // 
            stateCodeLabel.AutoSize = true;
            stateCodeLabel.Location = new System.Drawing.Point(110, 448);
            stateCodeLabel.Name = "stateCodeLabel";
            stateCodeLabel.Size = new System.Drawing.Size(82, 17);
            stateCodeLabel.TabIndex = 18;
            stateCodeLabel.Text = "State Code:";
            // 
            // stateCodeTextBox
            // 
            this.stateCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "tblState.StateCode", true));
            this.stateCodeTextBox.Location = new System.Drawing.Point(202, 445);
            this.stateCodeTextBox.Name = "stateCodeTextBox";
            this.stateCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.stateCodeTextBox.TabIndex = 19;
            // 
            // stateNameLabel
            // 
            stateNameLabel.AutoSize = true;
            stateNameLabel.Location = new System.Drawing.Point(110, 476);
            stateNameLabel.Name = "stateNameLabel";
            stateNameLabel.Size = new System.Drawing.Size(86, 17);
            stateNameLabel.TabIndex = 20;
            stateNameLabel.Text = "State Name:";
            // 
            // stateNameTextBox
            // 
            this.stateNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "tblState.StateName", true));
            this.stateNameTextBox.Location = new System.Drawing.Point(202, 473);
            this.stateNameTextBox.Name = "stateNameTextBox";
            this.stateNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.stateNameTextBox.TabIndex = 21;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MillersLawnService.Customer);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(MillersLawnService.State);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(MillersLawnService.Customer);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerFNameDataGridViewTextBoxColumn
            // 
            this.customerFNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFName";
            this.customerFNameDataGridViewTextBoxColumn.HeaderText = "CustomerFName";
            this.customerFNameDataGridViewTextBoxColumn.Name = "customerFNameDataGridViewTextBoxColumn";
            // 
            // customerLNameDataGridViewTextBoxColumn
            // 
            this.customerLNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLName";
            this.customerLNameDataGridViewTextBoxColumn.HeaderText = "CustomerLName";
            this.customerLNameDataGridViewTextBoxColumn.Name = "customerLNameDataGridViewTextBoxColumn";
            // 
            // customerPhoneNumDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhoneNum";
            this.customerPhoneNumDataGridViewTextBoxColumn.HeaderText = "CustomerPhoneNum";
            this.customerPhoneNumDataGridViewTextBoxColumn.Name = "customerPhoneNumDataGridViewTextBoxColumn";
            // 
            // customerStateDataGridViewTextBoxColumn
            // 
            this.customerStateDataGridViewTextBoxColumn.DataPropertyName = "CustomerState";
            this.customerStateDataGridViewTextBoxColumn.HeaderText = "CustomerState";
            this.customerStateDataGridViewTextBoxColumn.Name = "customerStateDataGridViewTextBoxColumn";
            // 
            // customerCityDataGridViewTextBoxColumn
            // 
            this.customerCityDataGridViewTextBoxColumn.DataPropertyName = "CustomerCity";
            this.customerCityDataGridViewTextBoxColumn.HeaderText = "CustomerCity";
            this.customerCityDataGridViewTextBoxColumn.Name = "customerCityDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // customerZipCodeDataGridViewTextBoxColumn
            // 
            this.customerZipCodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerZipCode";
            this.customerZipCodeDataGridViewTextBoxColumn.HeaderText = "CustomerZipCode";
            this.customerZipCodeDataGridViewTextBoxColumn.Name = "customerZipCodeDataGridViewTextBoxColumn";
            // 
            // CustomersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 758);
            this.Controls.Add(stateCodeLabel);
            this.Controls.Add(this.stateCodeTextBox);
            this.Controls.Add(stateNameLabel);
            this.Controls.Add(this.stateNameTextBox);
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
            this.Controls.Add(this.customerStateTextBox);
            this.Controls.Add(customerZipCodeLabel);
            this.Controls.Add(this.customerZipCodeTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomersListForm";
            this.Text = "CustomersListForm";
            this.Load += new System.EventHandler(this.CustomersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.TextBox customerCityTextBox;
        private System.Windows.Forms.TextBox customerFNameTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox customerLNameTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumTextBox;
        private System.Windows.Forms.TextBox customerStateTextBox;
        private System.Windows.Forms.TextBox customerZipCodeTextBox;
        private System.Windows.Forms.TextBox stateCodeTextBox;
        private System.Windows.Forms.TextBox stateNameTextBox;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerZipCodeDataGridViewTextBoxColumn;
    }
}