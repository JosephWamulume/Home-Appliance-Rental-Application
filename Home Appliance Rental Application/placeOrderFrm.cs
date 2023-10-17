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
    public partial class placeOrderFrm : Form
    {
        public placeOrderFrm()
        {
            InitializeComponent();
        }

        public event EventHandler RefreshDataGridView;

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Home Appliance Rental Application\Home Appliance Rental Application\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public string filterCondition = "";
        public string sortCondition = "";

        public static string orderLine = "";

        public float totalPrice;


        public DataTable BindSource()
        {
            appliancesDgv.Font = new System.Drawing.Font("Poppins", 8);
            // Open database connection
            con.Open();
            // Retrieve all surveys from 'survey' table
            cmd = new SqlCommand("SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance", con);
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
                appliancesDgv.DataSource = dt;
                appliancesDgv.Columns["Id"].HeaderText = "ID";
                appliancesDgv.Columns["Id"].Visible = false;
                appliancesDgv.Columns["type"].HeaderText = "Type";
                appliancesDgv.Columns["brand"].HeaderText = "Brand";
                appliancesDgv.Columns["model"].HeaderText = "Model";
                appliancesDgv.Columns["size"].HeaderText = "Size";
                appliancesDgv.Columns["colour"].HeaderText = "Colour";
                appliancesDgv.Columns["energy_consumption"].HeaderText = "Energy Consumption (kWh/Year)";
                appliancesDgv.Columns["monthly_rental_fee"].HeaderText = "Rental Price";
                appliancesDgv.Columns["minimum_rental_period"].HeaderText = "Minimum Rental Period (Months)";
                appliancesDgv.Columns["stock"].HeaderText = "Available Stock";
                addToCartBtn.Enabled = true;
            }
            // If query did not return any rows
            else
            {
                addToCartBtn.Enabled = false;
                // Display message telling admin that there are no surveys available
                MessageBox.Show("There are currently no appliances available. You can add a new appliance by clicking the 'Add Appliance' button.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Return datatable
            return dt;
        }

        public void RefreshMyDataGridView()
        {
            BindSource();
        }

        private void placeOrderFrm_Load(object sender, EventArgs e)
        {
            BindSource();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            BindSource();
            typeCbx.SelectedIndex = -1;
            brandCbx.SelectedIndex = -1;
            sortCbx.SelectedIndex = -1;
            quickSearchTxt.Text = string.Empty;
            searchConditionsLbl.Text = "There are currently no search terms selected or entered";
        }

        private void quickSearchTxt_TextChanged(object sender, EventArgs e)
        {
            // Open database connection
            con.Open();
            // Retrieve all surveys from 'survey' table
            cmd = new SqlCommand("SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance WHERE type LIKE '%" + quickSearchTxt.Text + "%' OR brand LIKE '%" + quickSearchTxt.Text + "%' OR model LIKE '%" + quickSearchTxt.Text + "%' OR colour LIKE '%" + quickSearchTxt.Text + "%'", con);
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
            appliancesDgv.DataSource = dt;
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            filterCondition = "";

            if ((typeCbx.SelectedItem == null) && (brandCbx.SelectedItem == null))
            {
                // Display error message if user leaves the username text field empty
                MessageBox.Show("Please select or enter at least one filter term.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Terminate the event handler
                return;
            }
            else
            {

                if ((typeCbx.SelectedItem != null) && (brandCbx.SelectedItem == null))
                {
                    filterCondition += "type = '" + typeCbx.SelectedItem.ToString() + "'";
                }
                if ((brandCbx.SelectedItem != null) && (typeCbx.SelectedItem == null))
                {
                    filterCondition += "brand = '" + brandCbx.SelectedItem.ToString() + "'";
                }
                if ((brandCbx.SelectedItem != null) && (typeCbx.SelectedItem != null))
                {
                    filterCondition += "brand = '" + brandCbx.SelectedItem.ToString() + "' AND type = '" + typeCbx.SelectedItem.ToString() + "'";
                }

                string sql;

                if (!String.IsNullOrEmpty(sortCondition))
                {
                    sql = "SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance WHERE " + filterCondition + "ORDER BY " + sortCondition;
                }
                else
                {
                    sql = "SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance WHERE " + filterCondition;
                }

                // Open database connection
                con.Open();
                // Retrieve all surveys from 'survey' table
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                // Clear existing dataset if any
                ds.Clear();
                // Store retrived surveys in dataset
                da.Fill(ds);
                // Store dataset table in datatable
                dt = ds.Tables[0];
                // Close database connection
                con.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("There were no appliances found matching the filter conditions entered.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Call 'BindSource' function to refresh data grid
                    BindSource();
                }
                else
                {
                    // Display data
                    appliancesDgv.DataSource = dt;
                }

            }
        }

        private void sortBtn_Click_1(object sender, EventArgs e)
        {
            if (sortCbx.SelectedItem == null)
            {
                // Display error message if user leaves the type text field empty
                MessageBox.Show("Please select a sort option", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the username text field so that the user can type the input
                typeCbx.Focus();
                // Terminate the event handler
                return;
            }

            string sql = "";

            if (!String.IsNullOrEmpty(filterCondition))
            {
                if (sortCbx.Text == "Price (High to Low)")
                {
                    sql = "SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance WHERE " + filterCondition + " ORDER BY monthly_rental_fee DESC";
                }

                if (sortCbx.Text == "Price (Low to High)")
                {
                    sql = "SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance WHERE " + filterCondition + " ORDER BY monthly_rental_fee ASC";
                }

                if (sortCbx.Text == "Energy Consumption (High to Low)")
                {
                    sql = "SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance  WHERE " + filterCondition + " ORDER BY energy_consumption DESC";
                }

                if (sortCbx.Text == "Energy Consumption (Low to High)")
                {
                    sql = "SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance WHERE " + filterCondition + " ORDER BY energy_consumption ASC";
                }
            }
            else
            {
                if (sortCbx.Text == "Price (High to Low)")
                {
                    sql = "SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance ORDER BY monthly_rental_fee DESC";
                }

                if (sortCbx.Text == "Price (Low to High)")
                {
                    sql = "SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance ORDER BY monthly_rental_fee ASC";
                }

                if (sortCbx.Text == "Energy Consumption (High to Low)")
                {
                    sql = "SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance ORDER BY energy_consumption DESC";
                }

                if (sortCbx.Text == "Energy Consumption (Low to High)")
                {
                    sql = "SELECT id, type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock FROM appliance ORDER BY energy_consumption ASC";
                }
            }



            // Open database connection
            con.Open();
            // Retrieve all surveys from 'survey' table
            cmd = new SqlCommand(sql, con);
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
            appliancesDgv.DataSource = dt;
        }

        private void clearFilterBtn_Click(object sender, EventArgs e)
        {
            typeCbx.SelectedIndex = -1;
            brandCbx.SelectedIndex = -1;
            filterCondition = string.Empty;
        }

        private void clearSortBtn_Click(object sender, EventArgs e)
        {
            sortCbx.SelectedIndex = -1;
            sortCondition = string.Empty;
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {

            if (quantityUpDown.Value == 0)
            {
                // Display error message if user leaves the rental text field empty
                MessageBox.Show("Please enter a quantity value", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the rental text field so that the user can type the input
                quantityUpDown.Focus();
                // Terminate the event handler
                return;
            }

            int applianceID = Convert.ToInt32(appliancesDgv.CurrentRow.Cells["ID"].Value);

            cmd = new SqlCommand("SELECT * FROM appliance WHERE Id = " + applianceID, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            string model = dt.Rows[0]["model"].ToString();
            float monthlyRentalFee = float.Parse(dt.Rows[0]["monthly_rental_fee"].ToString());
            int quantity = int.Parse(quantityUpDown.Value.ToString());
            float linePrice = monthlyRentalFee * quantity;

            orderLine = "Appliance: " + model + " | Price: K" + monthlyRentalFee + " | Quantity: " + quantity + " | Total: K" + linePrice;

            orderItemsLbx.Items.Add(orderLine);

            totalPrice += linePrice;

            lblTotalPrice.Text = "Total Price: K" + totalPrice.ToString();

            quantityUpDown.Value = 0;

            MessageBox.Show("Items added to cart", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this appliance from your cart?",
                               "Home Appliance Rental System",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (orderItemsLbx.SelectedIndex != -1)
                {
                    string selectedItem = orderItemsLbx.SelectedItem.ToString();

                    string pattern = @"Total: K(\d+)";

                    Match match = Regex.Match(selectedItem, pattern);

                    if (match.Success)
                    {
                        string numericValueString = match.Groups[1].Value;

                        if (int.TryParse(numericValueString, out int numericValue))
                        {
                            orderItemsLbx.Items.RemoveAt(orderItemsLbx.SelectedIndex);
                            totalPrice -= numericValue;
                            lblTotalPrice.Text = "Total Price: K" + totalPrice.ToString();
                        }
                        else
                        {
                            MessageBox.Show("There was an error updating the total price", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    } 
                    else
                    {
                        MessageBox.Show("There was an error updating the total price", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
            else
            {
                // Close confirmation message if user clicks 'No'
                return;
            }
        }

        private void confirmOrderBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to confirm this order?",
                               "Home Appliance Rental System",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
            {

                int orderID;

                DateTime dateTime = DateTime.Now;
                DateTime dateOnly = dateTime.Date;

                // Insert consumer information into 'users' table
                cmd = new SqlCommand("INSERT INTO [order] (user_id, status, total_cost, order_date) VALUES (@UserID, @OrderStatus, @TotalCost, @OrderDate); SELECT SCOPE_IDENTITY();", con);
                // Open database connection
                con.Open();
                // Execute query
                cmd.Parameters.AddWithValue("@UserID", loginFrm.userID);
                cmd.Parameters.AddWithValue("@OrderStatus", "Processing");
                cmd.Parameters.AddWithValue("@TotalCost", totalPrice);
                cmd.Parameters.AddWithValue("@OrderDate", dateTime);

                orderID = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (var item in orderItemsLbx.Items)
                {
                    cmd = new SqlCommand("INSERT INTO order_line (description, order_id) VALUES (@Description, @OrderID)", con);
                    cmd.Parameters.AddWithValue("@Description", item.ToString());
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.ExecuteNonQuery();
                }

                // Close database connection
                con.Close();

                MessageBox.Show("Your order has been placed successfully. Click the 'My Orders' tab to view your orders.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                orderItemsLbx.Items.Clear();
                totalPrice = 0;
                tabControl.SelectedIndex = 0;

            }
            else
            {
                // Close confirmation message if user clicks 'No'
                return;
            }
        }
    }
}
