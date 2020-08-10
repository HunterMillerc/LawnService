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

namespace MillersLawnService.Forms.EmployeesForms
{
    public partial class EmployeesListForm : Form
    {
        LawnServiceEntities EmpDb;
        AddEmployeeForm addEmployeeForm;

        public EmployeesListForm()
        {
            InitializeComponent();
            //Initialize Database on form
            EmpDb = new LawnServiceEntities();
            EmpDb.Employees.Load();
            EmpDb.States.Load();
            this.employeeBindingSource.DataSource = EmpDb.Employees.Local.ToBindingList();
            this.stateBindingSource.DataSource = EmpDb.States.Local.ToList();
            btnEmployeeFormSaveChanges.Visible = false;

            //Populate last names for combobox
            var lastNames = (from employee in EmpDb.Employees
                             select employee.EmployeeLName).Distinct();
            searchByLastNameCbo.Items.AddRange(lastNames.ToArray());

            //Populate states for toolbar combobox
            var states = (from state in EmpDb.States
                          select state.StateCode);
            filterByStateCbo.Items.AddRange(states.ToArray());
        }

        private void btnEmployeeFormAddEmp_Click(object sender, EventArgs e)
        {
            addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
            this.Close();
        }

        private void btnEmployeeFormEditEmp_Click(object sender, EventArgs e)
        {
            if(employeeIDTextBox.Text == "")
            {
                MessageBox.Show("No employee selected. Please select an employee to edit.", "Edit Error");
            }
            else
            {
                EnableOrDisableEdit();
                int currentEmp = Convert.ToInt32(employeeIDTextBox.Text);
                var editedEmp = (from employee in EmpDb.Employees
                                 where employee.EmployeeID == currentEmp
                                 select employee).Single();

                editedEmp.EmployeeFName = employeeFNameTextBox.Text;
                editedEmp.EmployeeLName = employeeLNameTextBox.Text;
                editedEmp.EmployeePhoneNum = employeePhoneNumTextBox.Text;
                editedEmp.EmployeeAddress = employeeAddressTextBox.Text;
                editedEmp.EmployeeCity = employeeCityTextBox.Text;
                editedEmp.EmployeeState = employeeStateComboBox.SelectedValue.ToString();
                editedEmp.EmployeeZipCode = employeeZipCodeTextBox.Text;
                editedEmp.EmployeeCurrentPay = Convert.ToDecimal(employeeCurrentPayTextBox.Text);
            }
        }

        private void employeeFNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void employeeLNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void employeePhoneNumTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void employeeAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void employeeCityTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void employeeStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void employeeZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void employeeCurrentPayTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void btnEmployeeFormSaveChanges_Click(object sender, EventArgs e)
        {
            //TODO: catch concurrency error
            EmpDb.SaveChanges();
            EnableOrDisableEdit();
        }

        private void btnEmployeeFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Deletes Employee
        private void btnEmployeeFormDeleteEmp_Click(object sender, EventArgs e)
        {
            if(employeeIDTextBox.Text == "")
            {
                MessageBox.Show("No employee selected. Please select an employee to delete", "Delete Error");
            }
            else
            {
                int currentEmp = Convert.ToInt32(employeeIDTextBox.Text);
                var editedEmp = (from employee in EmpDb.Employees
                                 where employee.EmployeeID == currentEmp
                                 select employee).Single();

                DialogResult result = MessageBox.Show($"Delete {editedEmp.EmployeeFName} {editedEmp.EmployeeLName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        EmpDb.Employees.Remove(editedEmp);
                        EmpDb.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        this.Close();
                        if (EmpDb.Entry(editedEmp).State == EntityState.Detached)
                        {
                            MessageBox.Show("Another user has deleted that employee.", "Concurrency Error");
                        }
                        else
                        {
                            MessageBox.Show("Another user has updated that employee.", "Concurrency Error");
                        }
                    }
                    catch (DbUpdateException)
                    {
                        this.Close();
                        MessageBox.Show("Unable to delete employee. The employee is labeled as an employee that worked on an invoice.", "Employee Not Deleted");
                        EmployeesListForm newForm = new EmployeesListForm();
                        newForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private void btnSearchByLastName_Click(object sender, EventArgs e)
        {
            var filteredData = EmpDb.Employees.Local.ToBindingList().Where(x => x.EmployeeLName == searchByLastNameCbo.Text);
            this.employeeBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
            filterByStateCbo.SelectedIndex = -1;
        }

        private void btnFilterByState_Click(object sender, EventArgs e)
        {
            var filteredData = EmpDb.Employees.Local.ToBindingList().Where(x => x.EmployeeState == filterByStateCbo.Text);
            this.employeeBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
            searchByLastNameCbo.SelectedIndex = -1;
        }

        private void btnSearchByAll_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.DataSource = EmpDb.Employees.Local.ToBindingList();
            filterByStateCbo.SelectedIndex = -1;
            searchByLastNameCbo.SelectedIndex = -1;
        }

        /*-------------------------------------------Helping Methods-----------------------------------------------*/
        //Enable editing/disable it 
        private void EnableOrDisableEdit()
        {
            employeeFNameTextBox.ReadOnly = !employeeFNameTextBox.ReadOnly;
            employeeLNameTextBox.ReadOnly = !employeeLNameTextBox.ReadOnly;
            employeePhoneNumTextBox.ReadOnly = !employeePhoneNumTextBox.ReadOnly;
            employeeAddressTextBox.ReadOnly = !employeeAddressTextBox.ReadOnly;
            employeeCityTextBox.ReadOnly = !employeeCityTextBox.ReadOnly;
            employeeStateComboBox.Enabled = !employeeStateComboBox.Enabled;
            employeeZipCodeTextBox.ReadOnly = !employeeZipCodeTextBox.ReadOnly;
            employeeCurrentPayTextBox.ReadOnly = !employeeCurrentPayTextBox.ReadOnly;
            btnEmployeeFormSaveChanges.Visible = !btnEmployeeFormSaveChanges.Visible;
        }

        //Enable save button for edits
        private void EnableSaveBtn()
        {
            if (!ValidName(employeeFNameTextBox.Text) || !ValidName(employeeLNameTextBox.Text) || !ValidPhone(employeePhoneNumTextBox.Text) || employeeAddressTextBox.Text == "" || !ValidText(employeeCityTextBox.Text) || employeeStateComboBox.SelectedIndex == -1 || !ValidZipCode(employeeZipCodeTextBox.Text) || !ValidMoney(employeeCurrentPayTextBox.Text))
            {
                btnEmployeeFormSaveChanges.Enabled = false;
            }
            else
            {
                btnEmployeeFormSaveChanges.Enabled = true;
            }
        }
    }
}
