using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Inventory_System
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
            LoadData();

            // Subscribe to the ItemAdded event in frmItemAdd
            frmItemAdd frmItemAdd = new frmItemAdd();
            frmItemAdd.ItemAdded += FrmItemAdd_ItemAdded;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmItemAdd frmItemAdd = new frmItemAdd();
            frmItemAdd.ItemAdded += FrmItemAdd_ItemAdded;
            frmItemAdd.ShowDialog();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmItemUpdate frmItemUpdate = new frmItemUpdate();

            // Set the ProductId property before opening frmItemUpdate
            frmItemUpdate.ProductId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["Product_ID"].Value);
            frmItemUpdate.txtName.Text = this.dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            frmItemUpdate.txtStocks.Text = this.dataGridView1.CurrentRow.Cells["Stocks"].Value.ToString();
            frmItemUpdate.cbbSupplier.Text = this.dataGridView1.CurrentRow.Cells["Supplier"].Value.ToString();

            frmItemUpdate.ShowDialog();
            LoadData();


        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''"))
                {
                    connection.Open();

                    string query = "SELECT Product_ID, Name, Stocks, Supplier FROM inventory.products";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FrmItemAdd_ItemAdded(object sender, ItemAddedEventArgs e)
        {
            AddItemToGrid(e.ItemName, e.Stocks, e.Supplier);
            SaveItemToDatabase(e.ItemName, e.Stocks, e.Supplier);
            LoadData();
        }

        public void AddItemToGrid(string itemName, int stocks, string supplier)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            dataTable.Rows.Add(null, itemName, stocks, supplier);
        }

        private void SaveItemToDatabase(string itemName, int stocks, string supplier)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''"))
                {
                    connection.Open();

                    string query = "INSERT INTO inventory.products (Name, Stocks, Supplier) VALUES (@name, @stocks, @supplier)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@name", itemName);
                    command.Parameters.AddWithValue("@stocks", stocks);
                    command.Parameters.AddWithValue("@supplier", supplier);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''"))
                {
                    connection.Open();

                    string query = "SELECT * FROM inventory.products WHERE Name LIKE @searchTerm OR Supplier LIKE @searchTerm";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@searchTerm", "%" + txtSearch.Text + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        // Check if stock is low and show the popup
                        foreach (DataRow row in dataTable.Rows)
                        {
                            int stocks = Convert.ToInt32(row["Stocks"]);
                            if (stocks <= 100) // You can adjust the threshold as needed
                            {
                                ShowLowStockPopup();
                                break; // No need to check further if one low stock is found
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowLowStockPopup()
        {
            PopupNotifier popup = new PopupNotifier();

            popup.BodyColor = Color.FromArgb(23, 162, 184);
            popup.TitleText = "Low stocks";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popup.ContentText = "Message your supplier";
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Popup();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmSupplierAdd frmSupplierAdd = new frmSupplierAdd();
            frmSupplierAdd.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row's Product_ID
                int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Product_ID"].Value);

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                // Delete the corresponding record from the database
                DeleteItemFromDatabase(productId);
            }
        }

        private void DeleteItemFromDatabase(int productId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''"))
                {
                    connection.Open();

                    string query = "DELETE FROM inventory.products WHERE Product_ID = @productId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@productId", productId);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item from the database: " + ex.Message);
            }
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {

        }
    }
}


