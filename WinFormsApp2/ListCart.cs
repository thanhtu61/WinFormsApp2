using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms; // Necessary for MessageBox

namespace WinFormsApp2
{
    public class ListCart
    {
        public decimal Sum { get; private set; } // Use a property for sum
        private DatabaseAccess dbAccess; // Instance of DatabaseAccess

        public ListCart()
        {
            dbAccess = new DatabaseAccess(); // Initialize DatabaseAccess
        }

        public List<Cart> ClientGetCart(int clientId)
        {
            List<Cart> listCarts = new List<Cart>();
            Sum = 0; // Initialize sum

            string query = "SELECT ClientID, CartID, Cart.ProductID, ProductName, Price, Quantity, (Price * Quantity) AS Total, DateAdded FROM Cart JOIN Product ON Cart.ProductID = Product.ProductID WHERE ClientID = @clientId;";

            try
            {
                // Use DatabaseAccess to execute the query and read data
                dbAccess.ExecuteReader<Cart>(query, command =>
                {
                    command.Parameters.AddWithValue("@clientId", clientId);
                }, reader =>
                {
                    var cart = new Cart
                    {
                        ClientId = reader.GetInt32(0),
                        CartId = reader.GetInt32(1),
                        ProductId = reader.GetInt32(2),
                        ProductName = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Price = reader.GetDecimal(4),
                        Quantity = reader.GetInt32(5),
                        Total = reader.GetDecimal(6),
                        DateAdded = reader.GetDateTime(7),
                    };
                    Sum += cart.Total; // Accumulate total
                    return cart; // Return the created Cart object
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return listCarts;
        }

        internal void DeleteCart(int cartId)
        {
            string query = "DELETE FROM Cart WHERE CartID = @CartID;";
            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@CartID", cartId);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        internal void DeleteAllCart(int clientId)
        {
            string query = "DELETE FROM Cart WHERE ClientID = @ClientID;";
            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@ClientID", clientId);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public class Cart
        {
            public int CartId { get; set; }
            public int ClientId { get; set; }
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal Total { get; set; }
            public DateTime DateAdded { get; set; }

            public Cart(int cartId, int clientId, int productId, string productName, decimal price, decimal total, int quantity, DateTime dateAdded)
            {
                CartId = cartId;
                ClientId = clientId;
                ProductId = productId;
                ProductName = productName;
                Price = price;
                Total = total;
                Quantity = quantity;
                DateAdded = dateAdded;
            }

            public Cart() { } // Parameterless constructor
        }
    }
}