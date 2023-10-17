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
            this.quickSearchTxt = new System.Windows.Forms.TextBox();
            this.appliancesDgv = new System.Windows.Forms.DataGridView();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.brandCbx = new System.Windows.Forms.ComboBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.typeCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearFilterBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearSortBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchConditionsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // quickSearchTxt
            // 
            this.quickSearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickSearchTxt.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSearchTxt.Location = new System.Drawing.Point(38, 56);
            this.quickSearchTxt.Name = "quickSearchTxt";
            this.quickSearchTxt.Size = new System.Drawing.Size(789, 37);
            this.quickSearchTxt.TabIndex = 71;
            this.quickSearchTxt.TextChanged += new System.EventHandler(this.quickSearchTxt_TextChanged);
            // 
            // appliancesDgv
            // 
            this.appliancesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appliancesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appliancesDgv.GridColor = System.Drawing.Color.Thistle;
            this.appliancesDgv.Location = new System.Drawing.Point(46, 577);
            this.appliancesDgv.Name = "appliancesDgv";
            this.appliancesDgv.RowHeadersWidth = 62;
            this.appliancesDgv.RowTemplate.Height = 28;
            this.appliancesDgv.Size = new System.Drawing.Size(1467, 525);
            this.appliancesDgv.TabIndex = 70;
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBtn.ForeColor = System.Drawing.Color.White;
            this.sortBtn.Location = new System.Drawing.Point(44, 156);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(465, 53);
            this.sortBtn.TabIndex = 69;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
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
            this.sortCbx.Location = new System.Drawing.Point(44, 82);
            this.sortCbx.Name = "sortCbx";
            this.sortCbx.Size = new System.Drawing.Size(465, 44);
            this.sortCbx.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 67;
            this.label3.Text = "Sort By";
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
            this.brandCbx.Location = new System.Drawing.Point(459, 82);
            this.brandCbx.Name = "brandCbx";
            this.brandCbx.Size = new System.Drawing.Size(368, 44);
            this.brandCbx.TabIndex = 65;
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBtn.ForeColor = System.Drawing.Color.White;
            this.filterBtn.Location = new System.Drawing.Point(38, 156);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(789, 53);
            this.filterBtn.TabIndex = 64;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(453, 42);
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
            "Refrigeration",
            "Television",
            "Washing & Cleaning",
            "Small Appliances"});
            this.typeCbx.Location = new System.Drawing.Point(38, 82);
            this.typeCbx.Name = "typeCbx";
            this.typeCbx.Size = new System.Drawing.Size(368, 44);
            this.typeCbx.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 31);
            this.label2.TabIndex = 61;
            this.label2.Text = "Type";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(1274, 1149);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(239, 53);
            this.deleteBtn.TabIndex = 73;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(991, 1149);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(239, 53);
            this.editBtn.TabIndex = 74;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(46, 1149);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(465, 53);
            this.refreshBtn.TabIndex = 75;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearFilterBtn);
            this.groupBox1.Controls.Add(this.typeCbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Controls.Add(this.filterBtn);
            this.groupBox1.Controls.Add(this.brandCbx);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 331);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER";
            // 
            // clearFilterBtn
            // 
            this.clearFilterBtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearFilterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.clearFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFilterBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFilterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.clearFilterBtn.Location = new System.Drawing.Point(38, 240);
            this.clearFilterBtn.Name = "clearFilterBtn";
            this.clearFilterBtn.Size = new System.Drawing.Size(789, 53);
            this.clearFilterBtn.TabIndex = 66;
            this.clearFilterBtn.Text = "Clear";
            this.clearFilterBtn.UseVisualStyleBackColor = false;
            this.clearFilterBtn.Click += new System.EventHandler(this.clearFilterBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearSortBtn);
            this.groupBox2.Controls.Add(this.sortBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sortCbx);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(964, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 331);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SORT";
            // 
            // clearSortBtn
            // 
            this.clearSortBtn.BackColor = System.Drawing.SystemColors.Control;
            this.clearSortBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.clearSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSortBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSortBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.clearSortBtn.Location = new System.Drawing.Point(44, 240);
            this.clearSortBtn.Name = "clearSortBtn";
            this.clearSortBtn.Size = new System.Drawing.Size(465, 53);
            this.clearSortBtn.TabIndex = 67;
            this.clearSortBtn.Text = "Clear";
            this.clearSortBtn.UseVisualStyleBackColor = false;
            this.clearSortBtn.Click += new System.EventHandler(this.clearSortBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.quickSearchTxt);
            this.groupBox3.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(46, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 136);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QUICK SEARCH";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchConditionsLbl);
            this.groupBox4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(964, 397);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(549, 136);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SEARCH CONDITIONS";
            // 
            // searchConditionsLbl
            // 
            this.searchConditionsLbl.BackColor = System.Drawing.SystemColors.Control;
            this.searchConditionsLbl.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchConditionsLbl.ForeColor = System.Drawing.Color.Black;
            this.searchConditionsLbl.Location = new System.Drawing.Point(21, 42);
            this.searchConditionsLbl.Name = "searchConditionsLbl";
            this.searchConditionsLbl.Size = new System.Drawing.Size(508, 91);
            this.searchConditionsLbl.TabIndex = 0;
            this.searchConditionsLbl.Text = "There are currently no search terms selected or entered";
            // 
            // appliancesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 1269);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.appliancesDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appliancesFrm";
            this.Text = "appliancesFrm";
            this.Load += new System.EventHandler(this.appliancesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appliancesDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox quickSearchTxt;
        private System.Windows.Forms.DataGridView appliancesDgv;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ComboBox sortCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox brandCbx;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox typeCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearFilterBtn;
        private System.Windows.Forms.Button clearSortBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label searchConditionsLbl;
    }
}