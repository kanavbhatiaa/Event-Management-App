using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars
{
    internal partial class formDetails : Form
    {
        Form1 page;
        EventCoordinator eCoord;
        Boolean canDelete;
        public formDetails()
        {
            InitializeComponent();
        }

        public formDetails(Form1 f1, EventCoordinator coordinator, bool isDeletable)
        {
            page = f1;
            eCoord = coordinator;
            canDelete = isDeletable;
            InitializeComponent();
         
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Customer c = eCoord.findCustomer(Convert.ToInt32(txtid.Text));

            if (c != null)
            {

                lblid.Text = c.getId().ToString();
                lblid.Visible = true;

                lblFirst.Text = c.FirstName;
                lblFirst.Visible = true;

                lblLast.Text = c.LastName;
                lblLast.Visible = true;

                lblPhone.Text = c.Phone.ToString();
                lblPhone.Visible = true;

                btnDelete.Visible = canDelete;
            }

            else
            {
                MessageBox.Show("Customer Not Found!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            page.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            eCoord.deleteCustomer(Convert.ToInt32(txtid.Text));
            MessageBox.Show("Customer Deleted!");
            this.Close();
            page.Show();
        }
    }
}
