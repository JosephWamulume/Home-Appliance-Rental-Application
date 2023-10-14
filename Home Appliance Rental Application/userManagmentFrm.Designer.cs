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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changePasswordDisabledBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quickSearchDisabledTxt = new System.Windows.Forms.TextBox();
            this.disabledUsersDgv = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disabledUsersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changePasswordBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.quickSearchTxt);
            this.groupBox2.Controls.Add(this.usersDgv);
            this.groupBox2.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1183, 438);
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
            this.changePasswordBtn.Location = new System.Drawing.Point(835, 42);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(324, 53);
            this.changePasswordBtn.TabIndex = 68;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 36);
            this.label5.TabIndex = 61;
            this.label5.Text = "QUICK SEARCH:";
            // 
            // quickSearchTxt
            // 
            this.quickSearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickSearchTxt.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSearchTxt.Location = new System.Drawing.Point(198, 51);
            this.quickSearchTxt.Name = "quickSearchTxt";
            this.quickSearchTxt.Size = new System.Drawing.Size(538, 37);
            this.quickSearchTxt.TabIndex = 60;
            // 
            // usersDgv
            // 
            this.usersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDgv.Location = new System.Drawing.Point(19, 114);
            this.usersDgv.Name = "usersDgv";
            this.usersDgv.RowHeadersWidth = 62;
            this.usersDgv.RowTemplate.Height = 28;
            this.usersDgv.Size = new System.Drawing.Size(1140, 300);
            this.usersDgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changePasswordDisabledBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.quickSearchDisabledTxt);
            this.groupBox1.Controls.Add(this.disabledUsersDgv);
            this.groupBox1.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 438);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disabled Users";
            // 
            // changePasswordDisabledBtn
            // 
            this.changePasswordDisabledBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.changePasswordDisabledBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordDisabledBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordDisabledBtn.ForeColor = System.Drawing.Color.White;
            this.changePasswordDisabledBtn.Location = new System.Drawing.Point(835, 42);
            this.changePasswordDisabledBtn.Name = "changePasswordDisabledBtn";
            this.changePasswordDisabledBtn.Size = new System.Drawing.Size(324, 53);
            this.changePasswordDisabledBtn.TabIndex = 68;
            this.changePasswordDisabledBtn.Text = "Change Password";
            this.changePasswordDisabledBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 36);
            this.label1.TabIndex = 61;
            this.label1.Text = "QUICK SEARCH:";
            // 
            // quickSearchDisabledTxt
            // 
            this.quickSearchDisabledTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickSearchDisabledTxt.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSearchDisabledTxt.Location = new System.Drawing.Point(198, 51);
            this.quickSearchDisabledTxt.Name = "quickSearchDisabledTxt";
            this.quickSearchDisabledTxt.Size = new System.Drawing.Size(538, 37);
            this.quickSearchDisabledTxt.TabIndex = 60;
            // 
            // disabledUsersDgv
            // 
            this.disabledUsersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disabledUsersDgv.Location = new System.Drawing.Point(19, 114);
            this.disabledUsersDgv.Name = "disabledUsersDgv";
            this.disabledUsersDgv.RowHeadersWidth = 62;
            this.disabledUsersDgv.RowTemplate.Height = 28;
            this.disabledUsersDgv.Size = new System.Drawing.Size(1140, 300);
            this.disabledUsersDgv.TabIndex = 0;
            // 
            // userManagmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 991);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userManagmentFrm";
            this.Text = "userManagmentFrm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disabledUsersDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quickSearchTxt;
        private System.Windows.Forms.DataGridView usersDgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changePasswordDisabledBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quickSearchDisabledTxt;
        private System.Windows.Forms.DataGridView disabledUsersDgv;
    }
}