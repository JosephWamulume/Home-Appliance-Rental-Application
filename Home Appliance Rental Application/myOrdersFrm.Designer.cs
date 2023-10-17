namespace Home_Appliance_Rental_Application
{
    partial class myOrdersFrm
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
            this.orderItemsLbx = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orderNumberTxt = new System.Windows.Forms.TextBox();
            this.myOrdersDgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myOrdersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // orderItemsLbx
            // 
            this.orderItemsLbx.FormattingEnabled = true;
            this.orderItemsLbx.ItemHeight = 36;
            this.orderItemsLbx.Location = new System.Drawing.Point(19, 49);
            this.orderItemsLbx.Name = "orderItemsLbx";
            this.orderItemsLbx.Size = new System.Drawing.Size(1435, 508);
            this.orderItemsLbx.TabIndex = 63;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderItemsLbx);
            this.groupBox1.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 647);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1475, 578);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Items";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.orderNumberTxt);
            this.groupBox2.Controls.Add(this.myOrdersDgv);
            this.groupBox2.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(41, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1475, 580);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 36);
            this.label5.TabIndex = 61;
            this.label5.Text = "Order Number:";
            // 
            // orderNumberTxt
            // 
            this.orderNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderNumberTxt.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumberTxt.Location = new System.Drawing.Point(198, 51);
            this.orderNumberTxt.Name = "orderNumberTxt";
            this.orderNumberTxt.Size = new System.Drawing.Size(538, 37);
            this.orderNumberTxt.TabIndex = 60;
            this.orderNumberTxt.TextChanged += new System.EventHandler(this.orderNumberTxt_TextChanged);
            // 
            // myOrdersDgv
            // 
            this.myOrdersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myOrdersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myOrdersDgv.Location = new System.Drawing.Point(19, 114);
            this.myOrdersDgv.Name = "myOrdersDgv";
            this.myOrdersDgv.RowHeadersWidth = 62;
            this.myOrdersDgv.RowTemplate.Height = 28;
            this.myOrdersDgv.Size = new System.Drawing.Size(1435, 433);
            this.myOrdersDgv.TabIndex = 0;
            this.myOrdersDgv.SelectionChanged += new System.EventHandler(this.myOrdersDgv_SelectionChanged);
            // 
            // myOrdersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 1269);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "myOrdersFrm";
            this.Text = "myOrderFrm";
            this.Load += new System.EventHandler(this.myOrdersFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myOrdersDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox orderItemsLbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView myOrdersDgv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderNumberTxt;
    }
}