﻿namespace MillersLawnService
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainFrmPicture = new System.Windows.Forms.PictureBox();
            this.txtMainFrmTitle = new System.Windows.Forms.TextBox();
            this.btnMainMnuCustomers = new System.Windows.Forms.Button();
            this.btnMainMnuInvoices = new System.Windows.Forms.Button();
            this.btnMainMnuServices = new System.Windows.Forms.Button();
            this.MainMnuEmployees = new System.Windows.Forms.Button();
            this.btnMainMnuVendors = new System.Windows.Forms.Button();
            this.btnMainMnuPurchaseOrders = new System.Windows.Forms.Button();
            this.btnMainMnuExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrmPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFrmPicture
            // 
            this.mainFrmPicture.Image = ((System.Drawing.Image)(resources.GetObject("mainFrmPicture.Image")));
            this.mainFrmPicture.Location = new System.Drawing.Point(280, 12);
            this.mainFrmPicture.Name = "mainFrmPicture";
            this.mainFrmPicture.Size = new System.Drawing.Size(263, 239);
            this.mainFrmPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainFrmPicture.TabIndex = 0;
            this.mainFrmPicture.TabStop = false;
            // 
            // txtMainFrmTitle
            // 
            this.txtMainFrmTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtMainFrmTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMainFrmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainFrmTitle.Location = new System.Drawing.Point(233, 273);
            this.txtMainFrmTitle.Name = "txtMainFrmTitle";
            this.txtMainFrmTitle.ReadOnly = true;
            this.txtMainFrmTitle.Size = new System.Drawing.Size(375, 42);
            this.txtMainFrmTitle.TabIndex = 1;
            this.txtMainFrmTitle.TabStop = false;
            this.txtMainFrmTitle.Text = "Miller\'s Lawn Service";
            this.txtMainFrmTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMainMnuCustomers
            // 
            this.btnMainMnuCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMnuCustomers.Location = new System.Drawing.Point(22, 339);
            this.btnMainMnuCustomers.Name = "btnMainMnuCustomers";
            this.btnMainMnuCustomers.Size = new System.Drawing.Size(172, 57);
            this.btnMainMnuCustomers.TabIndex = 0;
            this.btnMainMnuCustomers.Text = "Customers";
            this.btnMainMnuCustomers.UseVisualStyleBackColor = true;
            this.btnMainMnuCustomers.Click += new System.EventHandler(this.btnMainMnuCustomers_Click);
            // 
            // btnMainMnuInvoices
            // 
            this.btnMainMnuInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMnuInvoices.Location = new System.Drawing.Point(300, 469);
            this.btnMainMnuInvoices.Name = "btnMainMnuInvoices";
            this.btnMainMnuInvoices.Size = new System.Drawing.Size(243, 57);
            this.btnMainMnuInvoices.TabIndex = 6;
            this.btnMainMnuInvoices.Text = "Invoices";
            this.btnMainMnuInvoices.UseVisualStyleBackColor = true;
            this.btnMainMnuInvoices.Click += new System.EventHandler(this.btnMainMnuInvoices_Click);
            // 
            // btnMainMnuServices
            // 
            this.btnMainMnuServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMnuServices.Location = new System.Drawing.Point(233, 339);
            this.btnMainMnuServices.Name = "btnMainMnuServices";
            this.btnMainMnuServices.Size = new System.Drawing.Size(172, 57);
            this.btnMainMnuServices.TabIndex = 1;
            this.btnMainMnuServices.Text = "Services";
            this.btnMainMnuServices.UseVisualStyleBackColor = true;
            this.btnMainMnuServices.Click += new System.EventHandler(this.btnMainMnuServices_Click);
            // 
            // MainMnuEmployees
            // 
            this.MainMnuEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMnuEmployees.Location = new System.Drawing.Point(445, 339);
            this.MainMnuEmployees.Name = "MainMnuEmployees";
            this.MainMnuEmployees.Size = new System.Drawing.Size(172, 57);
            this.MainMnuEmployees.TabIndex = 2;
            this.MainMnuEmployees.Text = "Employees";
            this.MainMnuEmployees.UseVisualStyleBackColor = true;
            this.MainMnuEmployees.Click += new System.EventHandler(this.MainMnuEmployees_Click);
            // 
            // btnMainMnuVendors
            // 
            this.btnMainMnuVendors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMnuVendors.Location = new System.Drawing.Point(647, 339);
            this.btnMainMnuVendors.Name = "btnMainMnuVendors";
            this.btnMainMnuVendors.Size = new System.Drawing.Size(172, 57);
            this.btnMainMnuVendors.TabIndex = 3;
            this.btnMainMnuVendors.Text = "Vendors";
            this.btnMainMnuVendors.UseVisualStyleBackColor = true;
            this.btnMainMnuVendors.Click += new System.EventHandler(this.btnMainMnuVendors_Click);
            // 
            // btnMainMnuPurchaseOrders
            // 
            this.btnMainMnuPurchaseOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMnuPurchaseOrders.Location = new System.Drawing.Point(66, 551);
            this.btnMainMnuPurchaseOrders.Name = "btnMainMnuPurchaseOrders";
            this.btnMainMnuPurchaseOrders.Size = new System.Drawing.Size(220, 57);
            this.btnMainMnuPurchaseOrders.TabIndex = 4;
            this.btnMainMnuPurchaseOrders.Text = "Purchase Orders";
            this.btnMainMnuPurchaseOrders.UseVisualStyleBackColor = true;
            this.btnMainMnuPurchaseOrders.Visible = false;
            this.btnMainMnuPurchaseOrders.Click += new System.EventHandler(this.btnMainMnuPurchaseOrders_Click);
            // 
            // btnMainMnuExit
            // 
            this.btnMainMnuExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMnuExit.Location = new System.Drawing.Point(647, 596);
            this.btnMainMnuExit.Name = "btnMainMnuExit";
            this.btnMainMnuExit.Size = new System.Drawing.Size(172, 57);
            this.btnMainMnuExit.TabIndex = 8;
            this.btnMainMnuExit.Text = "&Exit";
            this.btnMainMnuExit.UseVisualStyleBackColor = true;
            this.btnMainMnuExit.Click += new System.EventHandler(this.btnMainMnuExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 665);
            this.Controls.Add(this.btnMainMnuExit);
            this.Controls.Add(this.btnMainMnuPurchaseOrders);
            this.Controls.Add(this.btnMainMnuVendors);
            this.Controls.Add(this.MainMnuEmployees);
            this.Controls.Add(this.btnMainMnuServices);
            this.Controls.Add(this.btnMainMnuInvoices);
            this.Controls.Add(this.btnMainMnuCustomers);
            this.Controls.Add(this.txtMainFrmTitle);
            this.Controls.Add(this.mainFrmPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Miller\'s Lawn Service";
            ((System.ComponentModel.ISupportInitialize)(this.mainFrmPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainFrmPicture;
        private System.Windows.Forms.TextBox txtMainFrmTitle;
        private System.Windows.Forms.Button btnMainMnuCustomers;
        private System.Windows.Forms.Button btnMainMnuInvoices;
        private System.Windows.Forms.Button btnMainMnuServices;
        private System.Windows.Forms.Button MainMnuEmployees;
        private System.Windows.Forms.Button btnMainMnuVendors;
        private System.Windows.Forms.Button btnMainMnuPurchaseOrders;
        private System.Windows.Forms.Button btnMainMnuExit;
    }
}

