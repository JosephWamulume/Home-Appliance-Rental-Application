namespace Home_Appliance_Rental_Application
{
    partial class loginFrm
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
            this.registerLinkLbl = new System.Windows.Forms.LinkLabel();
            this.registerLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.showPasswordCbx = new System.Windows.Forms.CheckBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordPnl = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlUsername.SuspendLayout();
            this.passwordPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerLinkLbl
            // 
            this.registerLinkLbl.AutoSize = true;
            this.registerLinkLbl.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLinkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.registerLinkLbl.Location = new System.Drawing.Point(205, 627);
            this.registerLinkLbl.Name = "registerLinkLbl";
            this.registerLinkLbl.Size = new System.Drawing.Size(174, 36);
            this.registerLinkLbl.TabIndex = 5;
            this.registerLinkLbl.TabStop = true;
            this.registerLinkLbl.Text = "Create Account";
            this.registerLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLbl_LinkClicked);
            // 
            // registerLbl
            // 
            this.registerLbl.AutoSize = true;
            this.registerLbl.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLbl.Location = new System.Drawing.Point(166, 577);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.Size = new System.Drawing.Size(251, 36);
            this.registerLbl.TabIndex = 20;
            this.registerLbl.Text = "Don\'t have an account?";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(76, 467);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(417, 53);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.titleLbl.Location = new System.Drawing.Point(66, 54);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(180, 56);
            this.titleLbl.TabIndex = 11;
            this.titleLbl.Text = "Welcome";
            // 
            // showPasswordCbx
            // 
            this.showPasswordCbx.AutoSize = true;
            this.showPasswordCbx.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCbx.Location = new System.Drawing.Point(299, 388);
            this.showPasswordCbx.Name = "showPasswordCbx";
            this.showPasswordCbx.Size = new System.Drawing.Size(194, 40);
            this.showPasswordCbx.TabIndex = 3;
            this.showPasswordCbx.Text = "Show Password";
            this.showPasswordCbx.UseVisualStyleBackColor = true;
            this.showPasswordCbx.CheckedChanged += new System.EventHandler(this.showPasswordCbx_CheckedChanged);
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.LightGray;
            this.pnlUsername.Controls.Add(this.usernameTxt);
            this.pnlUsername.Location = new System.Drawing.Point(76, 184);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(418, 42);
            this.pnlUsername.TabIndex = 56;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 36);
            this.label1.TabIndex = 55;
            this.label1.Text = "Username";
            // 
            // passwordPnl
            // 
            this.passwordPnl.BackColor = System.Drawing.Color.LightGray;
            this.passwordPnl.Controls.Add(this.passwordTxt);
            this.passwordPnl.Location = new System.Drawing.Point(77, 303);
            this.passwordPnl.Name = "passwordPnl";
            this.passwordPnl.Size = new System.Drawing.Size(418, 42);
            this.passwordPnl.TabIndex = 59;
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
            this.passwordTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 58;
            this.label4.Text = "Password";
            // 
            // loginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 723);
            this.Controls.Add(this.passwordPnl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPasswordCbx);
            this.Controls.Add(this.registerLinkLbl);
            this.Controls.Add(this.registerLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.titleLbl);
            this.Name = "loginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Appliance Rental System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginFrm_FormClosing);
            this.Load += new System.EventHandler(this.loginFrm_Load);
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.passwordPnl.ResumeLayout(false);
            this.passwordPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel registerLinkLbl;
        private System.Windows.Forms.Label registerLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.CheckBox showPasswordCbx;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel passwordPnl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label4;
    }
}