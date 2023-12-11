using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class frmSupplierAdd : Form
    {
        MySqlConnection supplier = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=inventory");

        public frmSupplierAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtContact.Text) || (string.IsNullOrEmpty(txtEmail.Text)))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            try
            {
                using (MySqlConnection connection = supplier)
                {
                    connection.Open();

                    string iquery = "INSERT INTO supplier (Supplier_Name, Address, Contact_Number, Email) " +
                                    "VALUES (@Supplier_Name, @Address, @Contact_Number, @Email)";

                    using (MySqlCommand commandDatabase = new MySqlCommand(iquery, connection))
                    {
                        commandDatabase.Parameters.AddWithValue("@Supplier_Name", txtName.Text);
                        commandDatabase.Parameters.AddWithValue("@Address", txtAddress.Text);
                        commandDatabase.Parameters.AddWithValue("@Contact_Number", txtContact.Text);
                        commandDatabase.Parameters.AddWithValue("@Email", txtEmail.Text);

                        int rowsAffected = commandDatabase.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Supplier added successfully!");
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSupplierAdd_Load(object sender, EventArgs e)
        {
            // Load any additional data or perform initialization if needed
        }
    }
}

