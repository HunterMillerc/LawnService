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

        int currentSelectedInvoiceId;

        public InvoiceListForm()
        {
            InitializeComponent();
            invoicesDb = new LawnServiceEntities();
            invoicesDb.Customers.Load();
            invoicesDb.Employees.Load();
            invoicesDb.Invoices.Load();
            invoicesDb.InvoiceLineItems.Load();
            this.invoiceBindingSource.DataSource = invoicesDb.Invoices.Local.ToBindingList();
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            FilterInvoiceLineItemDataGridView();
            PopulateCustomInvoiceDataGridViewColumns();
        }

        private void invoiceDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            FilterInvoiceLineItemDataGridView();
        }

        //Populate invoice line item datagridview based on selected value of invoice
        private void FilterInvoiceLineItemDataGridView()
        {
            //Try catch statement in case user somehow doesn't select a valid invoice containing an ID
            try
            {
                //Get int of current selected invoice id
                currentSelectedInvoiceId = Convert.ToInt32(invoiceDataGridView.CurrentRow.Cells[0].Value);
            }
            catch
            {
                return;
            }
            //Show invoice items list based on the currently selected invoice id
            var invoiceIdFilter = invoicesDb.InvoiceLineItems.Local.ToBindingList().Where(x => x.InvoiceID == currentSelectedInvoiceId);
            this.invoiceLineItemBindingSource.DataSource = invoiceIdFilter.Count() > 0 ? invoiceIdFilter : invoiceIdFilter.ToArray();

            //Generate employee information
            List<int> employeeIdList = new List<int>();

            //Loop through all rows in invoicelineitems datagridview and add those ids to the list
            foreach (DataGridViewRow row in invoiceLineItemDataGridView.Rows)
            {
                employeeIdList.Add(Convert.ToInt32(row.Cells[2].Value.ToString()));
            }

            //Loop through each row and add employee first and last name to their respective columns for each Id in the employeeIdList
            int i = 0;
            foreach (int empId in employeeIdList)
            {
                var firstNameEmp = (from employee in invoicesDb.Employees
                                    where employee.EmployeeID == empId
                                    select employee.EmployeeFName).Single();
                invoiceLineItemDataGridView.Rows[i].Cells[3].Value = firstNameEmp;

                var lastNameEmp = (from employee in invoicesDb.Employees
                                   where employee.EmployeeID == empId
                                   select employee.EmployeeLName).Single();
                invoiceLineItemDataGridView.Rows[i].Cells[4].Value = lastNameEmp;
                i++;
            }
            
        }

        //Populates custom columns shown for invoice datagridview
        private void PopulateCustomInvoiceDataGridViewColumns()
        {
            /*-------------------------------------------------Customer Information-----------------------------------------------------*/
            //Create list containing customerIds
            List<int> custIdList = new List<int>();

            //Loop through all rows in invoiceDataGridView and add those customer Ids to the list
            foreach (DataGridViewRow row in invoiceDataGridView.Rows)
            {
                custIdList.Add(Convert.ToInt32(row.Cells[2].Value.ToString()));
            }

            //Loop through each row and add first and last names to their respective columns along with phone number
            int i = 0;
            foreach (int custId in custIdList)
            {
                var firstNameCust = (from customer in invoicesDb.Customers
                                 where customer.CustomerID == custId
                                 select customer.CustomerFName).Single();
                invoiceDataGridView.Rows[i].Cells[3].Value = firstNameCust;

                var lastNameCust = (from customer in invoicesDb.Customers
                                where customer.CustomerID == custId
                                select customer.CustomerLName).Single();
                invoiceDataGridView.Rows[i].Cells[4].Value = lastNameCust;

                var phoneNumCust = (from customer in invoicesDb.Customers
                                where customer.CustomerID == custId
                                select customer.CustomerPhoneNum).Single();
                invoiceDataGridView.Rows[i].Cells[5].Value = phoneNumCust;
                i++;
            }

            /*-----------------------------------------------Invoice Total---------------------------------------------------------------------*/
            //Create list containing invoice IDs of current view invoice datagridview
            List<int> invIdList = new List<int>();

            //Loop through all rows and add invoice ids to the list
            foreach(DataGridViewRow row in invoiceDataGridView.Rows)
            {
                invIdList.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
            }

            //Loop through each row and obtain invoice total information (good luck?)
            int x = 0;
            foreach(int invId in invIdList)
            {
                foreach(DataGridViewRow row in invoiceLineItemDataGridView.Rows)
                {
                    //TODO: Get correct query to select price of service and display total for each invoice
                }
                
            }
        }
    }
}
