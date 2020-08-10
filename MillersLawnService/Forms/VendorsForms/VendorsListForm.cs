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
using static MillersLawnService.Validators;

namespace MillersLawnService.Forms.VendorsForms
{
    public partial class VendorsListForm : Form
    {
        LawnServiceEntities VendorDb;

        AddVendorForm addVendorForm;

        public VendorsListForm()
        {
            InitializeComponent();
            VendorDb = new LawnServiceEntities();
            VendorDb.Vendors.Load();
            VendorDb.States.Load();
            this.vendorBindingSource.DataSource = VendorDb.Vendors.Local.ToBindingList();
            this.stateBindingSource.DataSource = VendorDb.States.Local.ToList();
            btnVendorFormSaveChanges.Visible = false;

            //Populate names for combobox to search by vendor name
            var names = (from vendor in VendorDb.Vendors
                         select vendor.VendorName).Distinct();
            searchByNameCbo.Items.AddRange(names.ToArray());

            //Populate states for toolbar combobox to filter by state
            var states = (from state in VendorDb.States
                          select state.StateCode);
            filterByStateCbo.Items.AddRange(states.ToArray());
        }

        private void btnVendorsFormAddVend_Click(object sender, EventArgs e)
        {
            addVendorForm = new AddVendorForm();
            addVendorForm.Show();
            this.Close();
        }

        private void btnVendorsFormEditVend_Click(object sender, EventArgs e)
        {
            if(vendorIDTextBox.Text == "")
            {
                MessageBox.Show("No vendor selected. Please select a vendor to edit.", "Edit Error");
            }
            else
            {
                EnableOrDisableEdit();
                int currentVend = Convert.ToInt32(vendorIDTextBox.Text);
                var editedVend = (from vendor in VendorDb.Vendors
                                  where vendor.VendorID == currentVend
                                  select vendor).Single();

                editedVend.VendorName = vendorNameTextBox.Text;
                editedVend.VendorPhoneNum = vendorPhoneNumTextBox.Text;
                editedVend.VendorAddress = vendorAddressTextBox.Text;
                editedVend.VendorCity = vendorCityTextBox.Text;
                editedVend.VendorState = vendorStateComboBox.SelectedValue.ToString();
                editedVend.VendorZipCode = vendorZipCodeTextBox.Text;
            }
        }

        private void vendorIDTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void vendorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void vendorPhoneNumTextBox_TextChanged(object sender, EventArgs e)
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

        private void vendorStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void vendorZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void btnVendorFormSaveChanges_Click(object sender, EventArgs e)
        {
            //TODO: Catch concurrency error
            VendorDb.SaveChanges();
            EnableOrDisableEdit();
        }

        private void btnVendorsFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVendorsFormDeleteVend_Click(object sender, EventArgs e)
        {
            if(vendorIDTextBox.Text == "")
            {
                MessageBox.Show("No vendor selected. Please select a vendor to delete.", "Delete Error");
            }
            else
            {
                int currentVend = Convert.ToInt32(vendorIDTextBox.Text);
                var editedVend = (from vendor in VendorDb.Vendors
                                  where vendor.VendorID == currentVend
                                  select vendor).Single();

                DialogResult result = MessageBox.Show($"Delete {editedVend.VendorName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        VendorDb.Vendors.Remove(editedVend);
                        VendorDb.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        this.Close();
                        if(VendorDb.Entry(editedVend).State == EntityState.Detached)
                        {
                            MessageBox.Show("Another user has deleted that vendor.", "Concurrency Error");
                        }
                        else
                        {
                            MessageBox.Show("Another user has updated that vendor.", "Concurrency Error");
                        }
                        VendorsListForm newForm = new VendorsListForm();
                        newForm.Show();
                    }
                    catch (DbUpdateException)
                    {
                        this.Close();
                        MessageBox.Show("Unable to delete vendor. The vendor has records related in the purchase order table.", "Vendor Not Deleted");
                        VendorsListForm newForm = new VendorsListForm();
                        newForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            var filteredData = VendorDb.Vendors.Local.ToBindingList().Where(x => x.VendorName == searchByNameCbo.Text);
            this.vendorBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
            filterByStateCbo.SelectedIndex = -1;
        }

        private void btnFilterByState_Click(object sender, EventArgs e)
        {
            var filteredData = VendorDb.Vendors.Local.ToBindingList().Where(x => x.VendorState == filterByStateCbo.Text);
            this.vendorBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
            searchByNameCbo.SelectedIndex = -1;
        }

        private void btnSearchByAll_Click(object sender, EventArgs e)
        {
            this.vendorBindingSource.DataSource = VendorDb.Vendors.Local.ToBindingList();
            filterByStateCbo.SelectedIndex = -1;
            searchByNameCbo.SelectedIndex = -1;
        }

        /*----------------------------------------------Helper Methods------------------------------*/
        private void EnableSaveBtn()
        {
            if (vendorNameTextBox.Text == "" || !ValidPhone(vendorPhoneNumTextBox.Text) || vendorAddressTextBox.Text == "" || !ValidText(vendorCityTextBox.Text) || vendorStateComboBox.SelectedIndex == -1 || !ValidZipCode(vendorZipCodeTextBox.Text))
            {
                btnVendorFormSaveChanges.Enabled = false;
            }
            else
            {
                btnVendorFormSaveChanges.Enabled = true;
            }
        }

        private void EnableOrDisableEdit()
        {
            vendorNameTextBox.ReadOnly = !vendorNameTextBox.ReadOnly;
            vendorPhoneNumTextBox.ReadOnly = !vendorPhoneNumTextBox.ReadOnly;
            vendorAddressTextBox.ReadOnly = !vendorAddressTextBox.ReadOnly;
            vendorCityTextBox.ReadOnly = !vendorCityTextBox.ReadOnly;
            vendorStateComboBox.Enabled = !vendorStateComboBox.Enabled;
            vendorZipCodeTextBox.ReadOnly = !vendorZipCodeTextBox.ReadOnly;
            btnVendorFormSaveChanges.Visible = !btnVendorFormSaveChanges.Visible;
        }
    }
}
