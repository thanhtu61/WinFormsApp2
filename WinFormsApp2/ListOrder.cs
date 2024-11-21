using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class ListOrder
    {
        private const string ConnectionString = "Data Source=ComputerStote.db;Version=3;"; // Đảm bảo tên tệp là chính xác

        public List<Order> GetOrders()
        {
            List<Order> listOrders = new List<Order>();

            try
            {
                using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM [Order];";

                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var order = new Order
                            {
                                orderID = reader.GetInt32(reader.GetOrdinal("OrderID")), // Sử dụng GetOrdinal
                                clientID = reader.GetInt32(reader.GetOrdinal("ClientID")),
                                ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                                ProductName = reader.IsDBNull(reader.GetOrdinal("ProductName")) ? null : reader.GetString(reader.GetOrdinal("ProductName")),
                                Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                                Total = reader.GetDecimal(reader.GetOrdinal("Total")),
                                DateAdded = reader.GetDateTime(reader.GetOrdinal("DateAdded"))
                            };
                            listOrders.Add(order);
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return listOrders;
        }
        internal void DeleteOrder(decimal idOrder)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                // Xóa bản ghi trong bảng Client trước
                string deleteClientQuery = "DELETE FROM [Order] WHERE OrderId = @idOrder;";
                using (var clientCommand = new SQLiteCommand(deleteClientQuery, connection))
                {
                    clientCommand.Parameters.AddWithValue("@idOrder", idOrder);
                    int clientResult = clientCommand.ExecuteNonQuery();

                    if (clientResult > 0)
                    {
                        MessageBox.Show("Account deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error deleting account. User may not exist.");
                    }
                }

          
            }
        }
        public class Order
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
}