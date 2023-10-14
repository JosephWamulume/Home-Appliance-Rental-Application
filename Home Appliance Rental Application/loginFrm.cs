using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Home_Appliance_Rental_Application
{
    public partial class loginFrm : Form
    {
        public loginFrm()
        {
            InitializeComponent();
        }

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Home Appliance Rental Application\Home Appliance Rental Application\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        // Variables to store the number of login attempts
        int count, username_attempt, password_attempt;

        // Public string to store username and user ID
        public static string username;
        public static string userID;

        void disableForm()
        {
            // If number of failed login attempts equals three
            if (username_attempt == 5)
            {
                // Display message box notifying the user that the number of maximum login attempts has been exceeded
                MessageBox.Show("You have reached the maximum number of login attempts (5). Please contact an administrator to assist you with a password reset.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                username_attempt = 0;
                count = 60;
                usernameTxt.Enabled = false;
                passwordTxt.Enabled = false;
            }
        }

        void disableUser()
        {
            // If number of failed login attempts equals three
            if (password_attempt == 5)
            {
                // Insert username into 'disabled' table
                cmd = new SqlCommand("INSERT INTO disabled (username) VALUES ('" + usernameTxt.Text + "')", con);
                // Open database connection
                con.Open();
                // Execute query
                cmd.ExecuteNonQuery();
                // Close database connection
                con.Close();
            }
        }

        private void loginFrm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void registerLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create instance of 'Register' form
            var registerform = new registerFrm();
            // Display 'Register' form
            registerform.Show();
            // Hide current form
            this.Hide();
        }

        private void loginFrm_Load(object sender, EventArgs e)
        {

        }

        private void showPasswordCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCbx.Checked == false)
            {
                // Change the password characters to hidden format
                passwordTxt.PasswordChar = '•';
            }
            else
            {
                // Change the password characters to normal format
                passwordTxt.PasswordChar = '\0';
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Validate for empty fields

            if (String.IsNullOrWhiteSpace(usernameTxt.Text))
            {
                // Display error message if user leaves the username text field empty
                MessageBox.Show("Please enter your username", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the username text field so that the user can type the input
                usernameTxt.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                // Display error message if user leaves the password text field empty
                MessageBox.Show("Please enter your password", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the password text field so that the user can type the input
                passwordTxt.Focus();
                // Terminate the event handler
                return;
            }
            else
            {

                con.Open();
                cmd = new SqlCommand("SELECT * FROM disabled WHERE username='" + usernameTxt.Text + "'", con);
                da = new SqlDataAdapter(cmd);
                DataTable dttt = new DataTable();
                da.Fill(dttt);
                con.Close();
                int x = dttt.Rows.Count;
                if (x > 0)
                {
                    MessageBox.Show("Your account is disabled. Please contact an administrator for assistance.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Open database connection
                    con.Open();
                    // Check the users table for a username matching that which the user entered
                    cmd = new SqlCommand("SELECT * FROM users WHERE username='" + usernameTxt.Text + "'", con);
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    // Store retrieved rows in datatable
                    da.Fill(dt);
                    // Close database connection
                    con.Close();
                    // Store number of rows
                    int i = dt.Rows.Count;
                    // Check if there is a matching record in the 'users' table
                    if (i == 1)
                    {
                        // Check if user account is disabled
                        con.Open(); // Open database connection
                                    // Check the users table for a username matching that which the user entered
                        cmd = new SqlCommand("SELECT * FROM disabled WHERE username='" + usernameTxt.Text + "'", con);
                        da = new SqlDataAdapter(cmd);
                        DataTable dtt = new DataTable();
                        // Store retrieved rows in datatable
                        da.Fill(dtt);
                        // Close database connection
                        con.Close();
                        // Store number of rows
                        i = dtt.Rows.Count;
                        // If user account is disabled
                        if (i == 1)
                        {
                            // Display error message
                            MessageBox.Show("This account has been disabled. Please click the 'Forgot Password' link to reset your password or contact an administrator for assitance.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            // Call password hashing class to hash password 
                            var password = encrypt.HashString(passwordTxt.Text);

                            if (password == dt.Rows[0]["user_password"].ToString())
                            {
                                // If password is correct

                                username = dt.Rows[0]["username"].ToString();
                                userID = dt.Rows[0]["id"].ToString();

                                // Display a success message
                                MessageBox.Show("Login successful. Welcome " + username + "!", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // If the user is a consumer, open the consumer form
                                if (dt.Rows[0]["user_type"].ToString() == "customer")
                                {
                                    // Open consumer form
                                    customerFrm fm = new customerFrm();
                                    fm.Show();
                                    // Close database connection
                                    con.Close();
                                    // Hide login form
                                    this.Hide();
                                }
                                // If the user is an administrator, open the administrator form
                                else if (dt.Rows[0]["user_type"].ToString() == "administrator")
                                {
                                    // Open administrator form
                                    administratorFrm fm = new administratorFrm();
                                    // Close database connection
                                    con.Close();
                                    fm.Show();
                                    // Hide login form
                                    this.Hide();
                                }
                            }
                            // If password is not correct
                            else
                            {
                                // Display error message
                                MessageBox.Show("The password you entered is incorrect. Please try again.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // Close database connection
                                con.Close();
                                // Clear the password field
                                passwordTxt.Clear();
                                // Set focus to 'Password' text field so that the user can retype their input
                                passwordTxt.Focus();
                                // Increment the number of login attempts by 1
                                password_attempt = password_attempt + 1;
                                // Call the 'disable' function to check if the number of failed attempts has been succeeded
                                disableUser();
                                // Terminate the event handler and return to login form
                                return;
                            }
                        }
                    }
                    else
                    {
                        // If the records search is negative, display an error message
                        MessageBox.Show("The username you entered is incorrect. Please try again. If are a new user, please click the 'Register' link.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Close database connection
                        con.Close();
                        // Clear the username field
                        usernameTxt.Clear();
                        // Clear the password field
                        passwordTxt.Clear();
                        // Increment the number of login attempts by 1
                        username_attempt = username_attempt + 1;
                        // Call the 'disableForm' function to check if the number of failed attempts has been succeeded
                        disableForm();
                        // Set focus to 'Username' text field so that the user can retype their input
                        usernameTxt.Focus();
                        // Terminate the event handler and return to login form
                        return;
                    }
                    // Close database connection
                    con.Close();
                }
            }
        }
    }
}
