using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MillersLawnService.Validators;

namespace MillersLawnService.Forms.CustomersForms
{
    public partial class CustomersListForm : Form
    {
        public LawnServiceEntities CustDb;
        AddCustomerForm addCustomerForm;

        public CustomersListForm()
        {
            InitializeComponent();
            //Initialize LawnServiceEntities and load. Must utilize "this" (this form) and specify what the customerBindingSource DataSource is
            //Follow that by putting it to local and use ToBindingList() to make it so that any changes made are reflected in database
            //Combobox for states utilizes the list to show them
            CustDb = new LawnServiceEntities();
            CustDb.Customers.Load();
            CustDb.States.Load();
            this.customerBindingSource.DataSource = CustDb.Customers.Local.ToBindingList();
            this.stateBindingSource.DataSource = CustDb.States.Local.ToList();
            btnCustomerFormSaveChanges.Visible = false;

            //Populate last names for combobox to search by last name
            var lastNames = (from customer in CustDb.Customers
                             select customer.CustomerLName).Distinct();
            searchByLastNameCbo.Items.AddRange(lastNames.ToArray());

            //Populate states for toolbar combobox to filter by state
            var states = (from state in CustDb.States
                          select state.StateCode);
            filterByStateCbo.Items.AddRange(states.ToArray());
        }

        private void CustomersListForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerFormAddCust_Click(object sender, EventArgs e)
        {
            addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
            this.Close();
        }

        private void btnCustomerFormEditCust_Click(object sender, EventArgs e)
        {
            EnableOrDisableEdit();
            int currentCust = Convert.ToInt32(customerIDTextBox.Text);
            var editedCust = (from customer in CustDb.Customers
                              where customer.CustomerID == currentCust
                              select customer).Single();

            editedCust.CustomerFName = customerFNameTextBox.Text;
            editedCust.CustomerLName = customerLNameTextBox.Text;
            editedCust.CustomerPhoneNum = customerPhoneNumTextBox.Text;
            editedCust.CustomerAddress = customerAddressTextBox.Text;
            editedCust.CustomerCity = customerCityTextBox.Text;
            editedCust.CustomerState = customerStateComboBox.SelectedValue.ToString();
            editedCust.CustomerZipCode = customerZipCodeTextBox.Text;
        }

        private void customerFNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void customerLNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void customerPhoneNumTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void customerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void customerCityTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void customerStateTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void customerZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void btnCustomerFormSaveChanges_Click(object sender, EventArgs e)
        {
            CustDb.SaveChanges();
            EnableOrDisableEdit();
        }

        private void btnCustomerFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustomerFormDeleteCust_Click(object sender, EventArgs e)
        {
            int currentCust = Convert.ToInt32(customerIDTextBox.Text);
            var editedCust = (from customer in CustDb.Customers
                              where customer.CustomerID == currentCust
                              select customer).Single();

            DialogResult result = MessageBox.Show($"Delete {editedCust.CustomerFName} {editedCust.CustomerLName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    CustDb.Customers.Remove(editedCust);
                    CustDb.SaveChanges();
                }
                catch(DbUpdateConcurrencyException ex)
                {
                    ex.Entries.Single().Reload();
                    if(CustDb.Entry(editedCust).State == EntityState.Detached)
                    {
                        MessageBox.Show("Another user has deleted that customer.", "Concurrency Error");
                    }
                    else
                    {
                        MessageBox.Show("Another user has updated that customer.", "Concurrency Error");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void EnableSaveBtn()
        {
            if (!ValidName(customerFNameTextBox.Text) || !ValidName(customerLNameTextBox.Text) || !ValidPhone(customerPhoneNumTextBox.Text) || customerAddressTextBox.Text == "" || !ValidText(customerCityTextBox.Text) || customerStateComboBox.SelectedIndex == -1 || !ValidZipCode(customerZipCodeTextBox.Text))
            {
                btnCustomerFormSaveChanges.Enabled = false;
            }
            else
            {
                btnCustomerFormSaveChanges.Enabled = true;
            }
        }

        private void EnableOrDisableEdit()
        {
            customerFNameTextBox.ReadOnly = !customerFNameTextBox.ReadOnly;
            customerLNameTextBox.ReadOnly = !customerLNameTextBox.ReadOnly;
            customerPhoneNumTextBox.ReadOnly = !customerPhoneNumTextBox.ReadOnly;
            customerAddressTextBox.ReadOnly = !customerAddressTextBox.ReadOnly;
            customerCityTextBox.ReadOnly = !customerCityTextBox.ReadOnly;
            customerStateComboBox.Enabled = !customerStateComboBox.Enabled;
            customerZipCodeTextBox.ReadOnly = !customerZipCodeTextBox.ReadOnly;
            btnCustomerFormSaveChanges.Visible = !btnCustomerFormSaveChanges.Visible;
        }

        private void btnSearchByLastName_Click(object sender, EventArgs e)
        {
            var filteredData = CustDb.Customers.Local.ToBindingList().Where(x => x.CustomerLName == searchByLastNameCbo.Text);
            this.customerBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
            filterByStateCbo.SelectedIndex = -1;
        }

        private void btnFilterByState_Click(object sender, EventArgs e)
        {
            var filteredData = CustDb.Customers.Local.ToBindingList().Where(x => x.CustomerState == filterByStateCbo.Text);
            this.customerBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
            searchByLastNameCbo.SelectedIndex = -1;
        }

        private void btnSearchByAll_Click(object sender, EventArgs e)
        {
            this.customerBindingSource.DataSource = CustDb.Customers.Local.ToBindingList();
            filterByStateCbo.SelectedIndex = -1;
            searchByLastNameCbo.SelectedIndex = -1;
        }
    }
}
