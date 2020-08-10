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

namespace MillersLawnService.Forms.ServicesForms
{
    public partial class ServicesListForm : Form
    {
        LawnServiceEntities ServiceDb;
        AddServiceForm addServiceForm;

        public ServicesListForm()
        {
            InitializeComponent();
            ServiceDb = new LawnServiceEntities();
            ServiceDb.Services.Load();
            this.serviceBindingSource.DataSource = ServiceDb.Services.Local.ToBindingList();
            btnServicesFormSaveChanges.Visible = false;

            //Populate list for service name combobox search item
            var names = (from service in ServiceDb.Services
                         select service.ServiceName).Distinct();
            searchByServiceNameCbo.Items.AddRange(names.ToArray());

            //Populate list for service cost combobox search item
            var costs = (from service in ServiceDb.Services
                         select service.ServiceCostPerHour).Distinct();

            //Generate list from costs var and make it into a string to be used for the combobox
            List<string> serviceCosts = new List<string>();
            foreach(Decimal cost in costs)
            {
                serviceCosts.Add(cost.ToString("N"));
            }
            filterByCostCbo.Items.AddRange(serviceCosts.ToArray());
        }

        private void btnServicesFormAddService_Click(object sender, EventArgs e)
        {
            addServiceForm = new AddServiceForm();
            addServiceForm.Show();
            this.Close();
        }

        private void btnServicesFormEditService_Click(object sender, EventArgs e)
        {
            if(serviceIDTextBox.Text == "")
            {
                MessageBox.Show("No service selected. Please select a service to edit.", "Edit Error");
            }
            else
            {
                EnableOrDisableEdit();
                int currentService = Convert.ToInt32(serviceIDTextBox.Text);
                var editedService = (from service in ServiceDb.Services
                                     where service.ServiceID == currentService
                                     select service).Single();

                editedService.ServiceName = serviceNameTextBox.Text;
                editedService.ServiceDescription = serviceDescriptionTextBox.Text;
                editedService.ServiceCostPerHour = Convert.ToDecimal(serviceCostPerHourTextBox.Text);
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

        private void btnServicesFormSaveChanges_Click(object sender, EventArgs e)
        {
            //TODO: Catch Concurrency error
            ServiceDb.SaveChanges();
            EnableOrDisableEdit();
        }

        private void btnServicesFormDeleteService_Click(object sender, EventArgs e)
        {
            if(serviceIDTextBox.Text == "")
            {
                MessageBox.Show("No service selected. Please select a service to delete.", "Delete Error");
            }
            else
            {
                int currentService = Convert.ToInt32(serviceIDTextBox.Text);
                var editedService = (from service in ServiceDb.Services
                                     where service.ServiceID == currentService
                                     select service).Single();
                DialogResult result = MessageBox.Show($"Delete Service ID: {editedService.ServiceID} | Name: {editedService.ServiceName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        ServiceDb.Services.Remove(editedService);
                        ServiceDb.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        this.Close();
                        if(ServiceDb.Entry(editedService).State == EntityState.Detached)
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
                        MessageBox.Show("Unable to delete service. The service is shown to be used on invoices.", "Service Not Deleted");
                        ServicesListForm newForm = new ServicesListForm();
                        newForm.Show();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                
            }
        }

        private void btnServicesFormExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchByServiceName_Click(object sender, EventArgs e)
        {
            var filteredData = ServiceDb.Services.Local.ToBindingList().Where(x => x.ServiceName == searchByServiceNameCbo.Text);
            this.serviceBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
            filterByCostCbo.SelectedIndex = -1;
        }

        private void btnFilterByCost_Click(object sender, EventArgs e)
        {
            var filteredData = ServiceDb.Services.Local.ToBindingList().Where(x => x.ServiceCostPerHour == Convert.ToDecimal(filterByCostCbo.Text));
            this.serviceBindingSource.DataSource = filteredData.Count() > 0 ? filteredData : filteredData.ToArray();
        }

        private void btnSearchByAll_Click(object sender, EventArgs e)
        {
            this.serviceBindingSource.DataSource = ServiceDb.Services.Local.ToBindingList();
            filterByCostCbo.SelectedIndex = -1;
            searchByServiceNameCbo.SelectedIndex = -1;
        }

        /*---------------------------------------------Helper Methods-------------------------------------------------*/
        private void EnableOrDisableEdit()
        {
            serviceNameTextBox.ReadOnly = !serviceNameTextBox.ReadOnly;
            serviceDescriptionTextBox.ReadOnly = !serviceDescriptionTextBox.ReadOnly;
            serviceCostPerHourTextBox.ReadOnly = !serviceCostPerHourTextBox.ReadOnly;
            btnServicesFormSaveChanges.Visible = !btnServicesFormSaveChanges.Visible;
        }

        private void EnableSaveBtn()
        {
            if (!ValidText(serviceNameTextBox.Text) || !ValidMoney(serviceCostPerHourTextBox.Text))
            {
                btnServicesFormSaveChanges.Enabled = false;
            }
            else
            {
                btnServicesFormSaveChanges.Enabled = true;
            }
        }
    }
}
