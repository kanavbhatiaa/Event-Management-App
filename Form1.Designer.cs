namespace StarWars
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnExit = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewAllEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewEventDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rSVPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rSVPForEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewRSVPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblHome = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(281, 405);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(93, 35);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.rSVPToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(686, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// customerToolStripMenuItem
			// 
			this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewCustomersToolStripMenuItem,
            this.viewCustomerDetailsToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
			this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
			this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.customerToolStripMenuItem.Text = "Customer";
			// 
			// addCustomerToolStripMenuItem
			// 
			this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
			this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.addCustomerToolStripMenuItem.Text = "Add Customer";
			this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
			// 
			// viewCustomersToolStripMenuItem
			// 
			this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
			this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.viewCustomersToolStripMenuItem.Text = "View Customers";
			this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
			// 
			// viewCustomerDetailsToolStripMenuItem
			// 
			this.viewCustomerDetailsToolStripMenuItem.Name = "viewCustomerDetailsToolStripMenuItem";
			this.viewCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.viewCustomerDetailsToolStripMenuItem.Text = "View Customer Details";
			this.viewCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerDetailsToolStripMenuItem_Click);
			// 
			// deleteCustomerToolStripMenuItem
			// 
			this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
			this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
			this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
			this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
			// 
			// eventToolStripMenuItem
			// 
			this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.viewAllEventsToolStripMenuItem,
            this.viewEventDetailsToolStripMenuItem});
			this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
			this.eventToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.eventToolStripMenuItem.Text = "Event";
			// 
			// addEventToolStripMenuItem
			// 
			this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
			this.addEventToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.addEventToolStripMenuItem.Text = "Add Event";
			this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
			// 
			// viewAllEventsToolStripMenuItem
			// 
			this.viewAllEventsToolStripMenuItem.Name = "viewAllEventsToolStripMenuItem";
			this.viewAllEventsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.viewAllEventsToolStripMenuItem.Text = "View All Events";
			this.viewAllEventsToolStripMenuItem.Click += new System.EventHandler(this.viewAllEventsToolStripMenuItem_Click);
			// 
			// viewEventDetailsToolStripMenuItem
			// 
			this.viewEventDetailsToolStripMenuItem.Name = "viewEventDetailsToolStripMenuItem";
			this.viewEventDetailsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.viewEventDetailsToolStripMenuItem.Text = "View Event Details";
			this.viewEventDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewEventDetailsToolStripMenuItem_Click);
			// 
			// rSVPToolStripMenuItem
			// 
			this.rSVPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rSVPForEventToolStripMenuItem,
            this.viewRSVPToolStripMenuItem});
			this.rSVPToolStripMenuItem.Name = "rSVPToolStripMenuItem";
			this.rSVPToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.rSVPToolStripMenuItem.Text = "RSVP";
			// 
			// rSVPForEventToolStripMenuItem
			// 
			this.rSVPForEventToolStripMenuItem.Name = "rSVPForEventToolStripMenuItem";
			this.rSVPForEventToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.rSVPForEventToolStripMenuItem.Text = "RSVP For Event";
			// 
			// viewRSVPToolStripMenuItem
			// 
			this.viewRSVPToolStripMenuItem.Name = "viewRSVPToolStripMenuItem";
			this.viewRSVPToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.viewRSVPToolStripMenuItem.Text = "View RSVP";
			// 
			// lblHome
			// 
			this.lblHome.AutoSize = true;
			this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHome.Location = new System.Drawing.Point(39, 104);
			this.lblHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHome.Name = "lblHome";
			this.lblHome.Size = new System.Drawing.Size(611, 36);
			this.lblHome.TabIndex = 2;
			this.lblHome.Text = "Welcome to Star Wars Event Management";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(207, 175);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(264, 208);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 490);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblHome);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.menuStrip1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Star Wars";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSVPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSVPForEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRSVPToolStripMenuItem;
    }
}

