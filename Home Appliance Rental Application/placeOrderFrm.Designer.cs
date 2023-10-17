namespace Home_Appliance_Rental_Application
{
    partial class placeOrderFrm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.appliancesTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchConditionsLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.quickSearchTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearSortBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sortCbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearFilterBtn = new System.Windows.Forms.Button();
            this.typeCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.filterBtn = new System.Windows.Forms.Button();
            this.brandCbx = new System.Windows.Forms.ComboBox();
            this.appliancesDgv = new System.Windows.Forms.DataGridView();
            this.cartTab = new System.Windows.Forms.TabPage();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.confirmOrderBtn = new System.Windows.Forms.Button();
            this.orderItemsLbx = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.appliancesTab.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesDgv)).BeginInit();
            this.cartTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.appliancesTab);
            this.tabControl.Controls.Add(this.cartTab);
            this.tabControl.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1540, 1224);
            this.tabControl.TabIndex = 0;
            // 
            // appliancesTab
            // 
            this.appliancesTab.Controls.Add(this.label1);
            this.appliancesTab.Controls.Add(this.panel5);
            this.appliancesTab.Controls.Add(this.addToCartBtn);
            this.appliancesTab.Controls.Add(this.refreshBtn);
            this.appliancesTab.Controls.Add(this.groupBox4);
            this.appliancesTab.Controls.Add(this.groupBox3);
            this.appliancesTab.Controls.Add(this.groupBox2);
            this.appliancesTab.Controls.Add(this.groupBox1);
            this.appliancesTab.Controls.Add(this.appliancesDgv);
            this.appliancesTab.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appliancesTab.Location = new System.Drawing.Point(4, 45);
            this.appliancesTab.Name = "appliancesTab";
            this.appliancesTab.Padding = new System.Windows.Forms.Padding(3);
            this.appliancesTab.Size = new System.Drawing.Size(1532, 1175);
            this.appliancesTab.TabIndex = 0;
            this.appliancesTab.Text = "Appliances";
            this.appliancesTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(773, 1100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 70;
            this.label1.Text = "Quantity:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.quantityUpDown);
            this.panel5.Location = new System.Drawing.Point(897, 1096);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(90, 42);
            this.panel5.TabIndex = 87;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.BackColor = System.Drawing.Color.LightGray;
            this.quantityUpDown.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityUpDown.Location = new System.Drawing.Point(3, 2);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(84, 37);
            this.quantityUpDown.TabIndex = 72;
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.BackColor = System.Drawing.Color.Green;
            this.addToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartBtn.ForeColor = System.Drawing.Color.White;
            this.addToCartBtn.Location = new System.Drawing.Point(1035, 1091);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(465, 53);
            this.addToCartBtn.TabIndex = 86;
            this.addToCartBtn.Text = "Add to Cart";
            this.addToCartBtn.UseVisualStyleBackColor = false;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(33, 1091);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(288, 53);
            this.refreshBtn.TabIndex = 85;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchConditionsLbl);
            this.groupBox4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(951, 383);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(549, 136);
            this.groupBox4.TabIndex = 84;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SEARCH CONDITIONS";
            this.groupBox4.Visible = false;
            // 
            // searchConditionsLbl
            // 
            this.searchConditionsLbl.BackColor = System.Drawing.Color.White;
            this.searchConditionsLbl.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchConditionsLbl.ForeColor = System.Drawing.Color.Black;
            this.searchConditionsLbl.Location = new System.Drawing.Point(21, 42);
            this.searchConditionsLbl.Name = "searchConditionsLbl";
            this.searchConditionsLbl.Size = new System.Drawing.Size(508, 91);
            this.searchConditionsLbl.TabIndex = 0;
            this.searchConditionsLbl.Text = "There are currently no search terms selected or entered";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.quickSearchTxt);
            this.groupBox3.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(33, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 136);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QUICK SEARCH";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearSortBtn);
            this.groupBox2.Controls.Add(this.sortBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sortCbx);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(951, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 331);
            this.groupBox2.TabIndex = 83;
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
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click_1);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearFilterBtn);
            this.groupBox1.Controls.Add(this.typeCbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Controls.Add(this.filterBtn);
            this.groupBox1.Controls.Add(this.brandCbx);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 331);
            this.groupBox1.TabIndex = 81;
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
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(453, 42);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(93, 33);
            this.lblBrand.TabIndex = 63;
            this.lblBrand.Text = "Brand";
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
            // appliancesDgv
            // 
            this.appliancesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appliancesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appliancesDgv.GridColor = System.Drawing.Color.Thistle;
            this.appliancesDgv.Location = new System.Drawing.Point(33, 563);
            this.appliancesDgv.Name = "appliancesDgv";
            this.appliancesDgv.RowHeadersWidth = 62;
            this.appliancesDgv.RowTemplate.Height = 28;
            this.appliancesDgv.Size = new System.Drawing.Size(1467, 488);
            this.appliancesDgv.TabIndex = 80;
            // 
            // cartTab
            // 
            this.cartTab.Controls.Add(this.lblTotalPrice);
            this.cartTab.Controls.Add(this.removeItemBtn);
            this.cartTab.Controls.Add(this.confirmOrderBtn);
            this.cartTab.Controls.Add(this.orderItemsLbx);
            this.cartTab.Location = new System.Drawing.Point(4, 45);
            this.cartTab.Name = "cartTab";
            this.cartTab.Padding = new System.Windows.Forms.Padding(3);
            this.cartTab.Size = new System.Drawing.Size(1532, 1175);
            this.cartTab.TabIndex = 1;
            this.cartTab.Text = "Cart";
            this.cartTab.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(40, 691);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(148, 42);
            this.lblTotalPrice.TabIndex = 54;
            this.lblTotalPrice.Text = "Total Cost:";
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.BackColor = System.Drawing.Color.Red;
            this.removeItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemBtn.ForeColor = System.Drawing.Color.White;
            this.removeItemBtn.Location = new System.Drawing.Point(770, 680);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(324, 53);
            this.removeItemBtn.TabIndex = 53;
            this.removeItemBtn.Text = "Remove Item";
            this.removeItemBtn.UseVisualStyleBackColor = false;
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // confirmOrderBtn
            // 
            this.confirmOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.confirmOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmOrderBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOrderBtn.ForeColor = System.Drawing.Color.White;
            this.confirmOrderBtn.Location = new System.Drawing.Point(1158, 680);
            this.confirmOrderBtn.Name = "confirmOrderBtn";
            this.confirmOrderBtn.Size = new System.Drawing.Size(324, 53);
            this.confirmOrderBtn.TabIndex = 52;
            this.confirmOrderBtn.Text = "Confirm Order";
            this.confirmOrderBtn.UseVisualStyleBackColor = false;
            this.confirmOrderBtn.Click += new System.EventHandler(this.confirmOrderBtn_Click);
            // 
            // orderItemsLbx
            // 
            this.orderItemsLbx.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItemsLbx.FormattingEnabled = true;
            this.orderItemsLbx.ItemHeight = 36;
            this.orderItemsLbx.Location = new System.Drawing.Point(47, 43);
            this.orderItemsLbx.Name = "orderItemsLbx";
            this.orderItemsLbx.Size = new System.Drawing.Size(1435, 580);
            this.orderItemsLbx.TabIndex = 0;
            // 
            // placeOrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 1269);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "placeOrderFrm";
            this.Text = "customerAppliances";
            this.Load += new System.EventHandler(this.placeOrderFrm_Load);
            this.tabControl.ResumeLayout(false);
            this.appliancesTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appliancesDgv)).EndInit();
            this.cartTab.ResumeLayout(false);
            this.cartTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage appliancesTab;
        private System.Windows.Forms.TabPage cartTab;
        private System.Windows.Forms.ListBox orderItemsLbx;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.Button confirmOrderBtn;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label searchConditionsLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox quickSearchTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearSortBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sortCbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearFilterBtn;
        private System.Windows.Forms.ComboBox typeCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.ComboBox brandCbx;
        private System.Windows.Forms.DataGridView appliancesDgv;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.Label label1;
    }
}