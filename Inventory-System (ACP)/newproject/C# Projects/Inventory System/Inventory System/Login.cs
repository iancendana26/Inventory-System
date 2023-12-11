using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Inventory_System
{
    public partial class frmLogin : Form
    {
        MySqlConnection connection =
            new MySqlConnection
            ("datasource=localhost;port=3306;username=root;password=''");
        MySqlCommand command;
        MySqlDataReader mdr;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void ShowLowStockInDataGridView(MySqlConnection connection)
{
    string selectLowStockQuery = "SELECT * FROM inventory.items WHERE Stocks <= @lowStockThreshold";
    MySqlCommand lowStockCommand = new MySqlCommand(selectLowStockQuery, connection);
    lowStockCommand.Parameters.AddWithValue("@lowStockThreshold", 100);

    DataTable lowStockDataTable = new DataTable();

    try
    {
        using (MySqlDataAdapter adapter = new MySqlDataAdapter(lowStockCommand))
        {
            adapter.Fill(lowStockDataTable);
        }

        if (lowStockDataTable.Rows.Count > 0)
        {
            // If there are low stock items, show them in a DataGridView
            DataGridView lowStockDataGridView = new DataGridView();
            lowStockDataGridView.DataSource = lowStockDataTable;

            // Customize the DataGridView appearance if needed
            // For example, you can add it to a form and display it there
            // Or customize the column headers, formatting, etc.
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error retrieving low stock data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter both Username and Password", "No Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionString = ("datasource=localhost;port=3306;username=root;password=''");

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Use parameterized query to prevent SQL injection
                        string selectQuery = "SELECT * FROM inventory.login WHERE Username = @userName AND PASSWORD = @PASSWORD";
                        MySqlCommand command = new MySqlCommand(selectQuery, connection);
                        command.Parameters.AddWithValue("@userName", txtUsername.Text);
                        command.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Admin Login Successful!");
                                // Code for connecting to the 'AdminAccount' database here
                                this.Hide();
                                frmInventory frmInventory = new frmInventory();
                                frmInventory.ShowDialog();
                                ShowLowStockPopup(connection); // Show low stock popup after successful login
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void ShowLowStockPopup(MySqlConnection connection)
        {
            
            string selectLowStockQuery = "SELECT * FROM inventory.items WHERE Stocks <= @lowStockThreshold";
            MySqlCommand lowStockCommand = new MySqlCommand(selectLowStockQuery, connection);
            lowStockCommand.Parameters.AddWithValue("@lowStockThreshold",100); 
            using (MySqlDataReader lowStockReader = lowStockCommand.ExecuteReader())
            {
                while (lowStockReader.Read())
                {
                    PopupNotifier popup = new PopupNotifier();

                    popup.BodyColor = Color.FromArgb(23, 162, 184);
                    popup.TitleText = "Low stocks";
                    popup.TitleColor = Color.White;
                    popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

                    
                    string itemName = lowStockReader["product"].ToString(); 
                    int currentStock = Convert.ToInt32(lowStockReader["Stocks"]); 

                    popup.ContentText = $"Low stock for {itemName}. Current stock: {currentStock}. Message your supplier.";
                    popup.ContentColor = Color.White;
                    popup.ContentFont = new Font("Century Gothic", 12);
                    popup.Popup();
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

    }
}
                    
            
                
            