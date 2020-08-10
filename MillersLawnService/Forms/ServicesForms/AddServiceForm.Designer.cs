namespace MillersLawnService.Forms.ServicesForms
{
    partial class AddServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServiceForm));
            System.Windows.Forms.Label serviceCostPerHourLabel;
            System.Windows.Forms.Label serviceDescriptionLabel;
            System.Windows.Forms.Label serviceNameLabel;
            this.btnAddServiceFormCancel = new System.Windows.Forms.Button();
            this.btnAddServiceFormSaveChanges = new System.Windows.Forms.Button();
            this.AddServiceFormTitle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serviceCostPerHourTextBox = new System.Windows.Forms.TextBox();
            this.serviceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            serviceCostPerHourLabel = new System.Windows.Forms.Label();
            serviceDescriptionLabel = new System.Windows.Forms.Label();
            serviceNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddServiceFormCancel
            // 
            this.btnAddServiceFormCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServiceFormCancel.Location = new System.Drawing.Point(243, 504);
            this.btnAddServiceFormCancel.Name = "btnAddServiceFormCancel";
            this.btnAddServiceFormCancel.Size = new System.Drawing.Size(199, 57);
            this.btnAddServiceFormCancel.TabIndex = 4;
            this.btnAddServiceFormCancel.Text = "Cancel";
            this.btnAddServiceFormCancel.UseVisualStyleBackColor = true;
            this.btnAddServiceFormCancel.Click += new System.EventHandler(this.btnAddServiceFormCancel_Click);
            // 
            // btnAddServiceFormSaveChanges
            // 
            this.btnAddServiceFormSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServiceFormSaveChanges.Location = new System.Drawing.Point(9, 504);
            this.btnAddServiceFormSaveChanges.Name = "btnAddServiceFormSaveChanges";
            this.btnAddServiceFormSaveChanges.Size = new System.Drawing.Size(199, 57);
            this.btnAddServiceFormSaveChanges.TabIndex = 3;
            this.btnAddServiceFormSaveChanges.Text = "Save Changes";
            this.btnAddServiceFormSaveChanges.UseVisualStyleBackColor = true;
            this.btnAddServiceFormSaveChanges.Click += new System.EventHandler(this.btnAddServiceFormSaveChanges_Click);
            // 
            // AddServiceFormTitle
            // 
            this.AddServiceFormTitle.BackColor = System.Drawing.SystemColors.Control;
            this.AddServiceFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddServiceFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddServiceFormTitle.Location = new System.Drawing.Point(128, 159);
            this.AddServiceFormTitle.Name = "AddServiceFormTitle";
            this.AddServiceFormTitle.ReadOnly = true;
            this.AddServiceFormTitle.Size = new System.Drawing.Size(194, 31);
            this.AddServiceFormTitle.TabIndex = 91;
            this.AddServiceFormTitle.TabStop = false;
            this.AddServiceFormTitle.Text = "Add Service";
            this.AddServiceFormTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // serviceCostPerHourLabel
            // 
            serviceCostPerHourLabel.AutoSize = true;
            serviceCostPerHourLabel.Location = new System.Drawing.Point(25, 461);
            serviceCostPerHourLabel.Name = "serviceCostPerHourLabel";
            serviceCostPerHourLabel.Size = new System.Drawing.Size(152, 17);
            serviceCostPerHourLabel.TabIndex = 92;
            serviceCostPerHourLabel.Text = "Service Cost Per Hour:";
            // 
            // serviceCostPerHourTextBox
            // 
            this.serviceCostPerHourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "ServiceCostPerHour", true));
            this.serviceCostPerHourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCostPerHourTextBox.Location = new System.Drawing.Point(205, 455);
            this.serviceCostPerHourTextBox.Name = "serviceCostPerHourTextBox";
            this.serviceCostPerHourTextBox.Size = new System.Drawing.Size(216, 27);
            this.serviceCostPerHourTextBox.TabIndex = 2;
            this.serviceCostPerHourTextBox.TextChanged += new System.EventHandler(this.serviceCostPerHourTextBox_TextChanged);
            // 
            // serviceDescriptionLabel
            // 
            serviceDescriptionLabel.AutoSize = true;
            serviceDescriptionLabel.Location = new System.Drawing.Point(25, 259);
            serviceDescriptionLabel.Name = "serviceDescriptionLabel";
            serviceDescriptionLabel.Size = new System.Drawing.Size(134, 17);
            serviceDescriptionLabel.TabIndex = 94;
            serviceDescriptionLabel.Text = "Service Description:";
            // 
            // serviceDescriptionTextBox
            // 
            this.serviceDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "ServiceDescription", true));
            this.serviceDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceDescriptionTextBox.Location = new System.Drawing.Point(205, 253);
            this.serviceDescriptionTextBox.Multiline = true;
            this.serviceDescriptionTextBox.Name = "serviceDescriptionTextBox";
            this.serviceDescriptionTextBox.Size = new System.Drawing.Size(216, 196);
            this.serviceDescriptionTextBox.TabIndex = 1;
            this.serviceDescriptionTextBox.TextChanged += new System.EventHandler(this.serviceDescriptionTextBox_TextChanged);
            // 
            // serviceNameLabel
            // 
            serviceNameLabel.AutoSize = true;
            serviceNameLabel.Location = new System.Drawing.Point(25, 226);
            serviceNameLabel.Name = "serviceNameLabel";
            serviceNameLabel.Size = new System.Drawing.Size(100, 17);
            serviceNameLabel.TabIndex = 98;
            serviceNameLabel.Text = "Service Name:";
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceBindingSource, "ServiceName", true));
            this.serviceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameTextBox.Location = new System.Drawing.Point(205, 220);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(216, 27);
            this.serviceNameTextBox.TabIndex = 0;
            this.serviceNameTextBox.TextChanged += new System.EventHandler(this.serviceNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "$";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(MillersLawnService.Service);
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(serviceCostPerHourLabel);
            this.Controls.Add(this.serviceCostPerHourTextBox);
            this.Controls.Add(serviceDescriptionLabel);
            this.Controls.Add(this.serviceDescriptionTextBox);
            this.Controls.Add(serviceNameLabel);
            this.Controls.Add(this.serviceNameTextBox);
            this.Controls.Add(this.btnAddServiceFormCancel);
            this.Controls.Add(this.btnAddServiceFormSaveChanges);
            this.Controls.Add(this.AddServiceFormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddServiceForm";
            this.Text = "Add Service";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddServiceFormCancel;
        private System.Windows.Forms.Button btnAddServiceFormSaveChanges;
        private System.Windows.Forms.TextBox AddServiceFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.TextBox serviceCostPerHourTextBox;
        private System.Windows.Forms.TextBox serviceDescriptionTextBox;
        private System.Windows.Forms.TextBox serviceNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}