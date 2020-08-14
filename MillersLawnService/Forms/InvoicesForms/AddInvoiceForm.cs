using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillersLawnService.Forms.InvoicesForms
{
    public partial class AddInvoiceForm : Form
    {
        LawnServiceEntities addInvDb;

        private Invoice invoice;
        public AddInvoiceForm()
        {
            InitializeComponent();
            addInvDb = new LawnServiceEntities();
            addInvDb.Customers.Load();
            this.customerBindingSource.DataSource = addInvDb.Customers.Local.ToList();
            invoice = new Invoice();
        }

        private void btnAddInvoiceFormSaveChanges_Click(object sender, EventArgs e)
        {
            invoice.InvoiceDate = invoiceDateDateTimePicker.Value;
            invoice.CustomerID = Convert.ToInt32(customerIDComboBox.SelectedValue);
            addInvDb.Invoices.Add(invoice);
            addInvDb.SaveChanges();
            this.Close();
            MessageBox.Show("Invoice added successfully.", "Invoice Added");
            InvoiceListForm invoiceListForm = new InvoiceListForm();
            invoiceListForm.Show();
        }

        private void btnAddInvoiceFormCancel_Click(object sender, EventArgs e)
        {
            InvoiceListForm newForm = new InvoiceListForm();
            newForm.Show();
            this.Close();
        }
    }
}
