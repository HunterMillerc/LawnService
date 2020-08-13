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

        int currentSelectedInvLineItemDetailId;

        public InvoiceListForm()
        {
            InitializeComponent();
            invoicesDb = new LawnServiceEntities();
            invoicesDb.Customers.Load();
            invoicesDb.Employees.Load();
            invoicesDb.Invoices.Load();
            invoicesDb.InvoiceLineItems.Load();
            this.invoiceBindingSource.DataSource = invoicesDb.Invoices.Local.ToBindingList();
            this.customerBindingSource.DataSource = invoicesDb.Customers.Local.ToList();
            this.employeeBindingSource.DataSource = invoicesDb.Employees.Local.ToList();

            //add items to service id combobox
            var serviceIds = (from service in invoicesDb.Services
                              select service.ServiceID);

            //Generate list from service ids to make it into string
            List<string> serviceIdList = new List<string>();
            foreach(int id in serviceIds)
            {
                serviceIdList.Add(id.ToString());
            }

            serviceIDComboBox.Items.AddRange(serviceIdList.ToArray());
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
            //invLineItemDetailIDTextBox.Visible = false;
            showCurrentInvItemDetailIdInTextBox();
        }

        private void invoiceDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            FilterInvoiceLineItemDataGridView();
            selectedInvoiceIDTextBox.Text = currentSelectedInvoiceId.ToString();
            EnableEditDeleteBtnsInvLineItems();
            ShowCorrectServiceInfo();
            showCurrentInvItemDetailIdInTextBox();
            invoiceIDTextBox1.Text = currentSelectedInvoiceId.ToString();
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
                currentSelectedInvoiceId = Convert.ToInt32(invoiceIDTextBox.Text);
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
                employeeIdList.Add(Convert.ToInt32(row.Cells[3].Value.ToString()));
            }

            //Loop through each row and add employee first and last name to their respective columns for each Id in the employeeIdList
            int i = 0;
            foreach (int empId in employeeIdList)
            {
                var firstNameEmp = (from employee in invoicesDb.Employees
                                    where employee.EmployeeID == empId
                                    select employee.EmployeeFName).Single();
                invoiceLineItemDataGridView.Rows[i].Cells[4].Value = firstNameEmp;

                var lastNameEmp = (from employee in invoicesDb.Employees
                                   where employee.EmployeeID == empId
                                   select employee.EmployeeLName).Single();
                invoiceLineItemDataGridView.Rows[i].Cells[5].Value = lastNameEmp;
                i++;
            }

            /*----------------------------------------------Invoice Line Item Cost Info------------------------------*/
            //Populate invoice line item cost for each row in invoice line item datagridview
            int y = 0;
            foreach (DataGridViewRow row in invoiceLineItemDataGridView.Rows)
            {
                int lineItemDetailId = Convert.ToInt32(row.Cells[0].Value.ToString());

                var lineItemCostQuery = (from invLineItem in invoicesDb.InvoiceLineItems
                                         join service in invoicesDb.Services
                                         on invLineItem.ServiceID equals service.ServiceID
                                         where invLineItem.InvLineItemDetailID == lineItemDetailId
                                         select service.ServiceCostPerHour * invLineItem.ServiceNumOfHours).SingleOrDefault();

                invoiceLineItemDataGridView.Rows[y].Cells[7].Value = lineItemCostQuery;
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
            List<int> invList = new List<int>();

            //Loop through all rows in datagridview of Invoices and add invoice ids to the list
            foreach(DataGridViewRow row in invoiceDataGridView.Rows)
            {
                invList.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
            }

            //Loop through each row and obtain invoice total information. Value of invoice total will be displayed in last column then
            if(invList.Count != 0)
            {
                int x = 0;
                foreach (int invId in invList)
                {
                    var totalAmtInInvoice = (from invLineItem in invoicesDb.InvoiceLineItems
                                             join service in invoicesDb.Services
                                             on invLineItem.ServiceID equals service.ServiceID
                                             where invLineItem.InvoiceID == invId
                                             select invLineItem.ServiceNumOfHours * service.ServiceCostPerHour).DefaultIfEmpty(0).Sum();

                    invoiceDataGridView.Rows[x].Cells[6].Value = Convert.ToDecimal(totalAmtInInvoice);
                    x++;

                }
            }
        }

        private void btnFilterByCustName_Click(object sender, EventArgs e)
        {
            var filteredData = invoicesDb.Invoices.Local.ToBindingList().Where(x => x.tblCustomer.CustomerLName == cboCustNameFilter.Text);
            this.invoiceBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
            PopulateCustomInvoiceDataGridViewColumns();
            FilterInvoiceLineItemDataGridView();
        }

        private void btnShowAllInvoices_Click(object sender, EventArgs e)
        {
            this.invoiceBindingSource.DataSource = invoicesDb.Invoices.Local.ToBindingList();
            cboCustNameFilter.SelectedIndex = -1;
            PopulateCustomInvoiceDataGridViewColumns();
            FilterInvoiceLineItemDataGridView();
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
            int invLineItemDetailIdNum = Convert.ToInt32(textBox10.Text);

            var deleteInvLineItem = (from invLineItem in invoicesDb.InvoiceLineItems
                                     where invLineItem.InvLineItemDetailID == invLineItemDetailIdNum
                                     select invLineItem).Single();

            var deleteInvLineItemServiceName = (from invLineItem in invoicesDb.InvoiceLineItems
                                                where invLineItem.InvLineItemDetailID == invLineItemDetailIdNum
                                                select invLineItem.tblService.ServiceName).Single().ToString();

            var deleteInvLineItemEmpName = (from invLineItem in invoicesDb.InvoiceLineItems
                                            where invLineItem.InvLineItemDetailID == invLineItemDetailIdNum
                                            select invLineItem.tblEmployee.EmployeeFName + " " + invLineItem.tblEmployee.EmployeeLName).Single().ToString();

            DialogResult result = MessageBox.Show($"Delete Line Item where Invoice Line Item Detail ID = {invLineItemDetailIdNum} (Service Name: {deleteInvLineItemServiceName} | Service performed by: {deleteInvLineItemEmpName})?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

            btnAddInvLineItem.Enabled = !btnAddInvLineItem.Enabled;
            btnEditInvLineItem.Enabled = !btnEditInvLineItem.Enabled;
            btnDeleteInvLineItem.Enabled = !btnDeleteInvLineItem.Enabled;
            btnInvLineItemSave.Visible = !btnInvLineItemSave.Visible;
            serviceIDComboBox.Enabled = !serviceIDComboBox.Enabled;
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
            employeeIDComboBox.Enabled = !employeeIDComboBox.Enabled;
            serviceNumOfHoursNumericUpDown.Enabled = !serviceNumOfHoursNumericUpDown.Enabled;
            btnInvLineItemCancel.Visible = !btnInvLineItemCancel.Visible;
        }

        private void EnableAddInvLineItems()
        {
            btnAddInvLineItem.Enabled = !btnAddInvLineItem.Enabled;
            btnEditInvLineItem.Enabled = !btnEditInvLineItem.Enabled;
            btnDeleteInvLineItem.Enabled = !btnDeleteInvLineItem.Enabled;
            btnAddInvLineItemSave.Visible = !btnAddInvLineItemSave.Visible;
            serviceIDComboBox.Enabled = !serviceIDComboBox.Enabled;
            employeeIDComboBox.Enabled = !employeeIDComboBox.Enabled;
            serviceNumOfHoursNumericUpDown.Enabled = !serviceNumOfHoursNumericUpDown.Enabled;
            btnInvLineItemCancel.Visible = !btnInvLineItemCancel.Visible;
        }

        private void serviceIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Show correct information if selected service changed
            int serviceId;
            try
            {
                serviceId = Convert.ToInt32(serviceIDComboBox.Text);
            }
            catch
            {
                servNameTextBox.Text = "";
                serviceCostTextBox.Text = "";
                return;
            }


            var serviceName = (from service in invoicesDb.Services
                               where service.ServiceID == serviceId
                               select service.ServiceName).Single();

            var serviceCostPerHour = (from service in invoicesDb.Services
                                      where service.ServiceID == serviceId
                                      select service.ServiceCostPerHour).Single();

            servNameTextBox.Text = serviceName;
            serviceCostTextBox.Text = serviceCostPerHour.ToString();
            return;
        }

        private void btnInvLineItemSave_Click(object sender, EventArgs e)
        {

            int currentInvLineItemDetailId = currentSelectedInvLineItemDetailId;

            var editedInvLineItem = (from invLineItem in invoicesDb.InvoiceLineItems
                                     where invLineItem.InvLineItemDetailID == currentInvLineItemDetailId
                                     select invLineItem).Single();

            editedInvLineItem.ServiceID = Convert.ToInt32(invoiceLineItemDataGridView.CurrentRow.Cells[2].Value);
            editedInvLineItem.InvoiceID = currentSelectedInvoiceId;
            editedInvLineItem.EmployeeID = Convert.ToInt32(employeeIDComboBox.Text);
            invoicesDb.SaveChanges();

            DisableEditInvLineItems();

            //Reload database to show new info
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
            PopulateCustomInvoiceDataGridViewColumns();
            FilterInvoiceLineItemDataGridView();
        }

        private void btnInvLineItemCancel_Click(object sender, EventArgs e)
        {
            btnAddInvLineItem.Enabled = true;
            btnEditInvLineItem.Enabled = true;
            btnDeleteInvLineItem.Enabled = true;
            btnInvLineItemSave.Visible = false; ;
            serviceIDComboBox.Enabled = false;
            employeeIDComboBox.Enabled = false;
            serviceNumOfHoursNumericUpDown.Enabled = false;
            btnInvLineItemCancel.Visible = false;
            ShowCorrectServiceInfo();
            btnInvLineItemSave.Visible = false;
            btnAddInvLineItemSave.Visible = false;
        }

        private void ShowCorrectServiceInfo()
        {
            //Show correct information if selected service changed
            int lineItemDetailId;
            try
            {
                lineItemDetailId = Convert.ToInt32(textBox10.Text);
            }
            catch
            {
                servNameTextBox.Text = "";
                serviceCostTextBox.Text = "";
                return;
            }

            try
            {
                var serviceName = (from service in invoicesDb.Services
                                   join invLineItem in invoicesDb.InvoiceLineItems
                                   on service.ServiceID equals invLineItem.ServiceID
                                   where invLineItem.InvLineItemDetailID == lineItemDetailId
                                   select service.ServiceName).Single();

                var serviceCostPerHour = (from service in invoicesDb.Services
                                          join invLineItem in invoicesDb.InvoiceLineItems
                                          on service.ServiceID equals invLineItem.ServiceID
                                          where invLineItem.InvLineItemDetailID == lineItemDetailId
                                          select service.ServiceCostPerHour).Single();

                var serviceIdNum = (from service in invoicesDb.Services
                                   join invLineItem in invoicesDb.InvoiceLineItems
                                   on service.ServiceID equals invLineItem.ServiceID
                                   where invLineItem.InvLineItemDetailID == lineItemDetailId
                                   select service.ServiceID).Single();


                serviceIDComboBox.Text = serviceIdNum.ToString();
                servNameTextBox.Text = serviceName;
                serviceCostTextBox.Text = serviceCostPerHour.ToString();
            }
            catch
            {
                servNameTextBox.Text = "";
                serviceCostTextBox.Text = "";
                return;
            }

        }

        private void employeeIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int empId;
            try
            {
                empId = Convert.ToInt32(employeeIDComboBox.Text);
            }
            catch
            {
                empFirstNameTextBox.Text = "";
                empLastNameTextBox.Text = "";
                return;
            }

            try
            {
                var empFirstName = (from employee in invoicesDb.Employees
                                    where employee.EmployeeID == empId
                                    select employee.EmployeeFName).Single();

                var empLastName = (from employee in invoicesDb.Employees
                                   where employee.EmployeeID == empId
                                   select employee.EmployeeLName).Single();

                empFirstNameTextBox.Text = empFirstName;
                empLastNameTextBox.Text = empLastName;
            }
            catch
            {
                empFirstNameTextBox.Text = "";
                empLastNameTextBox.Text = "";
            }

        }

        private void btnAddInvLineItem_Click(object sender, EventArgs e)
        {
            EnableAddInvLineItems();
        }

        private void showCurrentInvItemDetailIdInTextBox()
        {
            if(invoiceLineItemDataGridView.Rows.Count < 1)
            {
                textBox10.Text = "";
            }
            else
            {
                textBox10.Text = invoiceLineItemDataGridView.CurrentRow.Cells[0].Value.ToString();
                currentSelectedInvLineItemDetailId = Convert.ToInt32(textBox10.Text);
            }
            
        }

        private void invoiceLineItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invoiceLineItemDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            showCurrentInvItemDetailIdInTextBox();
            ShowCorrectServiceInfo();
        }

        private void btnAddInvLineItemSave_Click(object sender, EventArgs e)
        {
            InvoiceLineItem newItem = new InvoiceLineItem();
            newItem.ServiceID = Convert.ToInt32(serviceIDComboBox.Text);
            newItem.EmployeeID = Convert.ToInt32(employeeIDComboBox.Text);
            newItem.ServiceNumOfHours = Convert.ToInt32(serviceNumOfHoursNumericUpDown.Value);
            newItem.InvoiceID = Convert.ToInt32(invoiceIDTextBox1.Text);

            invoicesDb.InvoiceLineItems.Add(newItem);
            invoicesDb.SaveChanges();

            EnableAddInvLineItems();

            //Reload database to show new info
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
            PopulateCustomInvoiceDataGridViewColumns();
            FilterInvoiceLineItemDataGridView();
        }
    }
}
