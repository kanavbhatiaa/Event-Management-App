namespace StarWars
{
    partial class formView
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblCust = new System.Windows.Forms.Label();
            this.lblCust2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCust3 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust.Location = new System.Drawing.Point(193, 95);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(155, 34);
            this.lblCust.TabIndex = 2;
            this.lblCust.Text = "First Name:";
            // 
            // lblCust2
            // 
            this.lblCust2.AutoSize = true;
            this.lblCust2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust2.Location = new System.Drawing.Point(193, 127);
            this.lblCust2.Name = "lblCust2";
            this.lblCust2.Size = new System.Drawing.Size(152, 34);
            this.lblCust2.TabIndex = 3;
            this.lblCust2.Text = "Last Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(410, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 34);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(410, 122);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(86, 34);
            this.lblLast.TabIndex = 5;
            this.lblLast.Text = "Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(410, 159);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(121, 34);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Number:";
            // 
            // lblCust3
            // 
            this.lblCust3.AutoSize = true;
            this.lblCust3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust3.Location = new System.Drawing.Point(193, 159);
            this.lblCust3.Name = "lblCust3";
            this.lblCust3.Size = new System.Drawing.Size(204, 34);
            this.lblCust3.TabIndex = 7;
            this.lblCust3.Text = "Phone Number:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(410, 57);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(46, 34);
            this.lblid.TabIndex = 8;
            this.lblid.Text = "ID";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(193, 57);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(177, 34);
            this.lblCustID.TabIndex = 9;
            this.lblCustID.Text = "Customer ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblCust3);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCust2);
            this.Controls.Add(this.lblCust);
            this.Location = new System.Drawing.Point(200, 60);
            this.Name = "formView";
            this.Text = "View Customers";
            this.Load += new System.EventHandler(this.formView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblCust2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCust3;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Button button1;
    }
}