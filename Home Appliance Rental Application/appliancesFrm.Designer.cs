namespace Home_Appliance_Rental_Application
{
    partial class appliancesFrm
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
            this.label5 = new System.Windows.Forms.Label();
            this.quickSearchTxt = new System.Windows.Forms.TextBox();
            this.appliancesDgv = new System.Windows.Forms.DataGridView();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brandCbx = new System.Windows.Forms.ComboBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.typeCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 36);
            this.label5.TabIndex = 72;
            this.label5.Text = "QUICK SEARCH:";
            // 
            // quickSearchTxt
            // 
            this.quickSearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickSearchTxt.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSearchTxt.Location = new System.Drawing.Point(225, 295);
            this.quickSearchTxt.Name = "quickSearchTxt";
            this.quickSearchTxt.Size = new System.Drawing.Size(538, 37);
            this.quickSearchTxt.TabIndex = 71;
            // 
            // appliancesDgv
            // 
            this.appliancesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appliancesDgv.Location = new System.Drawing.Point(46, 375);
            this.appliancesDgv.Name = "appliancesDgv";
            this.appliancesDgv.RowHeadersWidth = 62;
            this.appliancesDgv.RowTemplate.Height = 28;
            this.appliancesDgv.Size = new System.Drawing.Size(1183, 455);
            this.appliancesDgv.TabIndex = 70;
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBtn.ForeColor = System.Drawing.Color.White;
            this.sortBtn.Location = new System.Drawing.Point(905, 195);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(324, 53);
            this.sortBtn.TabIndex = 69;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = false;
            // 
            // sortCbx
            // 
            this.sortCbx.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortCbx.FormattingEnabled = true;
            this.sortCbx.Items.AddRange(new object[] {
            "Price (High to Low)",
            "Price (Low to High)",
            "Energy Consumption (High to Low)",
            "Energy Consumption (Low to High)"});
            this.sortCbx.Location = new System.Drawing.Point(905, 121);
            this.sortCbx.Name = "sortCbx";
            this.sortCbx.Size = new System.Drawing.Size(324, 44);
            this.sortCbx.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(899, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 67;
            this.label3.Text = "Sort By";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(899, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 31);
            this.label4.TabIndex = 66;
            this.label4.Text = "SORT";
            // 
            // brandCbx
            // 
            this.brandCbx.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandCbx.FormattingEnabled = true;
            this.brandCbx.Items.AddRange(new object[] {
            "Defy",
            "LG",
            "Beko",
            "Bosch",
            "Panasonic"});
            this.brandCbx.Location = new System.Drawing.Point(425, 121);
            this.brandCbx.Name = "brandCbx";
            this.brandCbx.Size = new System.Drawing.Size(324, 44);
            this.brandCbx.TabIndex = 65;
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBtn.ForeColor = System.Drawing.Color.White;
            this.filterBtn.Location = new System.Drawing.Point(46, 195);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(324, 53);
            this.filterBtn.TabIndex = 64;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = false;
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(419, 81);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(93, 33);
            this.lblBrand.TabIndex = 63;
            this.lblBrand.Text = "Brand";
            // 
            // typeCbx
            // 
            this.typeCbx.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCbx.FormattingEnabled = true;
            this.typeCbx.Items.AddRange(new object[] {
            "Cooking",
            "Refridgeration",
            "Entertainment",
            "Washing & Cleaning",
            "Small Appliances"});
            this.typeCbx.Location = new System.Drawing.Point(46, 121);
            this.typeCbx.Name = "typeCbx";
            this.typeCbx.Size = new System.Drawing.Size(324, 44);
            this.typeCbx.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 31);
            this.label2.TabIndex = 61;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 31);
            this.label1.TabIndex = 60;
            this.label1.Text = "FILTER";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(905, 859);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(324, 53);
            this.deleteBtn.TabIndex = 73;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(505, 859);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(324, 53);
            this.editBtn.TabIndex = 74;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // appliancesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 991);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quickSearchTxt);
            this.Controls.Add(this.appliancesDgv);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.sortCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brandCbx);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.typeCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appliancesFrm";
            this.Text = "appliancesFrm";
            ((System.ComponentModel.ISupportInitialize)(this.appliancesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quickSearchTxt;
        private System.Windows.Forms.DataGridView appliancesDgv;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ComboBox sortCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox brandCbx;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox typeCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
    }
}