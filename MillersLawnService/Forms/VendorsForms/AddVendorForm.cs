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
using static MillersLawnService.Validators;

namespace MillersLawnService.Forms.VendorsForms
{
    public partial class AddVendorForm : Form
    {
        LawnServiceEntities AddVendorDb;
        private Vendor vendor;

        public AddVendorForm()
        {
            InitializeComponent();
            AddVendorDb = new LawnServiceEntities();
            AddVendorDb.States.Load();
            this.stateBindingSource.DataSource = AddVendorDb.States.Local.ToList();
            vendor = new Vendor();
            EnableSaveBtn();
        }

        private void vendorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void vendorAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void vendorCityTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void vendorPhoneNumTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void vendorStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void vendorZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void btnAddVendorFormSaveChanges_Click(object sender, EventArgs e)
        {
            vendor.VendorName = vendorNameTextBox.Text;
            vendor.VendorPhoneNum = vendorPhoneNumTextBox.Text;
            vendor.VendorAddress = vendorAddressTextBox.Text;
            vendor.VendorCity = vendorCityTextBox.Text;
            vendor.VendorState = vendorStateComboBox.SelectedValue.ToString();
            vendor.VendorZipCode = vendorZipCodeTextBox.Text;
            AddVendorDb.Vendors.Add(vendor);
            AddVendorDb.SaveChanges();

            VendorsListForm vendorsListForm = new VendorsListForm();
            vendorsListForm.Show();
            this.Close();
        }

        private void btnAddVendorFormCancel_Click(object sender, EventArgs e)
        {
            VendorsListForm vendorsListForm = new VendorsListForm();
            vendorsListForm.Show();
            this.Close();
        }

        private void EnableSaveBtn()
        {
            if (vendorNameTextBox.Text == "" || !ValidPhone(vendorPhoneNumTextBox.Text) || vendorAddressTextBox.Text == "" || !ValidText(vendorCityTextBox.Text) || vendorStateComboBox.SelectedIndex == -1 || !ValidZipCode(vendorZipCodeTextBox.Text))
            {
                btnAddVendorFormSaveChanges.Enabled = false;
            }
            else
            {
                btnAddVendorFormSaveChanges.Enabled = true;
            }
        }
    }
}
