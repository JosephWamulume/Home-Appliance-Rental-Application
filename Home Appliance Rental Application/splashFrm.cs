using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Appliance_Rental_Application
{
    public partial class splashFrm : Form
    {
        public splashFrm()
        {
            InitializeComponent();
        }

        private void progressTmr_Tick(object sender, EventArgs e)
        {
            progessFrontPnl.Width += 3;
            if (progessFrontPnl.Width >= 700)
            {
                // Stop progress timer if progress bar surpasses width of 700
                progressTmr.Stop();
                // Create instance of login form
                loginFrm loginFrm = new loginFrm();
                // Display login form
                loginFrm.Show();
                // Hide Splash Screen form
                this.Hide();
            }
        }
    }
}
