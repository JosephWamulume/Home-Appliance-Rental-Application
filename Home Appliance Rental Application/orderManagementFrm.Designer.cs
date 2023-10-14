namespace Home_Appliance_Rental_Application
{
    partial class orderManagementFrm
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ordersDgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderItemsLbx = new System.Windows.Forms.ListBox();
            this.updateStatusBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateStatusBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.ordersDgv);
            this.groupBox2.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1183, 438);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders";
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(198, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(538, 37);
            this.textBox1.TabIndex = 60;
            // 
            // ordersDgv
            // 
            this.ordersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDgv.Location = new System.Drawing.Point(19, 114);
            this.ordersDgv.Name = "ordersDgv";
            this.ordersDgv.RowHeadersWidth = 62;
            this.ordersDgv.RowTemplate.Height = 28;
            this.ordersDgv.Size = new System.Drawing.Size(1140, 300);
            this.ordersDgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderItemsLbx);
            this.groupBox1.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 438);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Items";
            // 
            // orderItemsLbx
            // 
            this.orderItemsLbx.FormattingEnabled = true;
            this.orderItemsLbx.ItemHeight = 36;
            this.orderItemsLbx.Location = new System.Drawing.Point(19, 49);
            this.orderItemsLbx.Name = "orderItemsLbx";
            this.orderItemsLbx.Size = new System.Drawing.Size(1140, 364);
            this.orderItemsLbx.TabIndex = 63;
            // 
            // updateStatusBtn
            // 
            this.updateStatusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.updateStatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStatusBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStatusBtn.ForeColor = System.Drawing.Color.White;
            this.updateStatusBtn.Location = new System.Drawing.Point(835, 42);
            this.updateStatusBtn.Name = "updateStatusBtn";
            this.updateStatusBtn.Size = new System.Drawing.Size(324, 53);
            this.updateStatusBtn.TabIndex = 68;
            this.updateStatusBtn.Text = "Update Status";
            this.updateStatusBtn.UseVisualStyleBackColor = false;
            // 
            // orderManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 991);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderManagementFrm";
            this.Text = "orderManagementFrm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView ordersDgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox orderItemsLbx;
        private System.Windows.Forms.Button updateStatusBtn;
    }
}