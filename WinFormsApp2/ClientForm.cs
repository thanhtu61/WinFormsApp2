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
            listProduct = new ListProduct();
            products = listProduct.SortProduct();
            dataGridView1.DataSource = products;
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
                string dbPath = "ComputerStote.db"; // Đường dẫn đến cơ sở dữ liệu của bạn

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();
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
    }
}
