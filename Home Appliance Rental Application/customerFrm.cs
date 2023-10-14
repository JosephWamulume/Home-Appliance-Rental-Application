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
    public partial class customerFrm : Form
    {
        public customerFrm()
        {
            InitializeComponent();
        }

        placeOrderFrm placeOrderFrm;
        myOrdersFrm myOrders;

        private void customerFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display confirmation message
            if (MessageBox.Show("Are you sure want to exit?",
                   "Home Appliance Rental System",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // Exit the application if user clicks 'Yes'
                Environment.Exit(0);
            }
            else
            {
                // Close confirmation message if user clicks 'No'
                e.Cancel = true;
            }
        }

        private void customerFrm_Load(object sender, EventArgs e)
        {
            if (placeOrderFrm == null)
            {
                placeOrderFrm = new placeOrderFrm();
                placeOrderFrm.FormClosed += PlaceOrderFrm_FormClosed;
                placeOrderFrm.MdiParent = this;
                placeOrderFrm.Show();
                placeOrderFrm.Dock = DockStyle.Fill;
                placeOrderBtn.BackColor = Color.FromArgb(60, 30, 102);
            }
            else
            {
                placeOrderFrm.Activate();
                placeOrderBtn.BackColor = Color.FromArgb(60, 30, 102);
            }

            lblUsername.Text = loginFrm.username;

        }

        private void PlaceOrderFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Display confirmation message is user clicks the 'Logout' button
            if (MessageBox.Show("Are you sure want to logout?",
                               "Home Appliance Rental System",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // If the user clicks 'Yes', return to login form
                // Create instance of login form
                loginFrm fl = new loginFrm();
                // Display login form
                fl.Show();
                // Hide this form
                this.Hide();
            }
            else
            {
                // Close confirmation message if the user clicks 'No'
                return;
            }
        }

        private void myOrdersBtn_Click(object sender, EventArgs e)
        {
            if (myOrders == null)
            {
                myOrders = new myOrdersFrm();
                myOrders.FormClosed += MyOrders_FormClosed;
                myOrders.MdiParent = this;
                myOrders.Show();
                myOrders.Dock = DockStyle.Fill;
                placeOrderBtn.BackColor = Color.FromArgb(113, 58, 190);
                myOrdersBtn.BackColor = Color.FromArgb(60, 30, 102);
            }
            else
            {
                myOrders.Activate();
                placeOrderBtn.BackColor = Color.FromArgb(113, 58, 190);
                myOrdersBtn.BackColor = Color.FromArgb(60, 30, 102);
            }
        }

        private void MyOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            if (placeOrderFrm == null)
            {
                placeOrderFrm = new placeOrderFrm();
                placeOrderFrm.FormClosed += PlaceOrderFrm_FormClosed;
                placeOrderFrm.MdiParent = this;
                placeOrderFrm.Show();
                placeOrderFrm.Dock = DockStyle.Fill;
                placeOrderBtn.BackColor = Color.FromArgb(60, 30, 102);
                myOrdersBtn.BackColor = Color.FromArgb(113, 58, 190);
            }
            else
            {
                placeOrderFrm.Activate();
                placeOrderBtn.BackColor = Color.FromArgb(60, 30, 102);
                myOrdersBtn.BackColor = Color.FromArgb(113, 58, 190);
            }
        }
    }
}
