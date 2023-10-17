namespace Home_Appliance_Rental_Application
{
    partial class changeUserPasswordFrm
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
            this.passwordPnl = new System.Windows.Forms.Panel();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.passwordPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordPnl
            // 
            this.passwordPnl.BackColor = System.Drawing.Color.LightGray;
            this.passwordPnl.Controls.Add(this.passwordTxt);
            this.passwordPnl.Location = new System.Drawing.Point(73, 109);
            this.passwordPnl.Name = "passwordPnl";
            this.passwordPnl.Size = new System.Drawing.Size(418, 42);
            this.passwordPnl.TabIndex = 61;
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
            this.label4.Location = new System.Drawing.Point(66, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 60;
            this.label4.Text = "Password";
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColor = System.Drawing.Color.White;
            this.changePasswordBtn.Location = new System.Drawing.Point(72, 199);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(417, 53);
            this.changePasswordBtn.TabIndex = 64;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // changeUserPasswordFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 339);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.passwordPnl);
            this.Controls.Add(this.label4);
            this.Name = "changeUserPasswordFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change User Password";
            this.passwordPnl.ResumeLayout(false);
            this.passwordPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel passwordPnl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changePasswordBtn;
    }
}