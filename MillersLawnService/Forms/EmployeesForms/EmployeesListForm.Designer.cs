namespace MillersLawnService.Forms.EmployeesForms
{
    partial class EmployeesListForm
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
            System.Windows.Forms.Label employeeAddressLabel;
            System.Windows.Forms.Label employeeCityLabel;
            System.Windows.Forms.Label employeeCurrentPayLabel;
            System.Windows.Forms.Label employeeFNameLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label employeeLNameLabel;
            System.Windows.Forms.Label employeePhoneNumLabel;
            System.Windows.Forms.Label employeeStateLabel;
            System.Windows.Forms.Label employeeZipCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnEmployeeFormExit = new System.Windows.Forms.Button();
            this.btnEmployeeFormSaveChanges = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmployeeFormDeleteEmp = new System.Windows.Forms.Button();
            this.btnEmployeeFormEditEmp = new System.Windows.Forms.Button();
            this.btnEmployeeFormAddEmp = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employeeAddressTextBox = new System.Windows.Forms.TextBox();
            this.employeeCityTextBox = new System.Windows.Forms.TextBox();
            this.employeeCurrentPayTextBox = new System.Windows.Forms.TextBox();
            this.employeeFNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeLNameTextBox = new System.Windows.Forms.TextBox();
            this.employeePhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.employeeZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeStateComboBox = new System.Windows.Forms.ComboBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empPayLabelMoneySign = new System.Windows.Forms.Label();
            employeeAddressLabel = new System.Windows.Forms.Label();
            employeeCityLabel = new System.Windows.Forms.Label();
            employeeCurrentPayLabel = new System.Windows.Forms.Label();
            employeeFNameLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            employeeLNameLabel = new System.Windows.Forms.Label();
            employeePhoneNumLabel = new System.Windows.Forms.Label();
            employeeStateLabel = new System.Windows.Forms.Label();
            employeeZipCodeLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeAddressLabel
            // 
            employeeAddressLabel.AutoSize = true;
            employeeAddressLabel.Location = new System.Drawing.Point(8, 317);
            employeeAddressLabel.Name = "employeeAddressLabel";
            employeeAddressLabel.Size = new System.Drawing.Size(130, 17);
            employeeAddressLabel.TabIndex = 51;
            employeeAddressLabel.Text = "Employee Address:";
            // 
            // employeeCityLabel
            // 
            employeeCityLabel.AutoSize = true;
            employeeCityLabel.Location = new System.Drawing.Point(8, 350);
            employeeCityLabel.Name = "employeeCityLabel";
            employeeCityLabel.Size = new System.Drawing.Size(101, 17);
            employeeCityLabel.TabIndex = 53;
            employeeCityLabel.Text = "Employee City:";
            // 
            // employeeCurrentPayLabel
            // 
            employeeCurrentPayLabel.AutoSize = true;
            employeeCurrentPayLabel.Location = new System.Drawing.Point(8, 449);
            employeeCurrentPayLabel.Name = "employeeCurrentPayLabel";
            employeeCurrentPayLabel.Size = new System.Drawing.Size(153, 17);
            employeeCurrentPayLabel.TabIndex = 55;
            employeeCurrentPayLabel.Text = "Employee Current Pay:";
            // 
            // employeeFNameLabel
            // 
            employeeFNameLabel.AutoSize = true;
            employeeFNameLabel.Location = new System.Drawing.Point(8, 218);
            employeeFNameLabel.Name = "employeeFNameLabel";
            employeeFNameLabel.Size = new System.Drawing.Size(146, 17);
            employeeFNameLabel.TabIndex = 57;
            employeeFNameLabel.Text = "Employee First Name:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(8, 185);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(91, 17);
            employeeIDLabel.TabIndex = 59;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // employeeLNameLabel
            // 
            employeeLNameLabel.AutoSize = true;
            employeeLNameLabel.Location = new System.Drawing.Point(8, 251);
            employeeLNameLabel.Name = "employeeLNameLabel";
            employeeLNameLabel.Size = new System.Drawing.Size(146, 17);
            employeeLNameLabel.TabIndex = 61;
            employeeLNameLabel.Text = "Employee Last Name:";
            // 
            // employeePhoneNumLabel
            // 
            employeePhoneNumLabel.AutoSize = true;
            employeePhoneNumLabel.Location = new System.Drawing.Point(8, 284);
            employeePhoneNumLabel.Name = "employeePhoneNumLabel";
            employeePhoneNumLabel.Size = new System.Drawing.Size(173, 17);
            employeePhoneNumLabel.TabIndex = 63;
            employeePhoneNumLabel.Text = "Employee Phone Number:";
            // 
            // employeeStateLabel
            // 
            employeeStateLabel.AutoSize = true;
            employeeStateLabel.Location = new System.Drawing.Point(8, 383);
            employeeStateLabel.Name = "employeeStateLabel";
            employeeStateLabel.Size = new System.Drawing.Size(111, 17);
            employeeStateLabel.TabIndex = 65;
            employeeStateLabel.Text = "Employee State:";
            // 
            // employeeZipCodeLabel
            // 
            employeeZipCodeLabel.AutoSize = true;
            employeeZipCodeLabel.Location = new System.Drawing.Point(8, 416);
            employeeZipCodeLabel.Name = "employeeZipCodeLabel";
            employeeZipCodeLabel.Size = new System.Drawing.Size(135, 17);
            employeeZipCodeLabel.TabIndex = 67;
            employeeZipCodeLabel.Text = "Employee Zip Code:";
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
            this.toolStrip1.Size = new System.Drawing.Size(1587, 28);
            this.toolStrip1.TabIndex = 51;
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
            // btnEmployeeFormExit
            // 
            this.btnEmployeeFormExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeFormExit.Location = new System.Drawing.Point(1347, 699);
            this.btnEmployeeFormExit.Name = "btnEmployeeFormExit";
            this.btnEmployeeFormExit.Size = new System.Drawing.Size(220, 57);
            this.btnEmployeeFormExit.TabIndex = 12;
            this.btnEmployeeFormExit.Text = "Exit";
            this.btnEmployeeFormExit.UseVisualStyleBackColor = true;
            this.btnEmployeeFormExit.Click += new System.EventHandler(this.btnEmployeeFormExit_Click);
            // 
            // btnEmployeeFormSaveChanges
            // 
            this.btnEmployeeFormSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeFormSaveChanges.Location = new System.Drawing.Point(84, 497);
            this.btnEmployeeFormSaveChanges.Name = "btnEmployeeFormSaveChanges";
            this.btnEmployeeFormSaveChanges.Size = new System.Drawing.Size(220, 57);
            this.btnEmployeeFormSaveChanges.TabIndex = 8;
            this.btnEmployeeFormSaveChanges.Text = "Save Changes";
            this.btnEmployeeFormSaveChanges.UseVisualStyleBackColor = true;
            this.btnEmployeeFormSaveChanges.Visible = false;
            this.btnEmployeeFormSaveChanges.Click += new System.EventHandler(this.btnEmployeeFormSaveChanges_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1452, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmployeeFormDeleteEmp
            // 
            this.btnEmployeeFormDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeFormDeleteEmp.Location = new System.Drawing.Point(11, 699);
            this.btnEmployeeFormDeleteEmp.Name = "btnEmployeeFormDeleteEmp";
            this.btnEmployeeFormDeleteEmp.Size = new System.Drawing.Size(369, 57);
            this.btnEmployeeFormDeleteEmp.TabIndex = 11;
            this.btnEmployeeFormDeleteEmp.Text = "Delete Employee";
            this.btnEmployeeFormDeleteEmp.UseVisualStyleBackColor = true;
            this.btnEmployeeFormDeleteEmp.Click += new System.EventHandler(this.btnEmployeeFormDeleteEmp_Click);
            // 
            // btnEmployeeFormEditEmp
            // 
            this.btnEmployeeFormEditEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeFormEditEmp.Location = new System.Drawing.Point(11, 636);
            this.btnEmployeeFormEditEmp.Name = "btnEmployeeFormEditEmp";
            this.btnEmployeeFormEditEmp.Size = new System.Drawing.Size(369, 57);
            this.btnEmployeeFormEditEmp.TabIndex = 10;
            this.btnEmployeeFormEditEmp.Text = "Edit Employee";
            this.btnEmployeeFormEditEmp.UseVisualStyleBackColor = true;
            this.btnEmployeeFormEditEmp.Click += new System.EventHandler(this.btnEmployeeFormEditEmp_Click);
            // 
            // btnEmployeeFormAddEmp
            // 
            this.btnEmployeeFormAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeFormAddEmp.Location = new System.Drawing.Point(11, 573);
            this.btnEmployeeFormAddEmp.Name = "btnEmployeeFormAddEmp";
            this.btnEmployeeFormAddEmp.Size = new System.Drawing.Size(369, 57);
            this.btnEmployeeFormAddEmp.TabIndex = 9;
            this.btnEmployeeFormAddEmp.Text = "Add Employee";
            this.btnEmployeeFormAddEmp.UseVisualStyleBackColor = true;
            this.btnEmployeeFormAddEmp.Click += new System.EventHandler(this.btnEmployeeFormAddEmp_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.employeeBindingSource;
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
            this.bindingNavigator1.TabIndex = 28;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(MillersLawnService.Employee);
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
            // employeeAddressTextBox
            // 
            this.employeeAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeAddress", true));
            this.employeeAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeAddressTextBox.Location = new System.Drawing.Point(183, 311);
            this.employeeAddressTextBox.Name = "employeeAddressTextBox";
            this.employeeAddressTextBox.ReadOnly = true;
            this.employeeAddressTextBox.Size = new System.Drawing.Size(216, 27);
            this.employeeAddressTextBox.TabIndex = 3;
            this.employeeAddressTextBox.TextChanged += new System.EventHandler(this.employeeAddressTextBox_TextChanged);
            // 
            // employeeCityTextBox
            // 
            this.employeeCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeCity", true));
            this.employeeCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCityTextBox.Location = new System.Drawing.Point(183, 344);
            this.employeeCityTextBox.Name = "employeeCityTextBox";
            this.employeeCityTextBox.ReadOnly = true;
            this.employeeCityTextBox.Size = new System.Drawing.Size(216, 27);
            this.employeeCityTextBox.TabIndex = 4;
            this.employeeCityTextBox.TextChanged += new System.EventHandler(this.employeeCityTextBox_TextChanged);
            // 
            // employeeCurrentPayTextBox
            // 
            this.employeeCurrentPayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeCurrentPay", true));
            this.employeeCurrentPayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCurrentPayTextBox.Location = new System.Drawing.Point(183, 443);
            this.employeeCurrentPayTextBox.MaxLength = 7;
            this.employeeCurrentPayTextBox.Name = "employeeCurrentPayTextBox";
            this.employeeCurrentPayTextBox.ReadOnly = true;
            this.employeeCurrentPayTextBox.Size = new System.Drawing.Size(216, 27);
            this.employeeCurrentPayTextBox.TabIndex = 7;
            this.employeeCurrentPayTextBox.TextChanged += new System.EventHandler(this.employeeCurrentPayTextBox_TextChanged);
            // 
            // employeeFNameTextBox
            // 
            this.employeeFNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeFName", true));
            this.employeeFNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeFNameTextBox.Location = new System.Drawing.Point(183, 212);
            this.employeeFNameTextBox.Name = "employeeFNameTextBox";
            this.employeeFNameTextBox.ReadOnly = true;
            this.employeeFNameTextBox.Size = new System.Drawing.Size(216, 27);
            this.employeeFNameTextBox.TabIndex = 0;
            this.employeeFNameTextBox.TextChanged += new System.EventHandler(this.employeeFNameTextBox_TextChanged);
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTextBox.Location = new System.Drawing.Point(183, 179);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.ReadOnly = true;
            this.employeeIDTextBox.Size = new System.Drawing.Size(216, 27);
            this.employeeIDTextBox.TabIndex = 30;
            this.employeeIDTextBox.TabStop = false;
            // 
            // employeeLNameTextBox
            // 
            this.employeeLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeLName", true));
            this.employeeLNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLNameTextBox.Location = new System.Drawing.Point(183, 245);
            this.employeeLNameTextBox.Name = "employeeLNameTextBox";
            this.employeeLNameTextBox.ReadOnly = true;
            this.employeeLNameTextBox.Size = new System.Drawing.Size(216, 27);
            this.employeeLNameTextBox.TabIndex = 1;
            this.employeeLNameTextBox.TextChanged += new System.EventHandler(this.employeeLNameTextBox_TextChanged);
            // 
            // employeePhoneNumTextBox
            // 
            this.employeePhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeePhoneNum", true));
            this.employeePhoneNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePhoneNumTextBox.Location = new System.Drawing.Point(183, 278);
            this.employeePhoneNumTextBox.Name = "employeePhoneNumTextBox";
            this.employeePhoneNumTextBox.ReadOnly = true;
            this.employeePhoneNumTextBox.Size = new System.Drawing.Size(216, 27);
            this.employeePhoneNumTextBox.TabIndex = 2;
            this.employeePhoneNumTextBox.TextChanged += new System.EventHandler(this.employeePhoneNumTextBox_TextChanged);
            // 
            // employeeZipCodeTextBox
            // 
            this.employeeZipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeZipCode", true));
            this.employeeZipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeZipCodeTextBox.Location = new System.Drawing.Point(183, 410);
            this.employeeZipCodeTextBox.Name = "employeeZipCodeTextBox";
            this.employeeZipCodeTextBox.ReadOnly = true;
            this.employeeZipCodeTextBox.Size = new System.Drawing.Size(216, 27);
            this.employeeZipCodeTextBox.TabIndex = 6;
            this.employeeZipCodeTextBox.TextChanged += new System.EventHandler(this.employeeZipCodeTextBox_TextChanged);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AllowUserToDeleteRows = false;
            this.employeeDataGridView.AllowUserToOrderColumns = true;
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(405, 179);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(1162, 493);
            this.employeeDataGridView.TabIndex = 68;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeFName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmployeeLName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EmployeePhoneNum";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EmployeeState";
            this.dataGridViewTextBoxColumn5.HeaderText = "State";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EmployeeCity";
            this.dataGridViewTextBoxColumn6.HeaderText = "City";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EmployeeAddress";
            this.dataGridViewTextBoxColumn7.HeaderText = "Address";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EmployeeZipCode";
            this.dataGridViewTextBoxColumn8.HeaderText = "Zip Code";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EmployeeCurrentPay";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn9.HeaderText = "Current Pay";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // employeeStateComboBox
            // 
            this.employeeStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeState", true));
            this.employeeStateComboBox.DataSource = this.stateBindingSource;
            this.employeeStateComboBox.DisplayMember = "StateCode";
            this.employeeStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeStateComboBox.Enabled = false;
            this.employeeStateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeStateComboBox.FormattingEnabled = true;
            this.employeeStateComboBox.Location = new System.Drawing.Point(183, 377);
            this.employeeStateComboBox.Name = "employeeStateComboBox";
            this.employeeStateComboBox.Size = new System.Drawing.Size(216, 28);
            this.employeeStateComboBox.TabIndex = 5;
            this.employeeStateComboBox.ValueMember = "StateCode";
            this.employeeStateComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeStateComboBox_SelectedIndexChanged);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(MillersLawnService.State);
            // 
            // empPayLabelMoneySign
            // 
            this.empPayLabelMoneySign.AutoSize = true;
            this.empPayLabelMoneySign.Location = new System.Drawing.Point(165, 449);
            this.empPayLabelMoneySign.Name = "empPayLabelMoneySign";
            this.empPayLabelMoneySign.Size = new System.Drawing.Size(16, 17);
            this.empPayLabelMoneySign.TabIndex = 70;
            this.empPayLabelMoneySign.Text = "$";
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 776);
            this.Controls.Add(this.empPayLabelMoneySign);
            this.Controls.Add(this.employeeStateComboBox);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(employeeAddressLabel);
            this.Controls.Add(this.employeeAddressTextBox);
            this.Controls.Add(employeeCityLabel);
            this.Controls.Add(this.employeeCityTextBox);
            this.Controls.Add(employeeCurrentPayLabel);
            this.Controls.Add(this.employeeCurrentPayTextBox);
            this.Controls.Add(employeeFNameLabel);
            this.Controls.Add(this.employeeFNameTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(employeeLNameLabel);
            this.Controls.Add(this.employeeLNameTextBox);
            this.Controls.Add(employeePhoneNumLabel);
            this.Controls.Add(this.employeePhoneNumTextBox);
            this.Controls.Add(employeeStateLabel);
            this.Controls.Add(employeeZipCodeLabel);
            this.Controls.Add(this.employeeZipCodeTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnEmployeeFormExit);
            this.Controls.Add(this.btnEmployeeFormSaveChanges);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEmployeeFormDeleteEmp);
            this.Controls.Add(this.btnEmployeeFormEditEmp);
            this.Controls.Add(this.btnEmployeeFormAddEmp);
            this.Controls.Add(this.bindingNavigator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeesListForm";
            this.Text = "Employees";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnEmployeeFormExit;
        private System.Windows.Forms.Button btnEmployeeFormSaveChanges;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmployeeFormDeleteEmp;
        private System.Windows.Forms.Button btnEmployeeFormEditEmp;
        private System.Windows.Forms.Button btnEmployeeFormAddEmp;
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
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TextBox employeeAddressTextBox;
        private System.Windows.Forms.TextBox employeeCityTextBox;
        private System.Windows.Forms.TextBox employeeCurrentPayTextBox;
        private System.Windows.Forms.TextBox employeeFNameTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox employeeLNameTextBox;
        private System.Windows.Forms.TextBox employeePhoneNumTextBox;
        private System.Windows.Forms.TextBox employeeZipCodeTextBox;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.ComboBox employeeStateComboBox;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.Label empPayLabelMoneySign;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}