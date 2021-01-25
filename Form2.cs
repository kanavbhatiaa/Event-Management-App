using System;
using System.Windows.Forms;

namespace StarWars
{
	internal partial class FrmCustomer : Form
    {
        Form1 page;
        EventCoordinator eCoord;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        public FrmCustomer(Form1 f1, EventCoordinator coordinator)
        {
            eCoord = coordinator;
            page = f1;
            InitializeComponent();
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eCoord.addCustomer(txtFirst.Text, txtLast.Text, txtPhone.Text);
            MessageBox.Show("Customer Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            page.Show();
        }
    }
}
