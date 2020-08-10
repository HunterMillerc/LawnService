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

namespace MillersLawnService.Forms.CustomersForms
{
    public partial class AddCustomerForm : Form
    {
        LawnServiceEntities Db;
        private Customer customer;

        CustomersListForm CustomersListForm;

        public AddCustomerForm()
        {
            InitializeComponent();
            Db = new LawnServiceEntities();
            Db.States.Load();
            this.stateBindingSource.DataSource = Db.States.Local.ToList();
            customer = new Customer();
            EnableSaveBtn();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

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

        private void customerStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void customerZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void btnAddCustomerFormSaveChanges_Click(object sender, EventArgs e)
        {
            customer.CustomerFName = customerFNameTextBox.Text;
            customer.CustomerLName = customerLNameTextBox.Text;
            customer.CustomerPhoneNum = customerPhoneNumTextBox.Text;
            customer.CustomerAddress = customerAddressTextBox.Text;
            customer.CustomerCity = customerCityTextBox.Text;
            customer.CustomerState = customerStateComboBox.SelectedValue.ToString();
            customer.CustomerZipCode = customerZipCodeTextBox.Text;
            Db.Customers.Add(customer);
            Db.SaveChanges();
            CustomersListForm = new CustomersListForm();
            CustomersListForm.Show();
            this.Close();
        }

        private void EnableSaveBtn()
        {
            if (customerFNameTextBox.Text == "" || customerLNameTextBox.Text == "" || customerPhoneNumTextBox.Text == "" || customerAddressTextBox.Text == "" || customerCityTextBox.Text == "" || customerStateComboBox.SelectedIndex == -1 || customerZipCodeTextBox.Text == "")
            {
                btnAddCustomerFormSaveChanges.Enabled = false;
            }
            else
            {
                btnAddCustomerFormSaveChanges.Enabled = true;
            }
        }

        private void btnAddCustomerFormCancel_Click(object sender, EventArgs e)
        {
            CustomersListForm = new CustomersListForm();
            CustomersListForm.Show();
            this.Close();
        }
    }
}
