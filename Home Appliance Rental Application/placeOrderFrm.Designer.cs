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
            this.label6 = new System.Windows.Forms.Label();
            this.quantityDud = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
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
            this.cartTab = new System.Windows.Forms.TabPage();
            this.orderItemsLbx = new System.Windows.Forms.ListBox();
            this.confirmOrderBtn = new System.Windows.Forms.Button();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.appliancesTab.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(1242, 942);
            this.tabControl.TabIndex = 0;
            // 
            // appliancesTab
            // 
            this.appliancesTab.Controls.Add(this.label6);
            this.appliancesTab.Controls.Add(this.quantityDud);
            this.appliancesTab.Controls.Add(this.button1);
            this.appliancesTab.Controls.Add(this.label5);
            this.appliancesTab.Controls.Add(this.quickSearchTxt);
            this.appliancesTab.Controls.Add(this.appliancesDgv);
            this.appliancesTab.Controls.Add(this.sortBtn);
            this.appliancesTab.Controls.Add(this.sortCbx);
            this.appliancesTab.Controls.Add(this.label3);
            this.appliancesTab.Controls.Add(this.label4);
            this.appliancesTab.Controls.Add(this.brandCbx);
            this.appliancesTab.Controls.Add(this.filterBtn);
            this.appliancesTab.Controls.Add(this.lblBrand);
            this.appliancesTab.Controls.Add(this.typeCbx);
            this.appliancesTab.Controls.Add(this.label2);
            this.appliancesTab.Controls.Add(this.label1);
            this.appliancesTab.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appliancesTab.Location = new System.Drawing.Point(4, 45);
            this.appliancesTab.Name = "appliancesTab";
            this.appliancesTab.Padding = new System.Windows.Forms.Padding(3);
            this.appliancesTab.Size = new System.Drawing.Size(1234, 893);
            this.appliancesTab.TabIndex = 0;
            this.appliancesTab.Text = "Appliances";
            this.appliancesTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 826);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 36);
            this.label6.TabIndex = 62;
            this.label6.Text = "Quantity:";
            // 
            // quantityDud
            // 
            this.quantityDud.Font = new System.Drawing.Font("Poppins Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityDud.Items.Add("1");
            this.quantityDud.Items.Add("2");
            this.quantityDud.Items.Add("3");
            this.quantityDud.Items.Add("4");
            this.quantityDud.Items.Add("5");
            this.quantityDud.Items.Add("6");
            this.quantityDud.Items.Add("7");
            this.quantityDud.Items.Add("8");
            this.quantityDud.Items.Add("9");
            this.quantityDud.Items.Add("10");
            this.quantityDud.Location = new System.Drawing.Point(137, 824);
            this.quantityDud.Name = "quantityDud";
            this.quantityDud.Size = new System.Drawing.Size(77, 34);
            this.quantityDud.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(883, 815);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 53);
            this.button1.TabIndex = 60;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 36);
            this.label5.TabIndex = 59;
            this.label5.Text = "QUICK SEARCH:";
            // 
            // quickSearchTxt
            // 
            this.quickSearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickSearchTxt.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSearchTxt.Location = new System.Drawing.Point(203, 269);
            this.quickSearchTxt.Name = "quickSearchTxt";
            this.quickSearchTxt.Size = new System.Drawing.Size(538, 37);
            this.quickSearchTxt.TabIndex = 58;
            // 
            // appliancesDgv
            // 
            this.appliancesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appliancesDgv.Location = new System.Drawing.Point(24, 332);
            this.appliancesDgv.Name = "appliancesDgv";
            this.appliancesDgv.RowHeadersWidth = 62;
            this.appliancesDgv.RowTemplate.Height = 28;
            this.appliancesDgv.Size = new System.Drawing.Size(1183, 455);
            this.appliancesDgv.TabIndex = 57;
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBtn.ForeColor = System.Drawing.Color.White;
            this.sortBtn.Location = new System.Drawing.Point(883, 169);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(324, 53);
            this.sortBtn.TabIndex = 56;
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
            this.sortCbx.Location = new System.Drawing.Point(883, 95);
            this.sortCbx.Name = "sortCbx";
            this.sortCbx.Size = new System.Drawing.Size(324, 44);
            this.sortCbx.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(877, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 54;
            this.label3.Text = "Sort By";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(877, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 31);
            this.label4.TabIndex = 53;
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
            this.brandCbx.Location = new System.Drawing.Point(403, 95);
            this.brandCbx.Name = "brandCbx";
            this.brandCbx.Size = new System.Drawing.Size(324, 44);
            this.brandCbx.TabIndex = 52;
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBtn.ForeColor = System.Drawing.Color.White;
            this.filterBtn.Location = new System.Drawing.Point(24, 169);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(324, 53);
            this.filterBtn.TabIndex = 51;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = false;
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(397, 55);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(93, 33);
            this.lblBrand.TabIndex = 50;
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
            this.typeCbx.Location = new System.Drawing.Point(24, 95);
            this.typeCbx.Name = "typeCbx";
            this.typeCbx.Size = new System.Drawing.Size(324, 44);
            this.typeCbx.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 31);
            this.label2.TabIndex = 48;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "FILTER";
            // 
            // cartTab
            // 
            this.cartTab.Controls.Add(this.label7);
            this.cartTab.Controls.Add(this.removeItemBtn);
            this.cartTab.Controls.Add(this.confirmOrderBtn);
            this.cartTab.Controls.Add(this.orderItemsLbx);
            this.cartTab.Location = new System.Drawing.Point(4, 45);
            this.cartTab.Name = "cartTab";
            this.cartTab.Padding = new System.Windows.Forms.Padding(3);
            this.cartTab.Size = new System.Drawing.Size(1234, 893);
            this.cartTab.TabIndex = 1;
            this.cartTab.Text = "Cart";
            this.cartTab.UseVisualStyleBackColor = true;
            // 
            // orderItemsLbx
            // 
            this.orderItemsLbx.Font = new System.Drawing.Font("Poppins Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderItemsLbx.FormattingEnabled = true;
            this.orderItemsLbx.ItemHeight = 50;
            this.orderItemsLbx.Location = new System.Drawing.Point(47, 43);
            this.orderItemsLbx.Name = "orderItemsLbx";
            this.orderItemsLbx.Size = new System.Drawing.Size(1131, 604);
            this.orderItemsLbx.TabIndex = 0;
            // 
            // confirmOrderBtn
            // 
            this.confirmOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.confirmOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmOrderBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOrderBtn.ForeColor = System.Drawing.Color.White;
            this.confirmOrderBtn.Location = new System.Drawing.Point(472, 687);
            this.confirmOrderBtn.Name = "confirmOrderBtn";
            this.confirmOrderBtn.Size = new System.Drawing.Size(324, 53);
            this.confirmOrderBtn.TabIndex = 52;
            this.confirmOrderBtn.Text = "Confirm Order";
            this.confirmOrderBtn.UseVisualStyleBackColor = false;
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.removeItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemBtn.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemBtn.ForeColor = System.Drawing.Color.White;
            this.removeItemBtn.Location = new System.Drawing.Point(854, 687);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(324, 53);
            this.removeItemBtn.TabIndex = 53;
            this.removeItemBtn.Text = "Remove Item";
            this.removeItemBtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 691);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 42);
            this.label7.TabIndex = 54;
            this.label7.Text = "Total Cost:";
            // 
            // placeOrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 991);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "placeOrderFrm";
            this.Text = "customerAppliances";
            this.Load += new System.EventHandler(this.placeOrderFrm_Load);
            this.tabControl.ResumeLayout(false);
            this.appliancesTab.ResumeLayout(false);
            this.appliancesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesDgv)).EndInit();
            this.cartTab.ResumeLayout(false);
            this.cartTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage appliancesTab;
        private System.Windows.Forms.TabPage cartTab;
        private System.Windows.Forms.ComboBox brandCbx;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox typeCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ComboBox sortCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quickSearchTxt;
        private System.Windows.Forms.DataGridView appliancesDgv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DomainUpDown quantityDud;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox orderItemsLbx;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.Button confirmOrderBtn;
        private System.Windows.Forms.Label label7;
    }
}