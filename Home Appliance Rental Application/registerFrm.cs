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
    public partial class registerFrm : Form
    {
        public registerFrm()
        {
            InitializeComponent();
        }

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Home Appliance Rental Application\Home Appliance Rental Application\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        private void registerFrm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void loginLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create instance of login form
            var loginform = new loginFrm();
            // Display login form
            loginform.Show();
            // Hide current form
            this.Hide();
        }

        private void showPasswordCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCbx.Checked == false)
            {
                // Change the password characters to hidden format
                passwordTxt.PasswordChar = '•';
                repeatPasswordTxt.PasswordChar = '•';
            } 
            else
            {
                // Change the password characters to normal format
                passwordTxt.PasswordChar = '\0';
                repeatPasswordTxt.PasswordChar = '\0';
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            // Validation For Empty Fields and Invalid Inputs

            if (String.IsNullOrWhiteSpace(usernameTxt.Text))
            {
                // Display error message if user leaves the 'Username' text field empty
                MessageBox.Show("Please enter your username.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the 'First Name' text field so that the user can type their input
                usernameTxt.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrWhiteSpace(phoneNumberTxt.Text))
            {
                // Display error message if user leaves the phone number text field empty
                MessageBox.Show("Please enter your phone number.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the phone number text field so that the user can type their input
                phoneNumberTxt.Focus();
                // Terminate the event handler
                return;
            }
            else if (cityTownCbx.SelectedItem == null)
            {
                // Display error message if user leaves the city/town text field empty
                MessageBox.Show("Please enter your city/town.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the city/town text field so that the user can type their input
                cityTownCbx.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrWhiteSpace(residentialAddressTxt.Text))
            {
                // Display error message if user leaves the address text field empty
                MessageBox.Show("Please enter your residential address.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the address text field so that the user can type their input
                residentialAddressTxt.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                // Display error message if user leaves the password text field empty
                MessageBox.Show("Please enter a password.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the password text field so that the user can type their input
                passwordTxt.Focus();
                // Terminate the event handler
                return;
            }
            else if (!Regex.Match(passwordTxt.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,32}$").Success)
            {
                // Display an error message if the user enters a password that is less than 8 characters long
                MessageBox.Show("The password you entered is too weak. Your password should contain between 8 and 32 characters, at least one digit, at least one uppercase letter, at least one lowercase letter and at least one special character.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the password text field so that the user can retype their input
                passwordTxt.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrWhiteSpace(repeatPasswordTxt.Text))
            {
                // Display error message if user leaves the repeat password text field empty
                MessageBox.Show("Please repeat your password.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the repeat password text field so that the user can type their input
                repeatPasswordTxt.Focus();
                // Terminate the event handler
                return;
            }

            // Check if passwords match

            else if (passwordTxt.Text != repeatPasswordTxt.Text)
            {
                // Display an error message if the user enters a password that is less than 8 characters long
                MessageBox.Show("Your passwords do not match.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the password text field so that the user can retype their input
                passwordTxt.Focus();
                // Terminate the event handler
                return;
            }
            else
            {
                // Check if username already exists in users table

                // Open database connection
                con.Open();
                // Select all users with a username that matches the user's input
                cmd = new SqlCommand("SELECT * FROM users WHERE username='" + usernameTxt.Text + "'", con);
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                // Close database connection
                con.Close();
                // Check if there is a matching record in the 'users' table
                if (i > 0)
                {
                    // If the record search is positive, display an error message
                    MessageBox.Show("A user with this username already exists. If this is you, please navigate to the login screen. If not, please type in a different username.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Set focus back the username text field so that the user can retype their input
                    usernameTxt.Focus();
                    // Terminate the event handler
                    return;
                }
                else
                {

                    // Call password hashing class to hash password 
                    var password = encrypt.HashString(passwordTxt.Text);

                    // Insert consumer information into 'users' table
                    cmd = new SqlCommand("INSERT INTO users (username, phone_number, city_town, residential_address, user_password, user_type, status) VALUES ('" + (usernameTxt.Text).Trim() + "', '" + (phoneNumberTxt.Text).Trim() + "', '" + (cityTownCbx.Text).Trim() + "', '" + (residentialAddressTxt.Text).Trim() + "', '" + password + "', 'customer', 'Enabled')", con);
                    // Open database connection
                    con.Open();
                    // Execute query
                    cmd.ExecuteNonQuery();
                    // Close database connection
                    con.Close();
                    // Display success message
                    MessageBox.Show("Your registeration has been completed successfully!", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Hide registration form
                    this.Hide();
                    // Create instance of login form
                    var loginform = new loginFrm();
                    // Display login form
                    loginform.Show();
                }
            }
        }
    }
}
