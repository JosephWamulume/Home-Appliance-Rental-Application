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

namespace Home_Appliance_Rental_Application
{
    public partial class updateOrderStatusFrm : Form
    {
        public updateOrderStatusFrm()
        {
            InitializeComponent();
        }

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Home Appliance Rental Application\Home Appliance Rental Application\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        private void updateOrderStatusFrm_Load(object sender, EventArgs e)
        {

            if (orderManagementFrm.orderStatus == "Processing")
            {
                orderStatusCbx.SelectedIndex = 0;
            }
            if (orderManagementFrm.orderStatus == "Delivering")
            {
                orderStatusCbx.SelectedIndex = 1;
            }
            if (orderManagementFrm.orderStatus == "Delivered")
            {
                orderStatusCbx.SelectedIndex = 2;
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (orderStatusCbx.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order status", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string orderStatus = orderStatusCbx.Text;

                // Insert consumer information into 'users' table
                cmd = new SqlCommand("UPDATE [order] SET status = '" + orderStatusCbx.Text + "' WHERE Id = " + orderManagementFrm.orderID, con);
                // Open database connection
                con.Open();
                // Execute query
                cmd.ExecuteNonQuery();
                // Close database connection
                con.Close();

                //appliancesFrm.RefreshMyDataGridView();

                // Display success message
                MessageBox.Show("The order status has been updated successfully", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
    }
}
