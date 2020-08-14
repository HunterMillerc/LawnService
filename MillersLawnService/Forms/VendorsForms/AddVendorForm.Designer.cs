namespace MillersLawnService.Forms.VendorsForms
{
    partial class AddVendorForm
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
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label vendorPhoneNumLabel;
            System.Windows.Forms.Label vendorStateLabel;
            System.Windows.Forms.Label vendorZipCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVendorForm));
            this.btnAddVendorFormCancel = new System.Windows.Forms.Button();
            this.btnAddVendorFormSaveChanges = new System.Windows.Forms.Button();
            this.AddVendorFormTitle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorAddressTextBox = new System.Windows.Forms.TextBox();
            this.vendorCityTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.vendorPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.vendorStateComboBox = new System.Windows.Forms.ComboBox();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorZipCodeTextBox = new System.Windows.Forms.TextBox();
            vendorAddressLabel = new System.Windows.Forms.Label();
            vendorCityLabel = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            vendorPhoneNumLabel = new System.Windows.Forms.Label();
            vendorStateLabel = new System.Windows.Forms.Label();
            vendorZipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorAddressLabel
            // 
            vendorAddressLabel.AutoSize = true;
            vendorAddressLabel.Location = new System.Drawing.Point(59, 272);
            vendorAddressLabel.Name = "vendorAddressLabel";
            vendorAddressLabel.Size = new System.Drawing.Size(114, 17);
            vendorAddressLabel.TabIndex = 61;
            vendorAddressLabel.Text = "Vendor Address:";
            // 
            // vendorCityLabel
            // 
            vendorCityLabel.AutoSize = true;
            vendorCityLabel.Location = new System.Drawing.Point(59, 305);
            vendorCityLabel.Name = "vendorCityLabel";
            vendorCityLabel.Size = new System.Drawing.Size(85, 17);
            vendorCityLabel.TabIndex = 63;
            vendorCityLabel.Text = "Vendor City:";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Location = new System.Drawing.Point(59, 239);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(99, 17);
            vendorNameLabel.TabIndex = 67;
            vendorNameLabel.Text = "Vendor Name:";
            // 
            // vendorPhoneNumLabel
            // 
            vendorPhoneNumLabel.AutoSize = true;
            vendorPhoneNumLabel.Location = new System.Drawing.Point(59, 338);
            vendorPhoneNumLabel.Name = "vendorPhoneNumLabel";
            vendorPhoneNumLabel.Size = new System.Drawing.Size(136, 17);
            vendorPhoneNumLabel.TabIndex = 69;
            vendorPhoneNumLabel.Text = "Vendor Phone Num:";
            // 
            // vendorStateLabel
            // 
            vendorStateLabel.AutoSize = true;
            vendorStateLabel.Location = new System.Drawing.Point(59, 371);
            vendorStateLabel.Name = "vendorStateLabel";
            vendorStateLabel.Size = new System.Drawing.Size(95, 17);
            vendorStateLabel.TabIndex = 71;
            vendorStateLabel.Text = "Vendor State:";
            // 
            // vendorZipCodeLabel
            // 
            vendorZipCodeLabel.AutoSize = true;
            vendorZipCodeLabel.Location = new System.Drawing.Point(59, 405);
            vendorZipCodeLabel.Name = "vendorZipCodeLabel";
            vendorZipCodeLabel.Size = new System.Drawing.Size(119, 17);
            vendorZipCodeLabel.TabIndex = 73;
            vendorZipCodeLabel.Text = "Vendor Zip Code:";
            // 
            // btnAddVendorFormCancel
            // 
            this.btnAddVendorFormCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVendorFormCancel.Location = new System.Drawing.Point(246, 504);
            this.btnAddVendorFormCancel.Name = "btnAddVendorFormCancel";
            this.btnAddVendorFormCancel.Size = new System.Drawing.Size(199, 57);
            this.btnAddVendorFormCancel.TabIndex = 7;
            this.btnAddVendorFormCancel.Text = "Cancel";
            this.btnAddVendorFormCancel.UseVisualStyleBackColor = true;
            this.btnAddVendorFormCancel.Click += new System.EventHandler(this.btnAddVendorFormCancel_Click);
            // 
            // btnAddVendorFormSaveChanges
            // 
            this.btnAddVendorFormSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVendorFormSaveChanges.Location = new System.Drawing.Point(12, 504);
            this.btnAddVendorFormSaveChanges.Name = "btnAddVendorFormSaveChanges";
            this.btnAddVendorFormSaveChanges.Size = new System.Drawing.Size(199, 57);
            this.btnAddVendorFormSaveChanges.TabIndex = 6;
            this.btnAddVendorFormSaveChanges.Text = "Save Changes";
            this.btnAddVendorFormSaveChanges.UseVisualStyleBackColor = true;
            this.btnAddVendorFormSaveChanges.Click += new System.EventHandler(this.btnAddVendorFormSaveChanges_Click);
            // 
            // AddVendorFormTitle
            // 
            this.AddVendorFormTitle.BackColor = System.Drawing.SystemColors.Control;
            this.AddVendorFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddVendorFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVendorFormTitle.Location = new System.Drawing.Point(131, 159);
            this.AddVendorFormTitle.Name = "AddVendorFormTitle";
            this.AddVendorFormTitle.ReadOnly = true;
            this.AddVendorFormTitle.Size = new System.Drawing.Size(194, 31);
            this.AddVendorFormTitle.TabIndex = 60;
            this.AddVendorFormTitle.TabStop = false;
            this.AddVendorFormTitle.Text = "Add Vendor";
            this.AddVendorFormTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(MillersLawnService.Vendor);
            // 
            // vendorAddressTextBox
            // 
            this.vendorAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorAddress", true));
            this.vendorAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorAddressTextBox.Location = new System.Drawing.Point(201, 269);
            this.vendorAddressTextBox.Name = "vendorAddressTextBox";
            this.vendorAddressTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorAddressTextBox.TabIndex = 1;
            this.vendorAddressTextBox.TextChanged += new System.EventHandler(this.vendorAddressTextBox_TextChanged);
            // 
            // vendorCityTextBox
            // 
            this.vendorCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorCity", true));
            this.vendorCityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorCityTextBox.Location = new System.Drawing.Point(201, 302);
            this.vendorCityTextBox.Name = "vendorCityTextBox";
            this.vendorCityTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorCityTextBox.TabIndex = 2;
            this.vendorCityTextBox.TextChanged += new System.EventHandler(this.vendorCityTextBox_TextChanged);
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorName", true));
            this.vendorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorNameTextBox.Location = new System.Drawing.Point(201, 236);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorNameTextBox.TabIndex = 0;
            this.vendorNameTextBox.TextChanged += new System.EventHandler(this.vendorNameTextBox_TextChanged);
            // 
            // vendorPhoneNumTextBox
            // 
            this.vendorPhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorPhoneNum", true));
            this.vendorPhoneNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorPhoneNumTextBox.Location = new System.Drawing.Point(201, 335);
            this.vendorPhoneNumTextBox.MaxLength = 10;
            this.vendorPhoneNumTextBox.Name = "vendorPhoneNumTextBox";
            this.vendorPhoneNumTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorPhoneNumTextBox.TabIndex = 3;
            this.vendorPhoneNumTextBox.TextChanged += new System.EventHandler(this.vendorPhoneNumTextBox_TextChanged);
            // 
            // vendorStateComboBox
            // 
            this.vendorStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "VendorState", true));
            this.vendorStateComboBox.DataSource = this.stateBindingSource;
            this.vendorStateComboBox.DisplayMember = "StateCode";
            this.vendorStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendorStateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorStateComboBox.FormattingEnabled = true;
            this.vendorStateComboBox.Location = new System.Drawing.Point(201, 368);
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
            this.vendorZipCodeTextBox.Location = new System.Drawing.Point(201, 402);
            this.vendorZipCodeTextBox.Name = "vendorZipCodeTextBox";
            this.vendorZipCodeTextBox.Size = new System.Drawing.Size(216, 27);
            this.vendorZipCodeTextBox.TabIndex = 5;
            this.vendorZipCodeTextBox.TextChanged += new System.EventHandler(this.vendorZipCodeTextBox_TextChanged);
            // 
            // AddVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 573);
            this.Controls.Add(vendorAddressLabel);
            this.Controls.Add(this.vendorAddressTextBox);
            this.Controls.Add(vendorCityLabel);
            this.Controls.Add(this.vendorCityTextBox);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(vendorPhoneNumLabel);
            this.Controls.Add(this.vendorPhoneNumTextBox);
            this.Controls.Add(vendorStateLabel);
            this.Controls.Add(this.vendorStateComboBox);
            this.Controls.Add(vendorZipCodeLabel);
            this.Controls.Add(this.vendorZipCodeTextBox);
            this.Controls.Add(this.btnAddVendorFormCancel);
            this.Controls.Add(this.btnAddVendorFormSaveChanges);
            this.Controls.Add(this.AddVendorFormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddVendorForm";
            this.Text = "Add Vendor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddVendorFormCancel;
        private System.Windows.Forms.Button btnAddVendorFormSaveChanges;
        private System.Windows.Forms.TextBox AddVendorFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.TextBox vendorAddressTextBox;
        private System.Windows.Forms.TextBox vendorCityTextBox;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox vendorPhoneNumTextBox;
        private System.Windows.Forms.ComboBox vendorStateComboBox;
        private System.Windows.Forms.TextBox vendorZipCodeTextBox;
        private System.Windows.Forms.BindingSource stateBindingSource;
    }
}