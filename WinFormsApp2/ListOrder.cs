using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class ListOrder
    {
        private DatabaseAccess dbAccess;

        public ListOrder()
        {
            dbAccess = new DatabaseAccess();
        }

        public List<Order> GetOrders()
        {
            List<Order> listOrders = new List<Order>();
            string query = "SELECT * FROM [Order];";

            try
            {
                dbAccess.ExecuteReader(query, command => { }, reader =>
                {
                    var order = new Order
                    {
                        orderID = reader.GetInt32(reader.GetOrdinal("OrderID")),
                        clientID = reader.GetInt32(reader.GetOrdinal("ClientID")),
                        ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                        ProductName = reader.IsDBNull(reader.GetOrdinal("ProductName")) ? null : reader.GetString(reader.GetOrdinal("ProductName")),
                        Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                        Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                        Total = reader.GetDecimal(reader.GetOrdinal("Total")),
                        DateAdded = reader.GetDateTime(reader.GetOrdinal("DateAdded"))
                    };
                    listOrders.Add(order); // Add the order to the list
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return listOrders;
        }

        internal void DeleteOrder(int idOrder) // Changed parameter type to int for consistency
        {
            string query = "DELETE FROM [Order] WHERE OrderID = @idOrder;";

            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@idOrder", idOrder);
                });
                MessageBox.Show("Order deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting order: {ex.Message}");
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