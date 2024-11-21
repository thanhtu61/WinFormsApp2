using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite; // Sử dụng SQLite
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class CartForm : Form
    {
        private List<ListCart.Cart> carts;
        private ListCart listCart;
        public int ClientID;//userID
        public int clientID1;

        public CartForm(int clientID)
        {
            this.ClientID = clientID;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            listCart = new ListCart();
            carts = listCart.ClientGetCart(this.ClientID);
            dataGridView1.DataSource = carts;
            label2.Text = "Total Sum: " + listCart.sum.ToString();
           // dataGridView1.Columns["clientID"].Visible = false;
        }

        private void ClearInputFields()
        {
            numericUpDown1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm form1 = new ClientForm(ClientID);
            this.Hide();
            form1.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            decimal Id = numericUpDown1.Value;
            listCart.DeleteCart(Id);
            LoadData();
            ClearInputFields();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int clientID = Convert.ToInt32(row.Cells["clientID"].Value);
                        int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                        string productName = row.Cells["ProductName"].Value.ToString();
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal total = Convert.ToDecimal(row.Cells["Total"].Value);
                        DateTime dateAdded = Convert.ToDateTime(row.Cells["DateAdded"].Value);

                        OrderItem orderItem = new OrderItem
                        {
                            clientID = clientID,
                            ProductID = productId,
                            ProductName = productName,
                            Price = price,
                            Quantity = quantity,
                            Total = total,
                            DateAdded = dateAdded

                        };
                        clientID1= clientID;
                        orderItems.Add(orderItem);
                    }
                }

            // Kiểm tra nếu danh sách orderItems không rỗng
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Корзина пуста! Пожалуйста, добавьте товары перед заказом.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveOrderItemsToDatabase(orderItems);
            listCart.DeleteAllCart(clientID1);
            LoadData();
            ClearInputFields();
            MessageBox.Show("Заказ успешно размещен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveOrderItemsToDatabase(List<OrderItem> orderItems)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($"Data Source=\"ComputerStote.db\";"))
                {
                    connection.Open();

                    foreach (var item in orderItems)
                    {
                        string query = "INSERT INTO [Order] (ClientID, ProductID, ProductName, Price, Quantity, Total, DateAdded) " +
                                       "VALUES (@ClientID, @ProductID, @ProductName, @Price, @Quantity, @Total, @DateAdded)";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ClientID", item.clientID);
                            command.Parameters.AddWithValue("@ProductID", item.ProductID);
                            command.Parameters.AddWithValue("@ProductName", item.ProductName);
                            command.Parameters.AddWithValue("@Price", item.Price);
                            command.Parameters.AddWithValue("@Quantity", item.Quantity);
                            command.Parameters.AddWithValue("@Total", item.Total);
                            command.Parameters.AddWithValue("@DateAdded", DateTime.Now); // Hoặc item.DateAdded nếu bạn muốn lưu thời gian cụ thể

                            command.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Заказ успешно сохранен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"При сохранении заказа произошла ошибка: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Định nghĩa lớp OrderItem
    public class OrderItem
    {
        public int orderID { get; set; }
        public int clientID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public DateTime DateAdded { get; set; }
    }
}