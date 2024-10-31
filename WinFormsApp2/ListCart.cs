using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms; // Make sure to include this for MessageBox

namespace WinFormsApp2
{
    public class ListCart
    {
        public object ClientID { get; private set; }

        public List<Cart> ClientGetCart(int clientId)
        {

            List<Cart> listCarts = new List<Cart>();

            try
            {
                string dbPath = "ComputerStote.db"; // Ensure the database path is correct

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();
                    string query = "SELECT clientId, CartID, cart.ProductID,ProductName,PRICE, Quantity, DateAdded  FROM cart JOIN Product ON CART.ProductID=PRODUCT.ProductID WHERE ClientID = @clientID;";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@clientID", clientId);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var cart = new Cart
                                {
                                    ClientId = reader.GetInt32(0),
                                    CartId = reader.GetInt32(1),
                                    ProductId = reader.GetInt32(2),
                                    ProductName = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    Price = reader.GetDecimal(4),
                                    Quantity = reader.GetInt32(5),
                                    DateAdded = reader.GetDateTime(6),

                                };
                                listCarts.Add(cart);
                            }
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

            return listCarts;
        }

        internal void DeleteCart(decimal id)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "delete from cart where CartID=@CartID;";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CartID",id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public class Cart
        {
            public int CartId { get; set; }
            public int ClientId { get; set; }
            public int ProductId { get; set; }
            public decimal Price { get; set; }
            public String ProductName { get; set; }
            public int Quantity { get; set; }
            public DateTime DateAdded { get; set; }

            public Cart(int cartId, int clientId, int productId,String ProductName, decimal Price, int quantity, DateTime dateAdded)
            {
                CartId = cartId; // Fixed the assignment
                ClientId = clientId;
                ProductId = productId;
                ProductName = ProductName;
                Price = Price;
                Quantity = quantity;
                DateAdded = dateAdded;
            }

            public Cart() { } // Parameterless constructor
        }
    }
}