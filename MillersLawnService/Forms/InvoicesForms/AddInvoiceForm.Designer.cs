namespace MillersLawnService.Forms.InvoicesForms
{
    partial class AddInvoiceForm
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label customerFNameLabel;
            System.Windows.Forms.Label customerLNameLabel;
            System.Windows.Forms.Label customerPhoneNumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInvoiceForm));
            this.btnAddInvoiceFormCancel = new System.Windows.Forms.Button();
            this.btnAddInvoiceFormSaveChanges = new System.Windows.Forms.Button();
            this.AddInvoiceFormTitle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerIDComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerFNameTextBox = new System.Windows.Forms.TextBox();
            this.customerLNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumTextBox = new System.Windows.Forms.TextBox();
            customerIDLabel = new System.Windows.Forms.Label();
            invoiceDateLabel = new System.Windows.Forms.Label();
            customerFNameLabel = new System.Windows.Forms.Label();
            customerLNameLabel = new System.Windows.Forms.Label();
            customerPhoneNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(24, 289);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(89, 17);
            customerIDLabel.TabIndex = 96;
            customerIDLabel.Text = "Customer ID:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(24, 258);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(90, 17);
            invoiceDateLabel.TabIndex = 92;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // customerFNameLabel
            // 
            customerFNameLabel.AutoSize = true;
            customerFNameLabel.Location = new System.Drawing.Point(24, 327);
            customerFNameLabel.Name = "customerFNameLabel";
            customerFNameLabel.Size = new System.Drawing.Size(144, 17);
            customerFNameLabel.TabIndex = 97;
            customerFNameLabel.Text = "Customer First Name:";
            // 
            // customerLNameLabel
            // 
            customerLNameLabel.AutoSize = true;
            customerLNameLabel.Location = new System.Drawing.Point(24, 360);
            customerLNameLabel.Name = "customerLNameLabel";
            customerLNameLabel.Size = new System.Drawing.Size(144, 17);
            customerLNameLabel.TabIndex = 98;
            customerLNameLabel.Text = "Customer Last Name:";
            // 
            // customerPhoneNumLabel
            // 
            customerPhoneNumLabel.AutoSize = true;
            customerPhoneNumLabel.Location = new System.Drawing.Point(24, 393);
            customerPhoneNumLabel.Name = "customerPhoneNumLabel";
            customerPhoneNumLabel.Size = new System.Drawing.Size(171, 17);
            customerPhoneNumLabel.TabIndex = 99;
            customerPhoneNumLabel.Text = "Customer Phone Number:";
            // 
            // btnAddInvoiceFormCancel
            // 
            this.btnAddInvoiceFormCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoiceFormCancel.Location = new System.Drawing.Point(245, 506);
            this.btnAddInvoiceFormCancel.Name = "btnAddInvoiceFormCancel";
            this.btnAddInvoiceFormCancel.Size = new System.Drawing.Size(199, 57);
            this.btnAddInvoiceFormCancel.TabIndex = 89;
            this.btnAddInvoiceFormCancel.Text = "Cancel";
            this.btnAddInvoiceFormCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddInvoiceFormSaveChanges
            // 
            this.btnAddInvoiceFormSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvoiceFormSaveChanges.Location = new System.Drawing.Point(11, 506);
            this.btnAddInvoiceFormSaveChanges.Name = "btnAddInvoiceFormSaveChanges";
            this.btnAddInvoiceFormSaveChanges.Size = new System.Drawing.Size(199, 57);
            this.btnAddInvoiceFormSaveChanges.TabIndex = 88;
            this.btnAddInvoiceFormSaveChanges.Text = "Save Changes";
            this.btnAddInvoiceFormSaveChanges.UseVisualStyleBackColor = true;
            this.btnAddInvoiceFormSaveChanges.Click += new System.EventHandler(this.btnAddInvoiceFormSaveChanges_Click);
            // 
            // AddInvoiceFormTitle
            // 
            this.AddInvoiceFormTitle.BackColor = System.Drawing.SystemColors.Control;
            this.AddInvoiceFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddInvoiceFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInvoiceFormTitle.Location = new System.Drawing.Point(130, 161);
            this.AddInvoiceFormTitle.Name = "AddInvoiceFormTitle";
            this.AddInvoiceFormTitle.ReadOnly = true;
            this.AddInvoiceFormTitle.Size = new System.Drawing.Size(194, 31);
            this.AddInvoiceFormTitle.TabIndex = 91;
            this.AddInvoiceFormTitle.TabStop = false;
            this.AddInvoiceFormTitle.Text = "Add Invoice";
            this.AddInvoiceFormTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // customerIDComboBox
            // 
            this.customerIDComboBox.DataSource = this.customerBindingSource;
            this.customerIDComboBox.DisplayMember = "CustomerID";
            this.customerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDComboBox.FormattingEnabled = true;
            this.customerIDComboBox.Location = new System.Drawing.Point(209, 283);
            this.customerIDComboBox.Name = "customerIDComboBox";
            this.customerIDComboBox.Size = new System.Drawing.Size(227, 28);
            this.customerIDComboBox.TabIndex = 97;
            this.customerIDComboBox.ValueMember = "CustomerID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MillersLawnService.Customer);
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(209, 250);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(227, 27);
            this.invoiceDateDateTimePicker.TabIndex = 94;
            // 
            // customerFNameTextBox
            // 
            this.customerFNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerFName", true));
            this.customerFNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFNameTextBox.Location = new System.Drawing.Point(209, 321);
            this.customerFNameTextBox.Name = "customerFNameTextBox";
            this.customerFNameTextBox.ReadOnly = true;
            this.customerFNameTextBox.Size = new System.Drawing.Size(227, 27);
            this.customerFNameTextBox.TabIndex = 98;
            // 
            // customerLNameTextBox
            // 
            this.customerLNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerLName", true));
            this.customerLNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLNameTextBox.Location = new System.Drawing.Point(209, 354);
            this.customerLNameTextBox.Name = "customerLNameTextBox";
            this.customerLNameTextBox.ReadOnly = true;
            this.customerLNameTextBox.Size = new System.Drawing.Size(227, 27);
            this.customerLNameTextBox.TabIndex = 99;
            // 
            // customerPhoneNumTextBox
            // 
            this.customerPhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerPhoneNum", true));
            this.customerPhoneNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneNumTextBox.Location = new System.Drawing.Point(209, 387);
            this.customerPhoneNumTextBox.Name = "customerPhoneNumTextBox";
            this.customerPhoneNumTextBox.ReadOnly = true;
            this.customerPhoneNumTextBox.Size = new System.Drawing.Size(227, 27);
            this.customerPhoneNumTextBox.TabIndex = 100;
            // 
            // AddInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 573);
            this.Controls.Add(customerPhoneNumLabel);
            this.Controls.Add(this.customerPhoneNumTextBox);
            this.Controls.Add(customerLNameLabel);
            this.Controls.Add(this.customerLNameTextBox);
            this.Controls.Add(customerFNameLabel);
            this.Controls.Add(this.customerFNameTextBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDComboBox);
            this.Controls.Add(invoiceDateLabel);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(this.btnAddInvoiceFormCancel);
            this.Controls.Add(this.btnAddInvoiceFormSaveChanges);
            this.Controls.Add(this.AddInvoiceFormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddInvoiceForm";
            this.Text = "Add Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddInvoiceFormCancel;
        private System.Windows.Forms.Button btnAddInvoiceFormSaveChanges;
        private System.Windows.Forms.TextBox AddInvoiceFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox customerIDComboBox;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox customerFNameTextBox;
        private System.Windows.Forms.TextBox customerLNameTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumTextBox;
    }
}