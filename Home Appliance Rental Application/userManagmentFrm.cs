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
    public partial class userManagmentFrm : Form
    {
        public userManagmentFrm()
        {
            InitializeComponent();
        }

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Home Appliance Rental Application\Home Appliance Rental Application\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public static int userID;

        public DataTable BindSource()
        {
            // Open database connection
            con.Open();
            // Retrieve all surveys from 'survey' table
            cmd = new SqlCommand("SELECT * FROM users WHERE user_type = 'Customer'", con);
            da = new SqlDataAdapter(cmd);
            // Clear existing dataset if any
            ds.Clear();
            // Store retrived surveys in dataset
            da.Fill(ds);
            // Store dataset table in datatable
            dt = ds.Tables[0];
            // Close database connection
            con.Close();
            // Check if the query returns any rows 
            if (dt.Rows.Count > 0)
            {
                // Populate data grid with returned rows
                usersDgv.DataSource = dt;
                usersDgv.Columns["ID"].HeaderText = "ID";
                usersDgv.Columns["ID"].Visible = false;
                usersDgv.Columns["user_password"].Visible = false;
                usersDgv.Columns["username"].HeaderText = "Username";
                usersDgv.Columns["phone_number"].HeaderText = "Phone Number";
                usersDgv.Columns["city_town"].HeaderText = "City/Town";
                usersDgv.Columns["residential_address"].HeaderText = "Residential Address";
                usersDgv.Columns["user_type"].HeaderText = "User Type";
                usersDgv.Columns["status"].HeaderText = "Status";
            }
            // If query did not return any rows
            else
            {
                // Display message telling admin that there are no surveys available
                MessageBox.Show("There are no users in the system", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Return datatable
            return dt;
        }

        private void userManagmentFrm_Load(object sender, EventArgs e)
        {
            BindSource();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            changeUserPasswordFrm changeUserPasswordFrm = new changeUserPasswordFrm();
            changeUserPasswordFrm.ShowDialog();
        }

        private void renableAccountBtn_Click(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(usersDgv.CurrentRow.Cells["ID"].Value);

            cmd = new SqlCommand("UPDATE users SET status = 'enabled' WHERE id = '" + userID + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            BindSource();
            MessageBox.Show("User account has been re-enabled successfully.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
