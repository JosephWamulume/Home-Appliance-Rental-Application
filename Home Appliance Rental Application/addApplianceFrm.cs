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
    public partial class addApplianceFrm : Form
    {
        public addApplianceFrm()
        {
            InitializeComponent();
        }

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Home Appliance Rental Application\Home Appliance Rental Application\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        private void addApplianceBtn_Click(object sender, EventArgs e)
        {
            // Validate for empty fields

            if (typeCbx.SelectedItem == null)
            {
                // Display error message if user leaves the type text field empty
                MessageBox.Show("Please select an appliance type", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the username text field so that the user can type the input
                typeCbx.Focus();
                // Terminate the event handler
                return;
            }
            else if (brandCbx.SelectedItem == null)
            {
                // Display error message if user leaves the brand text field empty
                MessageBox.Show("Please select a brand name", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the brand text field so that the user can type the input
                brandCbx.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrEmpty(modelTxt.Text))
            {
                // Display error message if user leaves the model text field empty
                MessageBox.Show("Please enter the appliance model", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the model text field so that the user can type the input
                modelTxt.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrEmpty(sizeTxt.Text))
            {
                // Display error message if user leaves the size text field empty
                MessageBox.Show("Please enter the appliance size", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the size text field so that the user can type the input
                sizeTxt.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrEmpty(colourTxt.Text))
            {
                // Display error message if user leaves the colour text field empty
                MessageBox.Show("Please enter the appliance colour", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the colour text field so that the user can type the input
                colourTxt.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrEmpty(energyConsumptionTxt.Text))
            {
                // Display error message if user leaves the energy consumption text field empty
                MessageBox.Show("Please enter the appliance energy consumption", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the energy consumption text field so that the user can type the input
                energyConsumptionTxt.Focus();
                // Terminate the event handler
                return;
            }
            else if (stockUpDown.Value == 0)
            {
                // Display error message if user leaves the rental text field empty
                MessageBox.Show("Please enter the amount of stock available for this appliance", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the rental text field so that the user can type the input
                stockUpDown.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrEmpty(monthlyRentalPriceTxt.Text))
            {
                // Display error message if user leaves the rental text field empty
                MessageBox.Show("Please enter the monthly rental price", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the rental text field so that the user can type the input
                monthlyRentalPriceTxt.Focus();
                // Terminate the event handler
                return;
            }
            else
            {

                int minimum_rental_period = 0;

                if (typeCbx.Text == "Cooking")
                {
                    minimum_rental_period = 1;
                }
                if (typeCbx.Text == "Refrigeration")
                {
                    minimum_rental_period = 3;
                }
                if (typeCbx.Text == "Entertainment")
                {
                    minimum_rental_period = 4;
                }
                if (typeCbx.Text == "Washing & Cleaning")
                {
                    minimum_rental_period = 2;
                }
                if (typeCbx.Text == "Small Appliances")
                {
                    minimum_rental_period = 6;
                }

                // Insert consumer information into 'users' table
                cmd = new SqlCommand("INSERT INTO appliance (type, brand, model, size, colour, energy_consumption, monthly_rental_fee, minimum_rental_period, stock) VALUES ('" + typeCbx.Text + "', '" + brandCbx.Text + "', '" + modelTxt.Text + "', '" + sizeTxt.Text + "', '" + colourTxt.Text + "', " + energyConsumptionTxt.Text + ", " + monthlyRentalPriceTxt.Text + ", " + minimum_rental_period + ", " + stockUpDown.Value + ")", con);
                // Open database connection
                con.Open();
                // Execute query
                cmd.ExecuteNonQuery();
                // Close database connection
                con.Close();
                // Display success message
                MessageBox.Show("Appliance added successfully!", "Home Appliance Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            typeCbx.SelectedIndex = -1;
            brandCbx.SelectedIndex = -1;
            modelTxt.Clear();
            sizeTxt.Clear(); 
            colourTxt.Clear(); 
            energyConsumptionTxt.Clear();
            stockUpDown.Value = 0;
            monthlyRentalPriceTxt.Clear();
        }
    }
}
