using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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

        Object originalServiceIdCboData;

        public InvoiceListForm()
        {
            InitializeComponent();
            invoicesDb = new LawnServiceEntities();
            invoicesDb.Customers.Load();
            invoicesDb.Employees.Load();
            invoicesDb.Invoices.Load();
            invoicesDb.InvoiceLineItems.Load();
            invoicesDb.Services.Load();
            this.invoiceBindingSource.DataSource = invoicesDb.Invoices.Local.ToBindingList();
            this.customerBindingSource.DataSource = invoicesDb.Customers.Local.ToList();
            this.employeeBindingSource.DataSource = invoicesDb.Employees.Local.ToList();
            this.serviceBindingSource.DataSource = invoicesDb.Services.Local.ToList();

            //get original data source for service IDs combobox. Must use this when saving invoice edits so that combobox displays correct service id when selecting new invoice line items
            originalServiceIdCboData = serviceIDComboBox.DataSource;
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            FilterInvoiceLineItemDataGridView();
            PopulateCustomInvoiceDataGridViewColumns();
            selectedInvoiceIDTextBox.Text = currentSelectedInvoiceId.ToString();

            //Populate cboFilterByName combobox for list of current customer names in database
            var lastNames = (from customer in invoicesDb.Customers
                             select customer.CustomerLName).Distinct();
            cboCustNameFilter.Items.AddRange(lastNames.ToArray());
            EnableEditDeleteBtnsInvLineItems();
            serviceIDTextBoxHidden.Visible = false;
        }

        private void invoiceDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            FilterInvoiceLineItemDataGridView();
            selectedInvoiceIDTextBox.Text = currentSelectedInvoiceId.ToString();
            EnableEditDeleteBtnsInvLineItems();
        }

        //Disable edit invoicelineitem and delete invoicelineitem buttons if there are no invoice line items on the selected invoice
        private void EnableEditDeleteBtnsInvLineItems()
        {
            if(invoiceIDTextBox1.Text == "")
            {
                btnEditInvLineItem.Enabled = false;
                btnDeleteInvLineItem.Enabled = false;
            }
            else
            {
                btnEditInvLineItem.Enabled = true;
                btnDeleteInvLineItem.Enabled = true;
            }
        }

        //Populate invoice line item datagridview custom columns based on selected value of invoice
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

            /*----------------------------------------------Employee Info---------------------------------*/
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

            /*----------------------------------------------Invoice Line Item Cost Info------------------------------*/
            //Populate invoice line item cost for each row in invoice line item datagridview
            int y = 0;
            foreach (DataGridViewRow row in invoiceLineItemDataGridView.Rows)
            {
                int serviceId = Convert.ToInt32(row.Cells[1].Value.ToString());

                var lineItemCostQuery = (from invLineItem in invoicesDb.InvoiceLineItems
                                         join service in invoicesDb.Services
                                         on invLineItem.ServiceID equals service.ServiceID
                                         where invLineItem.ServiceID == serviceId
                                         select service.ServiceCostPerHour * invLineItem.ServiceNumOfHours).Single();

                invoiceLineItemDataGridView.Rows[y].Cells[6].Value = lineItemCostQuery;
                y++;
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

            //Loop through all rows in datagridview of Invoices and add invoice ids to the list
            foreach(DataGridViewRow row in invoiceDataGridView.Rows)
            {
                invIdList.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
            }

            //Loop through each row and obtain invoice total information. Value of invoice total will be displayed in last column then
            int x = 0;
            foreach(int invId in invIdList)
            {
                try
                {
                    var totalAmtInvSum = (from invLineItem in invoicesDb.InvoiceLineItems
                                          join service in invoicesDb.Services
                                          on invLineItem.ServiceID equals service.ServiceID
                                          where invLineItem.InvoiceID == invId
                                          select service.ServiceCostPerHour * invLineItem.ServiceNumOfHours).Sum();
                    invoiceDataGridView.Rows[x].Cells[6].Value = totalAmtInvSum;
                    x++;
                }
                catch
                {
                    return;
                }
                
            }
        }

        private void btnFilterByCustName_Click(object sender, EventArgs e)
        {
            var filteredData = invoicesDb.Invoices.Local.ToBindingList().Where(x => x.tblCustomer.CustomerLName == cboCustNameFilter.Text);
            this.invoiceBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
            PopulateCustomInvoiceDataGridViewColumns();
        }

        private void btnShowAllInvoices_Click(object sender, EventArgs e)
        {
            this.invoiceBindingSource.DataSource = invoicesDb.Invoices.Local.ToBindingList();
            cboCustNameFilter.SelectedIndex = -1;
            PopulateCustomInvoiceDataGridViewColumns();
        }

        private void btnInvoiceEdit_Click(object sender, EventArgs e)
        {
            EnableInvoiceEdit();
        }

        private void EnableInvoiceEdit()
        {
            invoiceDateDateTimePicker.Enabled = !invoiceDateDateTimePicker.Enabled;
            customerIDComboBox.Enabled = !customerIDComboBox.Enabled;
            btnInvoiceAdd.Enabled = !btnInvoiceAdd.Enabled;
            btnDeleteInvoice.Enabled = !btnDeleteInvoice.Enabled;
            btnSaveInvoice.Visible = !btnSaveInvoice.Visible;
            btnInvoiceEdit.Enabled = !btnInvoiceEdit.Enabled;
            btnAddInvLineItem.Enabled = !btnAddInvLineItem.Enabled;
            btnEditInvLineItem.Enabled = !btnEditInvLineItem.Enabled;
            btnDeleteInvLineItem.Enabled = !btnDeleteInvLineItem.Enabled;
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if(invoiceIDTextBox.Text == "")
            {
                MessageBox.Show("No invoice selected. Please select an invoice to edit.", "Edit Error");
            }
            else
            {
                int currentInv = Convert.ToInt32(invoiceIDTextBox.Text);
                var editedInv = (from invoice in invoicesDb.Invoices
                                 where invoice.InvoiceID == currentInv
                                 select invoice).Single();

                editedInv.InvoiceDate = invoiceDateDateTimePicker.Value;
                editedInv.CustomerID = Convert.ToInt32(customerIDComboBox.SelectedValue);
                invoicesDb.SaveChanges();
                EnableInvoiceEdit();
                PopulateCustomInvoiceDataGridViewColumns();
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if(invoiceIDTextBox.Text == "")
            {
                MessageBox.Show("No invoice selected. Please select an invoice to delete.", "Delete Error");
            }
            else
            {
                int currentInv = Convert.ToInt32(invoiceIDTextBox.Text);
                var editedInv = (from invoice in invoicesDb.Invoices
                                 where invoice.InvoiceID == currentInv
                                 select invoice).Single();

                DialogResult result = MessageBox.Show($"Delete Invoice ID: {currentInv.ToString()}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        invoicesDb.Invoices.Remove(editedInv);
                        invoicesDb.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        this.Close();
                        if(invoicesDb.Entry(editedInv).State == EntityState.Detached)
                        {
                            MessageBox.Show("Another user has deleted that invoice.", "Concurrency Error");
                        }
                        else
                        {
                            MessageBox.Show("Another user has updated that invoice.", "Concurrency Error");
                        }
                    }
                    catch (DbUpdateException)
                    {
                        this.Close();
                        MessageBox.Show("Unable to delete invoice. Unknown Error Occurred.", "Invoice Not Deleted");
                        InvoiceListForm newForm = new InvoiceListForm();
                        newForm.Show();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnInvoiceAdd_Click(object sender, EventArgs e)
        {
            AddInvoiceForm addInvoiceForm = new AddInvoiceForm();
            addInvoiceForm.Show();
            this.Close();
        }

        private void btnInvoicesExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteInvLineItem_Click(object sender, EventArgs e)
        {
            int invLineItemInvNum = Convert.ToInt32(invoiceIDTextBox1.Text);
            int invLineItemServiceNum = Convert.ToInt32(serviceIDComboBox.Text);

            var deleteInvLineItem = (from invLineItem in invoicesDb.InvoiceLineItems
                                          where invLineItem.InvoiceID == invLineItemInvNum && invLineItem.ServiceID == invLineItemServiceNum
                                          select invLineItem).Single();

            var deleteInvLineItemServiceName = (from invLineItem in invoicesDb.InvoiceLineItems
                                                where invLineItem.InvoiceID == invLineItemInvNum && invLineItem.ServiceID == invLineItemServiceNum
                                                select invLineItem.tblService.ServiceName).Single().ToString();

            var deleteInvLineItemEmpName = (from invLineItem in invoicesDb.InvoiceLineItems
                                            where invLineItem.InvoiceID == invLineItemInvNum && invLineItem.ServiceID == invLineItemServiceNum
                                            select invLineItem.tblEmployee.EmployeeFName + " " + invLineItem.tblEmployee.EmployeeLName).Single().ToString();

            DialogResult result = MessageBox.Show($"Delete Line Item where Invoice ID = {invLineItemInvNum} and Service ID = {invLineItemServiceNum} (Service Name: {deleteInvLineItemServiceName} | Service performed by: {deleteInvLineItemEmpName})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    invoicesDb.InvoiceLineItems.Remove(deleteInvLineItem);
                    invoicesDb.SaveChanges();
                    FilterInvoiceLineItemDataGridView();
                }
                catch (DbUpdateConcurrencyException)
                {
                    this.Close();
                    if (invoicesDb.Entry(deleteInvLineItem).State == EntityState.Detached)
                    {
                        MessageBox.Show("Another user has deleted that invoice line item.", "Concurrency Error");
                    }
                    else
                    {
                        MessageBox.Show("Another user has updated that invoice line item.", "Concurrency Error");
                    }
                }
                catch (DbUpdateException)
                {
                    this.Close();
                    MessageBox.Show("Unable to delete invoice line item. Unknown Error Occurred.", "Invoice Line Item Not Deleted");
                    InvoiceListForm newForm = new InvoiceListForm();
                    newForm.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnEditInvLineItem_Click(object sender, EventArgs e)
        {
            EnableEditInvLineItems();
        }

        private void EnableEditInvLineItems()
        {
            //Data source for services combobox (must not duplicate services within each invoice)
            var servicesUsedInInvoice = (from invLineItem in invoicesDb.InvoiceLineItems
                                         where invLineItem.InvoiceID == currentSelectedInvoiceId
                                         select invLineItem.ServiceID).ToList();
            var servicesNotUsedInInvoice = invoicesDb.Services.Where(s => !servicesUsedInInvoice.Contains(s.ServiceID)).ToList();

            btnAddInvLineItem.Enabled = !btnAddInvLineItem.Enabled;
            btnEditInvLineItem.Enabled = !btnEditInvLineItem.Enabled;
            btnDeleteInvLineItem.Enabled = !btnDeleteInvLineItem.Enabled;
            btnInvLineItemSave.Visible = !btnInvLineItemSave.Visible;
            serviceIDComboBox.Enabled = !serviceIDComboBox.Enabled;
            serviceIDComboBox.DataSource = servicesNotUsedInInvoice;
            employeeIDComboBox.Enabled = !employeeIDComboBox.Enabled;
            serviceNumOfHoursNumericUpDown.Enabled = !serviceNumOfHoursNumericUpDown.Enabled;
            btnInvLineItemCancel.Visible = !btnInvLineItemCancel.Visible;
        }

        private void DisableEditInvLineItems()
        {
            btnAddInvLineItem.Enabled = !btnAddInvLineItem.Enabled;
            btnEditInvLineItem.Enabled = !btnEditInvLineItem.Enabled;
            btnDeleteInvLineItem.Enabled = !btnDeleteInvLineItem.Enabled;
            btnInvLineItemSave.Visible = !btnInvLineItemSave.Visible;
            serviceIDComboBox.Enabled = !serviceIDComboBox.Enabled;
            serviceIDComboBox.DataSource = originalServiceIdCboData;
            employeeIDComboBox.Enabled = !employeeIDComboBox.Enabled;
            serviceNumOfHoursNumericUpDown.Enabled = !serviceNumOfHoursNumericUpDown.Enabled;
            btnInvLineItemCancel.Visible = !btnInvLineItemCancel.Visible;
        }

        private void serviceIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCorrectServiceInfo();
        }

        private void btnInvLineItemSave_Click(object sender, EventArgs e)
        {
            int invLineItemInvNum = Convert.ToInt32(invoiceIDTextBox1.Text);
            int invLineItemServiceNum = Convert.ToInt32(serviceIDTextBoxHidden.Text);

            var editedInvLineItem = (from invLineItem in invoicesDb.InvoiceLineItems
                                     where invLineItem.InvoiceID == invLineItemInvNum && invLineItem.ServiceID == invLineItemServiceNum
                                     select invLineItem).Single();

            try
            {
                invoicesDb.InvoiceLineItems.Remove(editedInvLineItem);
                invoicesDb.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            InvoiceLineItem newInvLine = new InvoiceLineItem();
            newInvLine.InvoiceID = invLineItemInvNum;
            newInvLine.ServiceID = Convert.ToInt32(serviceIDComboBox.Text);
            newInvLine.EmployeeID = Convert.ToInt32(employeeIDComboBox.Text);
            newInvLine.ServiceNumOfHours = Convert.ToInt32(serviceNumOfHoursNumericUpDown.Value);
            invoicesDb.InvoiceLineItems.Add(newInvLine);
            invoicesDb.SaveChanges();
            DisableEditInvLineItems();
            FilterInvoiceLineItemDataGridView();
        }

        private void btnInvLineItemCancel_Click(object sender, EventArgs e)
        {
            DisableEditInvLineItems();
            ShowCorrectServiceInfo();
        }

        private void ShowCorrectServiceInfo()
        {
            //Show correct information if selected service changed
            int serviceId = Convert.ToInt32(serviceIDComboBox.Text);


            var serviceName = (from service in invoicesDb.Services
                               where service.ServiceID == serviceId
                               select service.ServiceName).Single().ToString();

            var serviceCostPerHour = (from service in invoicesDb.Services
                                      where service.ServiceID == serviceId
                                      select service.ServiceCostPerHour).Single().ToString();

            serviceNameTextBox.Text = serviceName;
            serviceCostPerHourTextBox.Text = serviceCostPerHour;
        }
    }
}
