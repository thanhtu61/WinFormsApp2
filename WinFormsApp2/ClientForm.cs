using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{

    public partial class ClientForm : Form
    {
        private List<Product> products;
        private ListProduct listProduct;
        public int clientID;
        private DatabaseAccess dbAccess; // Create a database access instance
        string  connectionString = "Server=192.168.101.169;Database=TelephoneStore;User Id=aa;Password=113112111Tien;";
        public T ExecuteScalar<T>(string query, Action<SqlCommand> prepareCommand)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    prepareCommand(command);

                    var result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        return default; // Return default value for type T
                    }

                    return (T)Convert.ChangeType(result, typeof(T)); // Convert to the desired type
                }
            }
        }
        public ClientForm(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
            dbAccess = new DatabaseAccess(); // Initialize DatabaseAccess
            LoadData();
        }

        private void LoadData()
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts();
            dataGridView1.DataSource = products;
        }

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            // Check if the product list is not empty
            if (products != null && products.Count > 0)
            {
                // Sort the product list by price
                products = products.OrderBy(p => p.Price).ToList(); // Sort ascending
                dataGridView1.DataSource = null; // Clear current data source
                dataGridView1.DataSource = products; // Set sorted list as data source
            }
            else
            {
                MessageBox.Show("No products to sort.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show(); // Show the main form
        }

        private void cart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(clientID);
            this.Hide();
            cartForm.Show(); // Show the cart form
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            int productId = (int)numericUpDownProductId.Value;
            int quantity = (int)numericUpDownQuantity.Value;

            if (productId > 0 && quantity > 0)
            {
                // Check stock quantity using DatabaseAccess
                string stockQuery = "SELECT StockQuantity FROM Product WHERE ProductID = @productId";

                var stockQuantityList = dbAccess.ExecuteReader(stockQuery, command =>
                {
                    command.Parameters.AddWithValue("@productId", productId);
                }, reader =>
                {
                    // Kiểm tra xem có dữ liệu không trước khi lấy giá trị
                    return reader["StockQuantity"] != DBNull.Value ? (int?)reader.GetInt32(0) : null;
                });

                // Kiểm tra nếu có ít nhất một giá trị trong danh sách
                if (stockQuantityList != null && stockQuantityList.Count > 0)
                {
                    int stockQuantity = stockQuantityList[0].Value; // Lấy giá trị đầu tiên
                    if (stockQuantity < quantity)
                    {
                        MessageBox.Show("Cannot add to cart: Insufficient stock available.");
                        return; // Exit the method if stock is insufficient
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                    return; // Exit if product ID is invalid
                }

                // If stock is sufficient, proceed to add to cart
                string insertQuery = "INSERT INTO cart (ClientID, ProductID, Quantity, DateAdded) VALUES (@clientId, @productId, @quantity, @dateAdded)";
                dbAccess.ExecuteNonQuery(insertQuery, command =>
                {
                    command.Parameters.AddWithValue("@clientId", clientID);
                    command.Parameters.AddWithValue("@productId", productId);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@dateAdded", DateTime.Now);
                });

                MessageBox.Show("Product added to cart!");
            }
            else
            {
                MessageBox.Show("Please enter valid Product ID and Quantity.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts(1);
            dataGridView1.DataSource = products; // Update data source
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts(2);
            dataGridView1.DataSource = products; // Update data source
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts(3);
            dataGridView1.DataSource = products; // Update data source
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Check if the product list is not empty
            if (products != null && products.Count > 0)
            {
                // Sort the product list by stock quantity
                products = products.OrderBy(p => p.StockQuantity).ToList(); // Sort ascending
                dataGridView1.DataSource = null; // Clear current data source
                dataGridView1.DataSource = products; // Set sorted list as data source
            }
            else
            {
                MessageBox.Show("No products to sort.");
            }
        }
    }
}