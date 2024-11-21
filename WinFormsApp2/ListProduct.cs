using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public class ListProduct
    {
        //private const string ConnectionString = $"Data Source=ComputerStore.db;Version=3;";

        public List<Product> GetProducts()
        {
            List<Product> listProducts = new List<Product>();

            try
            {
                string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
               
                {
                    connection.Open();
                    string query = "SELECT ProductId, ProductName, Description, Price, StockQuantity FROM Product;";

                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                IdProduct = reader.GetInt32(0),
                                ProductName = reader.IsDBNull(1) ? null : reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Price = reader.GetDecimal(3),
                                StockQuantity = reader.GetInt32(4)
                            };
                            listProducts.Add(product);
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

            return listProducts;
        }
        public List<Product> GetProducts1()
        {
            List<Product> listProducts = new List<Product>();

            try
            {
                string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))

                {
                    connection.Open();
                    string query = "SELECT ProductId, ProductName, Description, Price, StockQuantity FROM Product WHERE Categoryid=1;";

                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                IdProduct = reader.GetInt32(0),
                                ProductName = reader.IsDBNull(1) ? null : reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Price = reader.GetDecimal(3),
                                StockQuantity = reader.GetInt32(4)
                            };
                            listProducts.Add(product);
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

            return listProducts;
        }
        public List<Product> GetProducts2()
        {
            List<Product> listProducts = new List<Product>();

            try
            {
                string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))

                {
                    connection.Open();
                    string query = "SELECT ProductId, ProductName, Description, Price, StockQuantity FROM Product WHERE Categoryid=2;";

                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                IdProduct = reader.GetInt32(0),
                                ProductName = reader.IsDBNull(1) ? null : reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Price = reader.GetDecimal(3),
                                StockQuantity = reader.GetInt32(4)
                            };
                            listProducts.Add(product);
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

            return listProducts;
        }
        public List<Product> GetProducts3()
        {
            List<Product> listProducts = new List<Product>();

            try
            {
                string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))

                {
                    connection.Open();
                    string query = "SELECT ProductId, ProductName, Description, Price, StockQuantity FROM Product WHERE Categoryid=3;";

                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                IdProduct = reader.GetInt32(0),
                                ProductName = reader.IsDBNull(1) ? null : reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Price = reader.GetDecimal(3),
                                StockQuantity = reader.GetInt32(4)
                            };
                            listProducts.Add(product);
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

            return listProducts;
        }
        public List<Product> SortProduct()
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn
            List<Product> listProducts = new List<Product>();
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "SELECT ProductId, ProductName, Description, Price, StockQuantity FROM Product order by Price";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            IdProduct = reader.GetInt32(0),
                            ProductName = reader.IsDBNull(1) ? null : reader.GetString(1),
                            Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            StockQuantity = reader.GetInt32(4)
                        };
                        listProducts.Add(product);
                    }
                }
            }
            return listProducts;
        }
        public List<Product> SortProduct1()
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn
            List<Product> listProducts = new List<Product>();
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "SELECT ProductId, ProductName, Description, Price, StockQuantity FROM Product order by StockQuantity";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            IdProduct = reader.GetInt32(0),
                            ProductName = reader.IsDBNull(1) ? null : reader.GetString(1),
                            Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            StockQuantity = reader.GetInt32(4)
                        };
                        listProducts.Add(product);
                    }
                }
            }
            return listProducts;
        }
        internal void AddProduct(Product product)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "INSERT INTO Product (ProductName, Description, Price, StockQuantity) VALUES (@ProductName, @Description, @Price, @StockQuantity)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", product.ProductName);
                    command.Parameters.AddWithValue("@Description", product.Description);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                    command.ExecuteNonQuery();
                }
            }
        }

        internal void DeleteProduct(decimal idProduct)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "DELETE FROM Product WHERE ProductId = @ProductId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", idProduct);
                    command.ExecuteNonQuery();
                }
            }
        }

        internal void UpdateProduct(decimal idProduct, String Name, String Description,decimal Price,decimal Stock)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "UPDATE Product SET ProductName = @ProductName, Description = @Description, Price = @Price, StockQuantity = @StockQuantity WHERE ProductId = @ProductId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductId", idProduct);
                    command.Parameters.AddWithValue("@ProductName", Name);
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@StockQuantity",Stock);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
   
public class Product
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}