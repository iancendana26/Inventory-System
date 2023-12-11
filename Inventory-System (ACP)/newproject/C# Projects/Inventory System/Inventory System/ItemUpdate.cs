using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Inventory_System
{
    public partial class frmItemUpdate : Form
    {
        public int ProductId { get; set; }

        public frmItemUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string updatestocks = txtStocks.Text;
            string supplier = cbbSupplier.Text;

            try
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=inventory"))
                {
                    connection.Open();

                    int productId = ProductId;

                    string updateQuery = "UPDATE inventory.products SET Name = @Name, Stocks = @updatestocks, Supplier = @supplier WHERE Product_ID = @ProductId";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@updatestocks", updatestocks);
                        command.Parameters.AddWithValue("@supplier", supplier);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");

                            // Check for low stocks after the update
                            CheckAndShowLowStockPopup(connection, productId, int.Parse(updatestocks));
                        }
                        else
                        {
                            MessageBox.Show("No matching record found. Data not updated.");
                        }
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CheckAndShowLowStockPopup(MySqlConnection connection, int productId, int updatedStocks)
        {
            // Check low stock levels and show popup if necessary
            string selectLowStockQuery = "SELECT * FROM inventory.products WHERE Product_ID = @ProductId AND Stocks <= 100";

            using (MySqlCommand lowStockCommand = new MySqlCommand(selectLowStockQuery, connection))
            {
                lowStockCommand.Parameters.AddWithValue("@ProductId", productId);

                using (MySqlDataReader lowStockReader = lowStockCommand.ExecuteReader())
                {
                    if (lowStockReader.Read())
                    {
                        int remainingStocks = lowStockReader.GetInt32("Stocks");

                        // Check if the updated stocks fall below the low stock threshold
                        if (updatedStocks <= 100)
                        {
                            ShowLowStockPopup();
                        }
                    }
                }
            }
        }


        private void ShowLowStockPopup()
        {
            PopupNotifier popup = new PopupNotifier();

            popup.BodyColor = System.Drawing.Color.FromArgb(23, 162, 184);
            popup.TitleText = "Low stocks";
            popup.TitleColor = System.Drawing.Color.White;
            popup.TitleFont = new System.Drawing.Font("Century Gothic", 15, System.Drawing.FontStyle.Bold);

            popup.ContentText = "Message your supplier";
            popup.ContentColor = System.Drawing.Color.White;
            popup.ContentFont = new System.Drawing.Font("Century Gothic", 12);
            popup.Popup();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItemUpdate_Load(object sender, EventArgs e)
        {
            // You can perform any initialization logic if needed
        }

        private void btnContactSupplier_Click(object sender, EventArgs e)
        {
            OpenWebsite("https://mail.google.com");
        }

        private void OpenWebsite(string url)
        {
            try
            {
                // Use Process.Start to open the default web browser with the specified URL
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the website: {ex.Message}", "Error");
            }
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
    }
}
