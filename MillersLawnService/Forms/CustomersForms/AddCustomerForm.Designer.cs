namespace MillersLawnService.Forms.CustomersForms
{
    partial class AddCustomerForm
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
            System.Windows.Forms.Label customerLNameLabel;
            System.Windows.Forms.Label customerPhoneNumLabel;
            System.Windows.Forms.Label customerStateLabel;
            System.Windows.Forms.Label customerZipCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            this.customerStateComboBox = new System.Windows.Forms.ComboBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerCityTextBox = new System.Windows.Forms.TextBox();
            this.customerFNameTextBox = new System.Windows.Forms.TextBox();
            this.customerLNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.customerZipCodeTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddCustomerFormTitle = new System.Windows.Forms.TextBox();
            this.btnAddCustomerFormSaveChanges = new System.Windows.Forms.Button();
            this.btnAddCustomerFormCancel = new System.Windows.Forms.Button();
            customerAddressLabel = new System.Windows.Forms.Label();
            customerCityLabel = new System.Windows.Forms.Label();
            customerFNameLabel = new System.Windows.Forms.Label();
            customerLNameLabel = new System.Windows.Forms.Label();
            customerPhoneNumLabel = new System.Windows.Forms.Label();
            customerStateLabel = new System.Windows.Forms.Label();
            customerZipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerAddressLabel.Location = new System.Drawing.Point(19, 322);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new System.Drawing.Size(128, 17);
            customerAddressLabel.TabIndex = 25;
            customerAddressLabel.Text = "Customer Address:";
            // 
            // customerCityLabel
            // 
            customerCityLabel.AutoSize = true;
            customerCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerCityLabel.Location = new System.Drawing.Point(19, 355);
            customerCityLabel.Name = "customerCityLabel";
            customerCityLabel.Size = new System.Drawing.Size(99, 17);
            customerCityLabel.TabIndex = 27;
            customerCityLabel.Text = "Customer City:";
            // 
            // customerFNameLabel
            // 
            customerFNameLabel.AutoSize = true;
            customerFNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerFNameLabel.Location = new System.Drawing.Point(19, 223);
            customerFNameLabel.Name = "customerFNameLabel";
            customerFNameLabel.Size = new System.Drawing.Size(144, 17);
            customerFNameLabel.TabIndex = 29;
            customerFNameLabel.Text = "Customer First Name:";
            // 
            // customerLNameLabel
            // 
            customerLNameLabel.AutoSize = true;
            customerLNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerLNameLabel.Location = new System.Drawing.Point(19, 256);
            customerLNameLabel.Name = "customerLNameLabel";
            customerLNameLabel.Size = new System.Drawing.Size(144, 17);
            customerLNameLabel.TabIndex = 33;
            customerLNameLabel.Text = "Customer Last Name:";
            // 
            // customerPhoneNumLabel
            // 
            customerPhoneNumLabel.AutoSize = true;
            customerPhoneNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerPhoneNumLabel.Location = new System.Drawing.Point(19, 289);
            customerPhoneNumLabel.Name = "customerPhoneNumLabel";
            customerPhoneNumLabel.Size = new System.Drawing.Size(171, 17);
            customerPhoneNumLabel.TabIndex = 35;
            customerPhoneNumLabel.Text = "Customer Phone Number:";
            // 
            // customerStateLabel
            // 
            customerStateLabel.AutoSize = true;
            customerStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerStateLabel.Location = new System.Drawing.Point(19, 388);
            customerStateLabel.Name = "customerStateLabel";
            customerStateLabel.Size = new System.Drawing.Size(109, 17);
            customerStateLabel.TabIndex = 37;
            customerStateLabel.Text = "Customer State:";
            // 
            // customerZipCodeLabel
            // 
            customerZipCodeLabel.AutoSize = true;
            customerZipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerZipCodeLabel.Location = new System.Drawing.Point(19, 421);
            customerZipCodeLabel.Name = "customerZipCodeLabel";
            customerZipCodeLabel.Size = new System.Drawing.Size(133, 17);
            customerZipCodeLabel.TabIndex = 38;
            customerZipCodeLabel.Text = "Customer Zip Code:";
            // 
            // customerStateComboBox
            // 
            this.customerStateComboBox.DataSource = this.stateBindingSource;
            this.customerStateComboBox.DisplayMember = "StateCode";
            this.customerStateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStateComboBox.FormattingEnabled = true;
            this.customerStateComboBox.Location = new System.Drawing.Point(208, 382);
            this.customerStateComboBox.Name = "customerStateComboBox";
            this.customerStateComboBox.Size = new System.Drawing.Size(216, 28);
            this.customerStateComboBox.TabIndex = 5;
            this.customerStateComboBox.ValueMember = "StateCode";
            this.customerStateComboBox.SelectedIndexChanged += new System.EventHandler(this.customerStateComboBox_SelectedIndexChanged);
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(MillersLawnService.State);
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressTextBox.Location = new System.Drawing.Point(208, 316);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerAddressTextBox.TabIndex = 3;
            this.customerAddressTextBox.TextChanged += new System.EventHandler(this.customerAddressTextBox_TextChanged);
            // 
            // customerCityTextBox
            // 
            this.customerCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCityTextBox.Location = new System.Drawing.Point(208, 349);
            this.customerCityTextBox.Name = "customerCityTextBox";
            this.customerCityTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerCityTextBox.TabIndex = 4;
            this.customerCityTextBox.TextChanged += new System.EventHandler(this.customerCityTextBox_TextChanged);
            // 
            // customerFNameTextBox
            // 
            this.customerFNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFNameTextBox.Location = new System.Drawing.Point(208, 217);
            this.customerFNameTextBox.Name = "customerFNameTextBox";
            this.customerFNameTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerFNameTextBox.TabIndex = 0;
            this.customerFNameTextBox.TextChanged += new System.EventHandler(this.customerFNameTextBox_TextChanged);
            // 
            // customerLNameTextBox
            // 
            this.customerLNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLNameTextBox.Location = new System.Drawing.Point(208, 250);
            this.customerLNameTextBox.Name = "customerLNameTextBox";
            this.customerLNameTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerLNameTextBox.TabIndex = 1;
            this.customerLNameTextBox.TextChanged += new System.EventHandler(this.customerLNameTextBox_TextChanged);
            // 
            // customerPhoneNumTextBox
            // 
            this.customerPhoneNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneNumTextBox.Location = new System.Drawing.Point(208, 283);
            this.customerPhoneNumTextBox.MaxLength = 10;
            this.customerPhoneNumTextBox.Name = "customerPhoneNumTextBox";
            this.customerPhoneNumTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerPhoneNumTextBox.TabIndex = 2;
            this.customerPhoneNumTextBox.TextChanged += new System.EventHandler(this.customerPhoneNumTextBox_TextChanged);
            // 
            // customerZipCodeTextBox
            // 
            this.customerZipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerZipCodeTextBox.Location = new System.Drawing.Point(208, 415);
            this.customerZipCodeTextBox.Name = "customerZipCodeTextBox";
            this.customerZipCodeTextBox.Size = new System.Drawing.Size(216, 27);
            this.customerZipCodeTextBox.TabIndex = 6;
            this.customerZipCodeTextBox.TextChanged += new System.EventHandler(this.customerZipCodeTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // AddCustomerFormTitle
            // 
            this.AddCustomerFormTitle.BackColor = System.Drawing.SystemColors.Control;
            this.AddCustomerFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddCustomerFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerFormTitle.Location = new System.Drawing.Point(131, 159);
            this.AddCustomerFormTitle.Name = "AddCustomerFormTitle";
            this.AddCustomerFormTitle.ReadOnly = true;
            this.AddCustomerFormTitle.Size = new System.Drawing.Size(194, 31);
            this.AddCustomerFormTitle.TabIndex = 42;
            this.AddCustomerFormTitle.TabStop = false;
            this.AddCustomerFormTitle.Text = "Add Customer";
            this.AddCustomerFormTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddCustomerFormSaveChanges
            // 
            this.btnAddCustomerFormSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomerFormSaveChanges.Location = new System.Drawing.Point(12, 504);
            this.btnAddCustomerFormSaveChanges.Name = "btnAddCustomerFormSaveChanges";
            this.btnAddCustomerFormSaveChanges.Size = new System.Drawing.Size(199, 57);
            this.btnAddCustomerFormSaveChanges.TabIndex = 7;
            this.btnAddCustomerFormSaveChanges.Text = "Save Changes";
            this.btnAddCustomerFormSaveChanges.UseVisualStyleBackColor = true;
            this.btnAddCustomerFormSaveChanges.Click += new System.EventHandler(this.btnAddCustomerFormSaveChanges_Click);
            // 
            // btnAddCustomerFormCancel
            // 
            this.btnAddCustomerFormCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomerFormCancel.Location = new System.Drawing.Point(246, 504);
            this.btnAddCustomerFormCancel.Name = "btnAddCustomerFormCancel";
            this.btnAddCustomerFormCancel.Size = new System.Drawing.Size(199, 57);
            this.btnAddCustomerFormCancel.TabIndex = 8;
            this.btnAddCustomerFormCancel.Text = "Cancel";
            this.btnAddCustomerFormCancel.UseVisualStyleBackColor = true;
            this.btnAddCustomerFormCancel.Click += new System.EventHandler(this.btnAddCustomerFormCancel_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 573);
            this.Controls.Add(this.btnAddCustomerFormCancel);
            this.Controls.Add(this.btnAddCustomerFormSaveChanges);
            this.Controls.Add(this.AddCustomerFormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customerStateComboBox);
            this.Controls.Add(customerAddressLabel);
            this.Controls.Add(this.customerAddressTextBox);
            this.Controls.Add(customerCityLabel);
            this.Controls.Add(this.customerCityTextBox);
            this.Controls.Add(customerFNameLabel);
            this.Controls.Add(this.customerFNameTextBox);
            this.Controls.Add(customerLNameLabel);
            this.Controls.Add(this.customerLNameTextBox);
            this.Controls.Add(customerPhoneNumLabel);
            this.Controls.Add(this.customerPhoneNumTextBox);
            this.Controls.Add(customerStateLabel);
            this.Controls.Add(customerZipCodeLabel);
            this.Controls.Add(this.customerZipCodeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCustomerForm";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerStateComboBox;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.TextBox customerCityTextBox;
        private System.Windows.Forms.TextBox customerFNameTextBox;
        private System.Windows.Forms.TextBox customerLNameTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumTextBox;
        private System.Windows.Forms.TextBox customerZipCodeTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox AddCustomerFormTitle;
        private System.Windows.Forms.BindingSource stateBindingSource;
        private System.Windows.Forms.Button btnAddCustomerFormSaveChanges;
        private System.Windows.Forms.Button btnAddCustomerFormCancel;
    }
}