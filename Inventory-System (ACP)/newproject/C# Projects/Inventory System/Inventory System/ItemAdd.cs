using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class frmItemAdd : Form
    {
        // Declare an event to notify the parent form about the new item
        public event EventHandler<ItemAddedEventArgs> ItemAdded;

        public frmItemAdd()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the input data if needed
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtStocks.Text) || cbbSupplier.SelectedItem == null)
                {
                    MessageBox.Show("Please enter a valid format!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Trigger the ItemAdded event with the entered data
                ItemAdded?.Invoke(this, new ItemAddedEventArgs(txtName.Text, int.Parse(txtStocks.Text), cbbSupplier.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format for stocks. Please enter a valid number.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }

            // Close the form
            this.Close();
        }



        private void cbbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PopulateSupplierNames()
        {
            try
            {
                // Clear existing items in the combobox
                cbbSupplier.Items.Clear();

                // Connect to the database
                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=inventory"))
                {
                    connection.Open();

                    // Check connection state
                    Console.WriteLine($"Connection State: {connection.State}");

                    // Query to select Supplier_Name from the supplier table
                    string query = "SELECT Supplier_Name FROM supplier";

                    // Execute the query
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Read and add each Supplier_Name to the combobox
                            while (reader.Read())
                            {
                                Console.WriteLine($"Supplier Name: {reader[0]}");
                                cbbSupplier.Items.Add(reader[0].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating the suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbSupplier_DropDown(object sender, EventArgs e)
        {
            PopulateSupplierNames();
        }



        private void frmItemAdd_Load(object sender, EventArgs e)
        {
            // Perform any initialization logic if needed

        }
    }

    // Custom EventArgs class for passing item details
    public class ItemAddedEventArgs : EventArgs
    {
        public string ItemName { get; }
        public int Stocks { get; }
        public string Supplier { get; }

        public ItemAddedEventArgs(string itemName, int stocks, string supplier)
        {
            ItemName = itemName;
            Stocks = stocks;
            Supplier = supplier;
        }
    }
}

