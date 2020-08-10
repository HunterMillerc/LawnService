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

namespace MillersLawnService.Forms.ServicesForms
{
    public partial class AddServiceForm : Form
    {
        LawnServiceEntities addServiceDb;
        private Service service;
        ServicesListForm servicesListForm;

        public AddServiceForm()
        {
            InitializeComponent();
            addServiceDb = new LawnServiceEntities();
            service = new Service();
            EnableSaveBtn();
        }

        private void btnAddServiceFormSaveChanges_Click(object sender, EventArgs e)
        {
            service.ServiceName = serviceNameTextBox.Text;
            service.ServiceDescription = serviceDescriptionTextBox.Text;
            service.ServiceCostPerHour = Convert.ToDecimal(serviceCostPerHourTextBox.Text);
            addServiceDb.Services.Add(service);
            addServiceDb.SaveChanges();
            servicesListForm = new ServicesListForm();
            servicesListForm.Show();
            this.Close();
        }

        private void EnableSaveBtn()
        {
            if (!ValidText(serviceNameTextBox.Text) || !ValidMoney(serviceCostPerHourTextBox.Text))
            {
                btnAddServiceFormSaveChanges.Enabled = false;
            }
            else
            {
                btnAddServiceFormSaveChanges.Enabled = true;
            }
        }

        private void serviceNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void serviceDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void serviceCostPerHourTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableSaveBtn();
        }

        private void btnAddServiceFormCancel_Click(object sender, EventArgs e)
        {
            servicesListForm = new ServicesListForm();
            servicesListForm.Show();
            this.Close();
        }
    }
}
