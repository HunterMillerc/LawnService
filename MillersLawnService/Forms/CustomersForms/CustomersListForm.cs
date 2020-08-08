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
    public partial class CustomersListForm : Form
    {
        LawnServiceEntities db;
        public CustomersListForm()
        {
            InitializeComponent();
            //Initialize LawnServiceEntities and load. Must utilize "this" (this form) and specify what the customerBindingSource DataSource is
            //Follow that by putting it to local and use ToBindingList() to make it so that any changes made are reflected in database
            db = new LawnServiceEntities();
            db.Customers.Load();
            this.customerBindingSource.DataSource = db.Customers.Local.ToBindingList();
        }

        private void CustomersListForm_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
