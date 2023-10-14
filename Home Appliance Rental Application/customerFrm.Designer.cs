namespace Home_Appliance_Rental_Application
{
    partial class customerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerFrm));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.myOrdersBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.pnlSideMenu.Controls.Add(this.placeOrderBtn);
            this.pnlSideMenu.Controls.Add(this.myOrdersBtn);
            this.pnlSideMenu.Controls.Add(this.logoutBtn);
            this.pnlSideMenu.Controls.Add(this.lblUsername);
            this.pnlSideMenu.Controls.Add(this.label2);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(441, 1023);
            this.pnlSideMenu.TabIndex = 3;
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(102)))));
            this.placeOrderBtn.FlatAppearance.BorderSize = 0;
            this.placeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderBtn.ForeColor = System.Drawing.Color.White;
            this.placeOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("placeOrderBtn.Image")));
            this.placeOrderBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeOrderBtn.Location = new System.Drawing.Point(0, 0);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.placeOrderBtn.Size = new System.Drawing.Size(441, 93);
            this.placeOrderBtn.TabIndex = 12;
            this.placeOrderBtn.Text = "           Place Order";
            this.placeOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeOrderBtn.UseVisualStyleBackColor = false;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // myOrdersBtn
            // 
            this.myOrdersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.myOrdersBtn.FlatAppearance.BorderSize = 0;
            this.myOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myOrdersBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myOrdersBtn.ForeColor = System.Drawing.Color.White;
            this.myOrdersBtn.Image = ((System.Drawing.Image)(resources.GetObject("myOrdersBtn.Image")));
            this.myOrdersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myOrdersBtn.Location = new System.Drawing.Point(0, 97);
            this.myOrdersBtn.Name = "myOrdersBtn";
            this.myOrdersBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.myOrdersBtn.Size = new System.Drawing.Size(441, 90);
            this.myOrdersBtn.TabIndex = 13;
            this.myOrdersBtn.Text = "           My Orders";
            this.myOrdersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myOrdersBtn.UseVisualStyleBackColor = false;
            this.myOrdersBtn.Click += new System.EventHandler(this.myOrdersBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 191);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(441, 90);
            this.logoutBtn.TabIndex = 14;
            this.logoutBtn.Text = "           Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(13, 880);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(118, 36);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 835);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Logged in as:";
            // 
            // customerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1843, 1023);
            this.Controls.Add(this.pnlSideMenu);
            this.IsMdiContainer = true;
            this.Name = "customerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Rental Appliance System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.customerFrm_FormClosing);
            this.Load += new System.EventHandler(this.customerFrm_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Button myOrdersBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
    }
}