using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MillersLawnService.Forms.CustomersForms;
using MillersLawnService.Forms.EmployeesForms;
using MillersLawnService.Forms.InvoiceLineItemsForms;
using MillersLawnService.Forms.InvoicesForms;
using MillersLawnService.Forms.POForms;
using MillersLawnService.Forms.POLineItemsForms;
using MillersLawnService.Forms.ServicesForms;
using MillersLawnService.Forms.VendorsForms;

namespace MillersLawnService
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMainMnuCustomers_Click(object sender, EventArgs e)
        {
            CustomersListForm customersListForm = new CustomersListForm();
            customersListForm.Show();
        }

        private void btnMainMnuServices_Click(object sender, EventArgs e)
        {
            ServicesListForm servicesListForm = new ServicesListForm();
            servicesListForm.Show();
        }

        private void MainMnuEmployees_Click(object sender, EventArgs e)
        {
            EmployeesListForm employeesListForm = new EmployeesListForm();
            employeesListForm.Show();
        }

        private void btnMainMnuVendors_Click(object sender, EventArgs e)
        {
            VendorsListForm vendorsListForm = new VendorsListForm();
            vendorsListForm.Show();
        }

        private void btnMainMnuPurchaseOrders_Click(object sender, EventArgs e)
        {
            POListForm pOListForm = new POListForm();
            pOListForm.Show();
        }

        private void btnMainMnuInvoices_Click(object sender, EventArgs e)
        {
            InvoiceListForm invoiceListForm = new InvoiceListForm();
            invoiceListForm.Show();
        }

        private void btnMainMnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
