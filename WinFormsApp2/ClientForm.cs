using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static WinFormsApp2.ListCart;

namespace WinFormsApp2
{
    public partial class ClientForm : Form
    {
        private List<Product> products;
        private ListProduct listProduct;
        private List<CartForm> carts;
        public int clientID;


        public ClientForm(int clientID)
        {
            this.clientID = clientID;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts();
            dataGridView1.DataSource = products;
        }
        private void btnSortByPrice_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu danh sách sản phẩm không rỗng
            if (products != null && products.Count > 0)
            {
                // Sắp xếp danh sách sản phẩm theo giá
                products = products.OrderBy(p => p.Price).ToList(); // Sắp xếp tăng dần
                dataGridView1.DataSource = null; // Xóa nguồn dữ liệu hiện tại
                dataGridView1.DataSource = products; // Gán lại danh sách đã sắp xếp
            }
            else
            {
                MessageBox.Show("Không có sản phẩm để sắp xếp.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void cart_Click(object sender, EventArgs e)
        {

            CartForm cartForm = new CartForm(clientID);
            this.Hide();
            cartForm.Show();
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {

            int productId = (int)numericUpDownProductId.Value;
            int quantity = (int)numericUpDownQuantity.Value;

            if (productId > 0 && quantity > 0)
            {
                string dbPath = "ComputerStote.db"; // Path to your database

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();

                    // Check stock quantity
                    string stockQuery = "SELECT StockQuantity FROM Product WHERE ProductID = @productId";
                    using (var stockCommand = new SQLiteCommand(stockQuery, connection))
                    {
                        stockCommand.Parameters.AddWithValue("@productId", productId);
                        object stockQuantityObj = stockCommand.ExecuteScalar();

                        if (stockQuantityObj != null)
                        {
                            int stockQuantity = Convert.ToInt32(stockQuantityObj);
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
                    }

                    // If stock is sufficient, proceed to add to cart
                    string query = "INSERT INTO cart (ClientID, ProductID, Quantity, DateAdded) VALUES (@clientId, @productId, @quantity, @dateAdded)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@clientId", clientID);
                        command.Parameters.AddWithValue("@productId", productId);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@dateAdded", DateTime.Now);

                        command.ExecuteNonQuery();
                    }
                }
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
            products = listProduct.GetProducts1();
            dataGridView1.DataSource = products;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts2();
            dataGridView1.DataSource = products;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts3();
            dataGridView1.DataSource = products;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                // Kiểm tra nếu danh sách sản phẩm không rỗng
                if (products != null && products.Count > 0)
                {
                    // Sắp xếp danh sách sản phẩm theo số lượng
                    products = products.OrderBy(p => p.StockQuantity).ToList(); // Sắp xếp tăng dần
                    dataGridView1.DataSource = null; // Xóa nguồn dữ liệu hiện tại
                    dataGridView1.DataSource = products; // Gán lại danh sách đã sắp xếp
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm để sắp xếp.");
                }
            
        }
    }
}

