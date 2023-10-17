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
    public partial class appliancesFrm : Form
    {
        public appliancesFrm()
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

        public static string applianceModel, applianceSize, applianceColour, applianceEnergyConsumption, applianceMonthlyRentalPrice, applianceStock;
        public static int applianceID, typeSelectedIndex, brandSelectedIndex;

        public string searchConditions = "";

        public DataTable BindSource()
        {
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
                editBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }
            // If query did not return any rows
            else
            {
                editBtn.Enabled = false;
                deleteBtn.Enabled = false;
                // Display message telling admin that there are no surveys available
                MessageBox.Show("There are currently no appliances available. You can add a new appliance by clicking the 'Add Appliance' button.", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Return datatable
            return dt;
        }

        private void autosize()
        {
            for (int i = 0; i < appliancesDgv.Columns.Count - 1; i++)
            {
                appliancesDgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            appliancesDgv.Columns[appliancesDgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < appliancesDgv.Columns.Count; i++)
            {
                int colw = appliancesDgv.Columns[i].Width;
                appliancesDgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                appliancesDgv.Columns[i].Width = colw;
            }
        }

        public void RefreshMyDataGridView()
        {
            BindSource();
        }

        private void appliancesFrm_Load(object sender, EventArgs e)
        {
            BindSource();
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

        private void clearFieldsBtn_Click(object sender, EventArgs e)
        {
            brandCbx.SelectedIndex = -1;
            typeCbx.SelectedIndex = -1;
            sortCbx.SelectedIndex = -1;
            quickSearchTxt.Text = string.Empty;
        }

        private void sortBtn_Click(object sender, EventArgs e)
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Display confirmation message
            if (MessageBox.Show("Are you sure you want to delete this appliance?",
                               "Home Appliance Rental System",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
            {

                int applianceID = Convert.ToInt32(appliancesDgv.CurrentRow.Cells["ID"].Value);

                cmd = new SqlCommand("DELETE FROM appliance WHERE Id = " + applianceID + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                BindSource();
                MessageBox.Show("The appliance has been deleted successfully", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else { return; }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            applianceID = Convert.ToInt32(appliancesDgv.CurrentRow.Cells["ID"].Value);
            cmd = new SqlCommand("SELECT * FROM appliance WHERE Id = " + applianceID, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            string type = dt.Rows[0]["type"].ToString();

            switch (type)
            {
                case "Cooking":
                    typeSelectedIndex = 0;
                    break;
                case "Refrigeration":
                    typeSelectedIndex = 1;
                    break;
                case "Television":
                    typeSelectedIndex = 2;
                    break;
                case "Washing & Cleaning":
                    typeSelectedIndex = 3;
                    break;
                case "Small Appliances":
                    typeSelectedIndex = 4;
                    break;
                default:
                    break;
            }

            string brand = dt.Rows[0]["brand"].ToString();

            switch (brand)
            {
                case "Defy":
                    brandSelectedIndex = 0;
                    break;
                case "LG":
                    brandSelectedIndex = 1;
                    break;
                case "Beko":
                    brandSelectedIndex = 2;
                    break;
                case "Bosch":
                    brandSelectedIndex = 3;
                    break;
                case "Panasonic":
                    brandSelectedIndex = 4;
                    break;
                default:
                    break;
            }

            applianceModel = dt.Rows[0]["model"].ToString();
            applianceSize = dt.Rows[0]["size"].ToString();
            applianceColour = dt.Rows[0]["colour"].ToString();
            applianceStock = dt.Rows[0]["stock"].ToString();

            applianceEnergyConsumption = dt.Rows[0]["energy_consumption"].ToString();
            applianceMonthlyRentalPrice = dt.Rows[0]["monthly_rental_fee"].ToString();

            editApplianceFrm editApplianceFrm = new editApplianceFrm();
            editApplianceFrm.ShowDialog();

        }
    }
}
