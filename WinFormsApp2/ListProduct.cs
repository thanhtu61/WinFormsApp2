using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class ListProduct
    {
        private DatabaseAccess dbAccess;

        public ListProduct()
        {
            dbAccess = new DatabaseAccess();
        }

        public List<Product> GetProducts(int? categoryId = null)
        {
            List<Product> listProducts = new List<Product>();
            string query = "SELECT ProductId, ProductName, Description, Price, StockQuantity, Categoryid FROM Product";

            if (categoryId.HasValue)
            {
                query += " WHERE Categoryid = @Categoryid;";
            }

            try
            {
                dbAccess.ExecuteReader(query, command =>
                {
                    if (categoryId.HasValue)
                    {
                        command.Parameters.AddWithValue("@Categoryid", categoryId.Value);
                    }
                },
                reader =>
                {
                    var product = new Product
                    {
                        IdProduct = reader.GetInt32(0),
                        ProductName = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Price = reader.GetDecimal(3),
                        StockQuantity = reader.GetInt32(4),
                        Category = reader.GetInt32(5)
                    };
                    listProducts.Add(product);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return listProducts;
        }

        internal void AddProduct(Product product)
        {
            string query = "INSERT INTO Product (ProductName, Description, Price, StockQuantity, Categoryid) VALUES (@ProductName, @Description, @Price, @StockQuantity, @Categoryid)";
            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@ProductName", product.ProductName);
                    command.Parameters.AddWithValue("@Description", product.Description);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                    command.Parameters.AddWithValue("@Categoryid", product.Category);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        internal void DeleteProduct(int idProduct)
        {
            string query = "DELETE FROM Product WHERE ProductId = @ProductId";
            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@ProductId", idProduct);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        internal void UpdateProduct(int idProduct, string name, string description, decimal price, int stock)
        {
            string query = "UPDATE Product SET ProductName = @ProductName, Description = @Description, Price = @Price, StockQuantity = @StockQuantity WHERE ProductId = @ProductId";
            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@ProductId", idProduct);
                    command.Parameters.AddWithValue("@ProductName", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@StockQuantity", stock);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
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
        public int Category { get; set; }
    }
}