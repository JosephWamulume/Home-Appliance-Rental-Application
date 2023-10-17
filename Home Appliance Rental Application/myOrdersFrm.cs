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
    public partial class myOrdersFrm : Form
    {
        public myOrdersFrm()
        {
            InitializeComponent();
        }

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Home Appliance Rental Application\Home Appliance Rental Application\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        SqlDataAdapter daa;

        private DataTable dtt = new DataTable();
        private DataSet dss = new DataSet();

        public DataTable BindSource()
        {
            // Open database connection
            con.Open();
            // Retrieve all surveys from 'survey' table
            cmd = new SqlCommand("SELECT * FROM [order] WHERE user_id = " + loginFrm.userID, con);
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
                myOrdersDgv.DataSource = dt;
                myOrdersDgv.Columns["ID"].HeaderText = "ID";
                myOrdersDgv.Columns["ID"].Visible = false;
                myOrdersDgv.Columns["user_id"].Visible = false;
                myOrdersDgv.Columns["Prefix"].HeaderText = "Order Number";
                myOrdersDgv.Columns["status"].HeaderText = "Order Status";
                myOrdersDgv.Columns["total_cost"].HeaderText = "Total Cost (K)";
                myOrdersDgv.Columns["order_date"].HeaderText = "Order Date";
            }
            // If query did not return any rows
            else
            {
                // Display message telling admin that there are no surveys available
                MessageBox.Show("No orders have been placed for this account", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Return datatable
            return dt;
        }

        private void myOrdersFrm_Load(object sender, EventArgs e)
        {
            BindSource();
        }

        private void myOrdersDgv_SelectionChanged(object sender, EventArgs e)
        {
            if (myOrdersDgv.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = myOrdersDgv.SelectedRows[0];

                int orderID = int.Parse(selectedRow.Cells["ID"].Value.ToString());

                con.Open();

                cmd = new SqlCommand("SELECT * FROM order_line WHERE order_id = @OrderID", con);
                cmd.Parameters.AddWithValue("@OrderID", orderID);

                daa = new SqlDataAdapter(cmd);
                dss.Clear();
                daa.Fill(dss);
                dtt = dss.Tables[0];
                con.Close();

                int rowIndex = 0;

                foreach (DataRow row in dtt.Rows)
                {
                    orderItemsLbx.Items.Add(dtt.Rows[rowIndex]["description"].ToString());
                    rowIndex++;                    
                }

            }
        }

        private void orderNumberTxt_TextChanged(object sender, EventArgs e)
        {
            // Open database connection
            con.Open();
            // Retrieve all surveys from 'survey' table
            cmd = new SqlCommand("SELECT * FROM [order] WHERE user_id = " + loginFrm.userID + " AND order_id = " + orderNumberTxt, con);
            da = new SqlDataAdapter(cmd);
            // Clear existing dataset if any
            ds.Clear();
            // Store retrived surveys in dataset
            da.Fill(ds);
            // Store dataset table in datatable
            dt = ds.Tables[0];
            // Close database connection
            con.Close();
            // Display data
            myOrdersDgv.DataSource = dt;
        }
    }
}
