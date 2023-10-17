using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Appliance_Rental_Application
{
    public partial class changeUserPasswordFrm : Form
    {
        public changeUserPasswordFrm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Home Appliance Rental Application\Home Appliance Rental Application\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                MessageBox.Show("Please enter a password", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTxt.Focus();
                return;
            }
            else if (!Regex.Match(passwordTxt.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,32}$").Success)
            {
                MessageBox.Show("The password you entered is too weak. Your password should contain between 8 and 32 characters, at least one digit, at least one uppercase letter, at least one lowercase letter and at least one special character.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTxt.Focus();
                return;
            }
            else
            {

                var password = encrypt.HashString(passwordTxt.Text);

                cmd = new SqlCommand("UPDATE users SET user_password = '" + password + "' WHERE Id = " + userManagmentFrm.userID, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password updated successfully", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
