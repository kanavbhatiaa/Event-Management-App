using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarWars.EventForms;

namespace StarWars
{
    public partial class Form1 : Form
    {
       EventCoordinator eCoord = new EventCoordinator(200, 1000, 101, 5000);
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomer nForm = new FrmCustomer(this, eCoord);
            this.Hide();
            nForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using Star Wars Management!", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formView vForm = new formView(this, eCoord);
            this.Hide();
            vForm.Show();
            
        }

        private void viewCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDetails dForm = new formDetails(this, eCoord, false);
            this.Hide();
            dForm.Show();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDetails dForm = new formDetails(this, eCoord, true);
            this.Hide();
            dForm.Show();
        }

		private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddEvent frmAddEvent = new frmAddEvent(this, eCoord);
			this.Hide();
			frmAddEvent.Show();
		}

		private void viewAllEventsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmViewAllEvent frmAddEvent = new frmViewAllEvent(this, eCoord);
			this.Hide();
			frmAddEvent.Show();
		}

		private void viewEventDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmViewEvent frmAddEvent = new frmViewEvent(this, eCoord);
			this.Hide();
			frmAddEvent.Show();
		}
	}
}
