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

namespace MillersLawnService.Forms.EmployeesForms
{
    public partial class AddEmployeeForm : Form
    {

        LawnServiceEntities AddEmpDb;

        private Employee employee;

        EmployeesListForm EmployeesListForm;

        public AddEmployeeForm()
        {
            InitializeComponent();
            AddEmpDb = new LawnServiceEntities();
            AddEmpDb.States.Load();
            this.stateBindingSource.DataSource = AddEmpDb.States.Local.ToList();
            employee = new Employee();
            EnableSaveBtn();
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

        private void btnAddEmployeeFormSaveChanges_Click(object sender, EventArgs e)
        {
            employee.EmployeeFName = employeeFNameTextBox.Text;
            employee.EmployeeLName = employeeLNameTextBox.Text;
            employee.EmployeePhoneNum = employeePhoneNumTextBox.Text;
            employee.EmployeeAddress = employeeAddressTextBox.Text;
            employee.EmployeeCity = employeeCityTextBox.Text;
            employee.EmployeeState = employeeStateComboBox.SelectedValue.ToString();
            employee.EmployeeZipCode = employeeZipCodeTextBox.Text;
            employee.EmployeeCurrentPay = Convert.ToDecimal(employeeCurrentPayTextBox.Text);
            AddEmpDb.Employees.Add(employee);
            AddEmpDb.SaveChanges();
            EmployeesListForm = new EmployeesListForm();
            EmployeesListForm.Show();
            this.Close();
        }

        private void btnAddEmployeeFormCancel_Click(object sender, EventArgs e)
        {
            EmployeesListForm = new EmployeesListForm();
            EmployeesListForm.Show();
            this.Close();
        }

        private void EnableSaveBtn()
        {
            if (!ValidName(employeeFNameTextBox.Text) || !ValidName(employeeLNameTextBox.Text) || !ValidPhone(employeePhoneNumTextBox.Text) || employeeAddressTextBox.Text == "" || !ValidText(employeeCityTextBox.Text) || employeeStateComboBox.SelectedIndex == -1 || !ValidZipCode(employeeZipCodeTextBox.Text) || !ValidMoney(employeeCurrentPayTextBox.Text))
            {
                btnAddEmployeeFormSaveChanges.Enabled = false;
            }
            else
            {
                btnAddEmployeeFormSaveChanges.Enabled = true;
            }
        }
    }
}
