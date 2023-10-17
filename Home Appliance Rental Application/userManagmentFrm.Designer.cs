namespace Home_Appliance_Rental_Application
{
    partial class userManagmentFrm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.quickSearchTxt = new System.Windows.Forms.TextBox();
            this.usersDgv = new System.Windows.Forms.DataGridView();
            this.renableAccountBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.quickSearchTxt);
            this.groupBox2.Controls.Add(this.usersDgv);
            this.groupBox2.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1474, 862);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Users";
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.changePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.ForeColor = System.Drawing.Color.White;
            this.changePasswordBtn.Location = new System.Drawing.Point(43, 950);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(324, 53);
            this.changePasswordBtn.TabIndex = 68;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 36);
            this.label5.TabIndex = 61;
            this.label5.Text = "Username: ";
            // 
            // quickSearchTxt
            // 
            this.quickSearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickSearchTxt.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSearchTxt.Location = new System.Drawing.Point(150, 52);
            this.quickSearchTxt.Name = "quickSearchTxt";
            this.quickSearchTxt.Size = new System.Drawing.Size(538, 37);
            this.quickSearchTxt.TabIndex = 60;
            // 
            // usersDgv
            // 
            this.usersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDgv.Location = new System.Drawing.Point(19, 114);
            this.usersDgv.Name = "usersDgv";
            this.usersDgv.RowHeadersWidth = 62;
            this.usersDgv.RowTemplate.Height = 28;
            this.usersDgv.Size = new System.Drawing.Size(1434, 727);
            this.usersDgv.TabIndex = 0;
            // 
            // renableAccountBtn
            // 
            this.renableAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.renableAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renableAccountBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renableAccountBtn.ForeColor = System.Drawing.Color.White;
            this.renableAccountBtn.Location = new System.Drawing.Point(447, 950);
            this.renableAccountBtn.Name = "renableAccountBtn";
            this.renableAccountBtn.Size = new System.Drawing.Size(324, 53);
            this.renableAccountBtn.TabIndex = 70;
            this.renableAccountBtn.Text = "Renable Account";
            this.renableAccountBtn.UseVisualStyleBackColor = false;
            this.renableAccountBtn.Click += new System.EventHandler(this.renableAccountBtn_Click);
            // 
            // userManagmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 1269);
            this.Controls.Add(this.renableAccountBtn);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userManagmentFrm";
            this.Text = "userManagmentFrm";
            this.Load += new System.EventHandler(this.userManagmentFrm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quickSearchTxt;
        private System.Windows.Forms.DataGridView usersDgv;
        private System.Windows.Forms.Button renableAccountBtn;
    }
}