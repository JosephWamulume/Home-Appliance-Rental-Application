namespace Home_Appliance_Rental_Application
{
    partial class updateOrderStatusFrm
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
            this.orderStutusCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderStutusCbx
            // 
            this.orderStutusCbx.BackColor = System.Drawing.Color.LightGray;
            this.orderStutusCbx.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStutusCbx.FormattingEnabled = true;
            this.orderStutusCbx.ItemHeight = 36;
            this.orderStutusCbx.Items.AddRange(new object[] {
            "Processing",
            "Delivering",
            "Delivered"});
            this.orderStutusCbx.Location = new System.Drawing.Point(68, 107);
            this.orderStutusCbx.Name = "orderStutusCbx";
            this.orderStutusCbx.Size = new System.Drawing.Size(417, 44);
            this.orderStutusCbx.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 36);
            this.label1.TabIndex = 62;
            this.label1.Text = "Order Status";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(68, 216);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(417, 53);
            this.loginBtn.TabIndex = 63;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // updateOrderStatusFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 339);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.orderStutusCbx);
            this.Controls.Add(this.label1);
            this.Name = "updateOrderStatusFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Order Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orderStutusCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
    }
}