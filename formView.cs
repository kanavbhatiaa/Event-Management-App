using System;
using System.Windows.Forms;

namespace StarWars
{
	internal partial class formView : Form
    {
        Form1 page;
        public formView()
        {
            InitializeComponent();
        }

        public formView(Form1 f1, EventCoordinator coordinator)
        {
            page = f1;
            InitializeComponent();
            Label[] labels = new Label[coordinator.getNumCustomers()];
           
            for(int i = 0; i < coordinator.getNumCustomers(); i++)
            {
                lblid.Text = coordinator.getCustomerList()[i].getId().ToString();
                lblName.Text = coordinator.getCustomerList()[i].FirstName;
                lblLast.Text = coordinator.getCustomerList()[i].LastName;
                lblPhone.Text = coordinator.getCustomerList()[i].Phone;				             
            }
            
        }
        private void formView_Load(object sender, EventArgs e)
        {

            //setting up first name
            /*Label lblFirstName = new Label();
            lblFirstName.Text = coordinator.getCustomerList()[i].FirstName;
            lblFirstName.Location = new Point(400, 60);
            lblFirstName.AutoSize = true;
            this.Controls.Add(lblFirstName);

            //setting up last name
            Label lblLastName = new Label();
            lblLastName.Text = coordinator.getCustomerList()[i].LastName;
            lblLastName.Location = new Point(400, 100);
            lblLastName.AutoSize = true;
            this.Controls.Add(lblLastName);

            //setting up phone
            Label lblPhoneNum = new Label();
            lblPhoneNum.Text = coordinator.getCustomerList()[i].Phone;
            lblPhoneNum.Location = new Point(400, 140);
            lblPhoneNum.AutoSize = true;
            this.Controls.Add(lblPhoneNum); */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            page.Show();
        }
    }
}
