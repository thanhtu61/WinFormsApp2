using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class CartForm : Form
    {
        private List<ListCart.Cart> carts;
        private ListCart listCart;
        public int ClientID; // User ID
        public int clientID1;
        private DatabaseAccess dbAccess;

        public CartForm(int clientID)
        {
            this.ClientID = clientID;
            InitializeComponent();
            dbAccess = new DatabaseAccess(); // Initialize database access
            LoadData();
        }

        private void LoadData()
        {
            listCart = new ListCart();
            carts = listCart.ClientGetCart(this.ClientID);
            dataGridView1.DataSource = carts;
            label2.Text = "Total Sum: " + listCart.Sum.ToString("C"); // Display sum in currency format
        }

        private void ClearInputFields()
        {
            numericUpDown1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm form1 = new ClientForm(ClientID);
            this.Hide();
            form1.Show(); // Show the client form
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = (int)numericUpDown1.Value; // Convert to int
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
                    OrderItem orderItem = new OrderItem
                    {
                        clientID = Convert.ToInt32(row.Cells["clientID"].Value),
                        ProductID = Convert.ToInt32(row.Cells["ProductID"].Value),
                        ProductName = row.Cells["ProductName"].Value.ToString(),
                        Price = Convert.ToDecimal(row.Cells["Price"].Value),
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                        Total = Convert.ToDecimal(row.Cells["Total"].Value),
                        DateAdded = DateTime.Now // Use current time
                    };
                    clientID1 = orderItem.clientID;
                    orderItems.Add(orderItem);
                }
            }

            if (orderItems.Count == 0)
            {
                MessageBox.Show("The cart is empty! Please add products before ordering.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveOrderItemsToDatabase(orderItems);
            listCart.DeleteAllCart(clientID1);
            LoadData();
            ClearInputFields();
            MessageBox.Show("Order placed successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveOrderItemsToDatabase(List<OrderItem> orderItems)
        {
            foreach (var item in orderItems)
            {
                string insertQuery = "INSERT INTO [Order] (ClientID, ProductID, ProductName, Price, Quantity, Total, DateAdded) " +
                                     "VALUES (@ClientID, @ProductID, @ProductName, @Price, @Quantity, @Total, @DateAdded)";

                dbAccess.ExecuteNonQuery(insertQuery, command =>
                {
                    command.Parameters.AddWithValue("@ClientID", item.clientID);
                    command.Parameters.AddWithValue("@ProductID", item.ProductID);
                    command.Parameters.AddWithValue("@ProductName", item.ProductName);
                    command.Parameters.AddWithValue("@Price", item.Price);
                    command.Parameters.AddWithValue("@Quantity", item.Quantity);
                    command.Parameters.AddWithValue("@Total", item.Total);
                    command.Parameters.AddWithValue("@DateAdded", DateTime.Now);
                });

                string updateQuery = "UPDATE Product SET StockQuantity = StockQuantity - @Quantity WHERE ProductID = @ProductID";

                dbAccess.ExecuteNonQuery(updateQuery, command =>
                {
                    command.Parameters.AddWithValue("@Quantity", item.Quantity);
                    command.Parameters.AddWithValue("@ProductID", item.ProductID);
                });
            }

            MessageBox.Show("Order saved successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Define the OrderItem class
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