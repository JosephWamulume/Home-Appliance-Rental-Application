namespace Home_Appliance_Rental_Application
{
    partial class registerFrm
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
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityTownCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showPasswordCbx = new System.Windows.Forms.CheckBox();
            this.loginLinkLbl = new System.Windows.Forms.LinkLabel();
            this.loginLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.phoneNumberPnl = new System.Windows.Forms.Panel();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.residentialAddressPnl = new System.Windows.Forms.Panel();
            this.residentialAddressTxt = new System.Windows.Forms.TextBox();
            this.passwordPnl = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.repeatPasswordPnl = new System.Windows.Forms.Panel();
            this.repeatPasswordTxt = new System.Windows.Forms.TextBox();
            this.pnlUsername.SuspendLayout();
            this.phoneNumberPnl.SuspendLayout();
            this.residentialAddressPnl.SuspendLayout();
            this.passwordPnl.SuspendLayout();
            this.repeatPasswordPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.LightGray;
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxt.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.usernameTxt.Location = new System.Drawing.Point(20, 6);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(378, 30);
            this.usernameTxt.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(69, 145);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(116, 36);
            this.usernameLbl.TabIndex = 38;
            this.usernameLbl.Text = "Username";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.titleLbl.Location = new System.Drawing.Point(66, 54);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(278, 56);
            this.titleLbl.TabIndex = 29;
            this.titleLbl.Text = "Getting Started";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLbl.Location = new System.Drawing.Point(572, 145);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(162, 36);
            this.phoneNumberLbl.TabIndex = 40;
            this.phoneNumberLbl.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 44;
            this.label1.Text = "Residential Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 36);
            this.label2.TabIndex = 42;
            this.label2.Text = "City/Town";
            // 
            // cityTownCbx
            // 
            this.cityTownCbx.BackColor = System.Drawing.Color.LightGray;
            this.cityTownCbx.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTownCbx.FormattingEnabled = true;
            this.cityTownCbx.ItemHeight = 36;
            this.cityTownCbx.Items.AddRange(new object[] {
            "Lusaka, Lusaka Province",
            "Ndola, Copperbelt Province",
            "Kitwe, Copperbelt Province",
            "Kabwe, Central Province",
            "Livingstone, Southern Province",
            "Solwezi, North-Western Province",
            "Chipata, Eastern Province",
            "Chingola, Copperbelt Province",
            "Mufulira, Copperbelt Province",
            "Luanshya, Copperbelt Province",
            "Kasama, Northern Province",
            "Mansa, Luapula Province",
            "Mongu, Western Province",
            "Choma, Southern Province",
            "Mpika, Muchinga Province",
            "Kalulushi, Copperbelt Province",
            "Kafue, Lusaka Province",
            "Kapiri Mposhi, Central Province",
            "Nchelenge, Luapula Province",
            "Siavonga, Southern Province"});
            this.cityTownCbx.Location = new System.Drawing.Point(76, 302);
            this.cityTownCbx.Name = "cityTownCbx";
            this.cityTownCbx.Size = new System.Drawing.Size(417, 44);
            this.cityTownCbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 36);
            this.label3.TabIndex = 49;
            this.label3.Text = "Repeat Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 47;
            this.label4.Text = "Password";
            // 
            // showPasswordCbx
            // 
            this.showPasswordCbx.AutoSize = true;
            this.showPasswordCbx.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCbx.Location = new System.Drawing.Point(802, 515);
            this.showPasswordCbx.Name = "showPasswordCbx";
            this.showPasswordCbx.Size = new System.Drawing.Size(194, 40);
            this.showPasswordCbx.TabIndex = 7;
            this.showPasswordCbx.Text = "Show Password";
            this.showPasswordCbx.UseVisualStyleBackColor = true;
            this.showPasswordCbx.CheckedChanged += new System.EventHandler(this.showPasswordCbx_CheckedChanged);
            // 
            // loginLinkLbl
            // 
            this.loginLinkLbl.AutoSize = true;
            this.loginLinkLbl.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLinkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.loginLinkLbl.Location = new System.Drawing.Point(489, 769);
            this.loginLinkLbl.Name = "loginLinkLbl";
            this.loginLinkLbl.Size = new System.Drawing.Size(70, 36);
            this.loginLinkLbl.TabIndex = 9;
            this.loginLinkLbl.TabStop = true;
            this.loginLinkLbl.Text = "Login";
            this.loginLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLinkLbl_LinkClicked);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(387, 719);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(277, 36);
            this.loginLbl.TabIndex = 52;
            this.loginLbl.Text = "Already have an account?";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(76, 609);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(920, 53);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.LightGray;
            this.pnlUsername.Controls.Add(this.usernameTxt);
            this.pnlUsername.Location = new System.Drawing.Point(75, 184);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(418, 42);
            this.pnlUsername.TabIndex = 54;
            // 
            // phoneNumberPnl
            // 
            this.phoneNumberPnl.BackColor = System.Drawing.Color.LightGray;
            this.phoneNumberPnl.Controls.Add(this.phoneNumberTxt);
            this.phoneNumberPnl.Location = new System.Drawing.Point(578, 184);
            this.phoneNumberPnl.Name = "phoneNumberPnl";
            this.phoneNumberPnl.Size = new System.Drawing.Size(418, 42);
            this.phoneNumberPnl.TabIndex = 55;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.BackColor = System.Drawing.Color.LightGray;
            this.phoneNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTxt.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.phoneNumberTxt.Location = new System.Drawing.Point(20, 6);
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(378, 30);
            this.phoneNumberTxt.TabIndex = 2;
            // 
            // residentialAddressPnl
            // 
            this.residentialAddressPnl.BackColor = System.Drawing.Color.LightGray;
            this.residentialAddressPnl.Controls.Add(this.residentialAddressTxt);
            this.residentialAddressPnl.Location = new System.Drawing.Point(578, 304);
            this.residentialAddressPnl.Name = "residentialAddressPnl";
            this.residentialAddressPnl.Size = new System.Drawing.Size(418, 42);
            this.residentialAddressPnl.TabIndex = 56;
            // 
            // residentialAddressTxt
            // 
            this.residentialAddressTxt.BackColor = System.Drawing.Color.LightGray;
            this.residentialAddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.residentialAddressTxt.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.residentialAddressTxt.Location = new System.Drawing.Point(20, 6);
            this.residentialAddressTxt.Name = "residentialAddressTxt";
            this.residentialAddressTxt.Size = new System.Drawing.Size(378, 30);
            this.residentialAddressTxt.TabIndex = 4;
            // 
            // passwordPnl
            // 
            this.passwordPnl.BackColor = System.Drawing.Color.LightGray;
            this.passwordPnl.Controls.Add(this.passwordTxt);
            this.passwordPnl.Location = new System.Drawing.Point(76, 428);
            this.passwordPnl.Name = "passwordPnl";
            this.passwordPnl.Size = new System.Drawing.Size(418, 42);
            this.passwordPnl.TabIndex = 57;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.LightGray;
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.passwordTxt.Location = new System.Drawing.Point(20, 6);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '•';
            this.passwordTxt.Size = new System.Drawing.Size(378, 30);
            this.passwordTxt.TabIndex = 5;
            // 
            // repeatPasswordPnl
            // 
            this.repeatPasswordPnl.BackColor = System.Drawing.Color.LightGray;
            this.repeatPasswordPnl.Controls.Add(this.repeatPasswordTxt);
            this.repeatPasswordPnl.Location = new System.Drawing.Point(578, 428);
            this.repeatPasswordPnl.Name = "repeatPasswordPnl";
            this.repeatPasswordPnl.Size = new System.Drawing.Size(418, 42);
            this.repeatPasswordPnl.TabIndex = 58;
            // 
            // repeatPasswordTxt
            // 
            this.repeatPasswordTxt.BackColor = System.Drawing.Color.LightGray;
            this.repeatPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeatPasswordTxt.Font = new System.Drawing.Font("Poppins Light", 10F);
            this.repeatPasswordTxt.Location = new System.Drawing.Point(20, 6);
            this.repeatPasswordTxt.Name = "repeatPasswordTxt";
            this.repeatPasswordTxt.PasswordChar = '•';
            this.repeatPasswordTxt.Size = new System.Drawing.Size(378, 30);
            this.repeatPasswordTxt.TabIndex = 6;
            // 
            // registerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 881);
            this.Controls.Add(this.repeatPasswordPnl);
            this.Controls.Add(this.passwordPnl);
            this.Controls.Add(this.residentialAddressPnl);
            this.Controls.Add(this.phoneNumberPnl);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.loginLinkLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.showPasswordCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cityTownCbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "registerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Appliance Rental System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.registerFrm_FormClosing);
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.phoneNumberPnl.ResumeLayout(false);
            this.phoneNumberPnl.PerformLayout();
            this.residentialAddressPnl.ResumeLayout(false);
            this.residentialAddressPnl.PerformLayout();
            this.passwordPnl.ResumeLayout(false);
            this.passwordPnl.PerformLayout();
            this.repeatPasswordPnl.ResumeLayout(false);
            this.repeatPasswordPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cityTownCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showPasswordCbx;
        private System.Windows.Forms.LinkLabel loginLinkLbl;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel phoneNumberPnl;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.Panel residentialAddressPnl;
        private System.Windows.Forms.TextBox residentialAddressTxt;
        private System.Windows.Forms.Panel passwordPnl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Panel repeatPasswordPnl;
        private System.Windows.Forms.TextBox repeatPasswordTxt;
    }
}