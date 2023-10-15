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
    public partial class administratorFrm : Form
    {
        public administratorFrm()
        {
            InitializeComponent();
        }

        appliancesFrm appliancesFrm;
        addApplianceFrm addApplianceFrm;
        orderManagementFrm orderManagementFrm;
        userManagmentFrm userManagmentFrm;

        private appliancesFrm appliancesFrmRefresh;

        public administratorFrm(appliancesFrm appliancesFrmRefresh)
        {
            this.appliancesFrm = appliancesFrmRefresh;
        }


        private void administratorFrm_Load(object sender, EventArgs e)
        {
            if (appliancesFrm == null)
            {
                appliancesFrm = new appliancesFrm();
                appliancesFrm.FormClosed += AppliancesFrm_FormClosed;
                appliancesFrm.MdiParent = this;
                appliancesFrm.Show();
                appliancesFrm.Dock = DockStyle.Fill;
                appliancesBtn.BackColor = Color.FromArgb(60, 30, 102);
            }
            else
            {
                appliancesFrm.Activate();
                appliancesBtn.BackColor = Color.FromArgb(60, 30, 102);
            }

            lblUsername.Text = loginFrm.username;

        }

        private void administratorFrm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void appliancesBtn_Click(object sender, EventArgs e)
        {
            if (appliancesFrm == null)
            {
                appliancesFrm = new appliancesFrm();
                appliancesFrm.FormClosed += AppliancesFrm_FormClosed;
                appliancesFrm.MdiParent = this;
                appliancesFrm.Show();
                appliancesFrm.Dock = DockStyle.Fill;
                appliancesBtn.BackColor = Color.FromArgb(60, 30, 102);
                addApplianceBtn.BackColor = Color.FromArgb(113, 58, 190);
                orderManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
                userManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
            }
            else
            {
                appliancesFrm.Activate();
                appliancesBtn.BackColor = Color.FromArgb(60, 30, 102);
                addApplianceBtn.BackColor = Color.FromArgb(113, 58, 190);
                orderManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
                userManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
            }

            appliancesFrm.RefreshMyDataGridView();

        }

        private void AppliancesFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void addApplianceBtn_Click(object sender, EventArgs e)
        {
            if (addApplianceFrm == null)
            {
                addApplianceFrm = new addApplianceFrm();
                addApplianceFrm.FormClosed += AddApplianceFrm_FormClosed; ;
                addApplianceFrm.MdiParent = this;
                addApplianceFrm.Show();
                addApplianceFrm.Dock = DockStyle.Fill;
                addApplianceBtn.BackColor = Color.FromArgb(60, 30, 102);
                appliancesBtn.BackColor = Color.FromArgb(113, 58, 190);
                orderManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
                userManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
            }
            else
            {
                addApplianceFrm.Activate();
                addApplianceBtn.BackColor = Color.FromArgb(60, 30, 102);
                appliancesBtn.BackColor = Color.FromArgb(113, 58, 190);
                orderManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
                userManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
            }
        }

        private void AddApplianceFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void orderManagementBtn_Click(object sender, EventArgs e)
        {
            if (orderManagementFrm == null)
            {
                orderManagementFrm = new orderManagementFrm();
                orderManagementFrm.FormClosed += OrderManagementFrm_FormClosed; ;
                orderManagementFrm.MdiParent = this;
                orderManagementFrm.Show();
                orderManagementFrm.Dock = DockStyle.Fill;
                orderManagementBtn.BackColor = Color.FromArgb(60, 30, 102);
                appliancesBtn.BackColor = Color.FromArgb(113, 58, 190);
                addApplianceBtn.BackColor = Color.FromArgb(113, 58, 190);
                userManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
            }
            else
            {
                orderManagementFrm.Activate();
                orderManagementBtn.BackColor = Color.FromArgb(60, 30, 102);
                appliancesBtn.BackColor = Color.FromArgb(113, 58, 190);
                addApplianceBtn.BackColor = Color.FromArgb(113, 58, 190);
                userManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
            }
        }

        private void OrderManagementFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void userManagementBtn_Click(object sender, EventArgs e)
        {
            if (userManagmentFrm == null)
            {
                userManagmentFrm = new userManagmentFrm();
                userManagmentFrm.FormClosed += UserManagmentFrm_FormClosed; ;
                userManagmentFrm.MdiParent = this;
                userManagmentFrm.Show();
                userManagmentFrm.Dock = DockStyle.Fill;
                userManagementBtn.BackColor = Color.FromArgb(60, 30, 102);
                appliancesBtn.BackColor = Color.FromArgb(113, 58, 190);
                addApplianceBtn.BackColor = Color.FromArgb(113, 58, 190);
                orderManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
            }
            else
            {
                userManagmentFrm.Activate();
                userManagementBtn.BackColor = Color.FromArgb(60, 30, 102);
                appliancesBtn.BackColor = Color.FromArgb(113, 58, 190);
                addApplianceBtn.BackColor = Color.FromArgb(113, 58, 190);
                orderManagementBtn.BackColor = Color.FromArgb(113, 58, 190);
            }
        }

        private void UserManagmentFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
