namespace Home_Appliance_Rental_Application
{
    partial class splashFrm
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
            this.components = new System.ComponentModel.Container();
            this.titleLbl = new System.Windows.Forms.Label();
            this.progessBackPnl = new System.Windows.Forms.Panel();
            this.progessFrontPnl = new System.Windows.Forms.Panel();
            this.loadingLbl = new System.Windows.Forms.Label();
            this.progressTmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLbl.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold);
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.titleLbl.Location = new System.Drawing.Point(142, 142);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(543, 56);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Home Appliance Rental System";
            // 
            // progessBackPnl
            // 
            this.progessBackPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(102)))));
            this.progessBackPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progessBackPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progessBackPnl.Location = new System.Drawing.Point(0, 395);
            this.progessBackPnl.Name = "progessBackPnl";
            this.progessBackPnl.Size = new System.Drawing.Size(800, 55);
            this.progessBackPnl.TabIndex = 1;
            // 
            // progessFrontPnl
            // 
            this.progessFrontPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.progessFrontPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.progessFrontPnl.Location = new System.Drawing.Point(1, 395);
            this.progessFrontPnl.Name = "progessFrontPnl";
            this.progessFrontPnl.Size = new System.Drawing.Size(82, 55);
            this.progessFrontPnl.TabIndex = 2;
            // 
            // loadingLbl
            // 
            this.loadingLbl.AutoSize = true;
            this.loadingLbl.Font = new System.Drawing.Font("Poppins", 8F);
            this.loadingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(58)))), ((int)(((byte)(190)))));
            this.loadingLbl.Location = new System.Drawing.Point(317, 215);
            this.loadingLbl.Name = "loadingLbl";
            this.loadingLbl.Size = new System.Drawing.Size(162, 28);
            this.loadingLbl.TabIndex = 3;
            this.loadingLbl.Text = "Loading Resources";
            // 
            // progressTmr
            // 
            this.progressTmr.Enabled = true;
            this.progressTmr.Interval = 15;
            this.progressTmr.Tick += new System.EventHandler(this.progressTmr_Tick);
            // 
            // splashFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadingLbl);
            this.Controls.Add(this.progessFrontPnl);
            this.Controls.Add(this.progessBackPnl);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel progessBackPnl;
        private System.Windows.Forms.Panel progessFrontPnl;
        private System.Windows.Forms.Label loadingLbl;
        private System.Windows.Forms.Timer progressTmr;
    }
}

