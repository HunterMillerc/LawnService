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
    public partial class InvoiceListForm : Form
    {
        LawnServiceEntities invoicesDb;


        public InvoiceListForm()
        {
            InitializeComponent();
            invoicesDb = new LawnServiceEntities();
            invoicesDb.Customers.Load();
            invoicesDb.Employees.Load();
            invoicesDb.Invoices.Load();
            invoicesDb.InvoiceLineItems.Load();
            this.invoiceBindingSource.DataSource = invoicesDb.Invoices.Local.ToBindingList();
            this.invoiceBindingSource.DataSource = invoicesDb.InvoiceLineItems.Local.ToBindingList();
        }
    }
}
