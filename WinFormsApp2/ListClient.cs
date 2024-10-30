using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public class ListClient
    {
        //private const string ConnectionString = $"Data Source=ComputerStore.db;Version=3;";

        public List<Client> GetClients()
        {
            List<Client> listClients = new List<Client>();

            try
            {
                string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))

                {
                    connection.Open();
                    string query = "SELECT ClientId, ClientName, Description, Price, StockQuantity FROM Client;";

                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Client = new Client
                            {
                                IdClient = reader.GetInt32(0),
                                ClientName = reader.IsDBNull(1) ? null : reader.GetString(1),
                                Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Price = reader.GetDecimal(3),
                                StockQuantity = reader.GetInt32(4)
                            };
                            listClients.Add(Client);
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

            return listClients;
        }
        public List<Client> SortClient()
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn
            List<Client> listClients = new List<Client>();
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "SELECT ClientId, ClientName, Description, Price, StockQuantity FROM Client order by Price";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Client Client = new Client
                        {
                            IdClient = reader.GetInt32(0),
                            ClientName = reader.IsDBNull(1) ? null : reader.GetString(1),
                            Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            StockQuantity = reader.GetInt32(4)
                        };
                        listClients.Add(Client);
                    }
                }
            }
            return listClients;
        }
        internal void AddClient(Client Client)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "INSERT INTO Client (ClientName, Description, Price, StockQuantity) VALUES (@ClientName, @Description, @Price, @StockQuantity)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientName", Client.ClientName);
                    command.Parameters.AddWithValue("@Description", Client.Description);
                    command.Parameters.AddWithValue("@Price", Client.Price);
                    command.Parameters.AddWithValue("@StockQuantity", Client.StockQuantity);
                    command.ExecuteNonQuery();
                }
            }
        }

        internal void DeleteClient(decimal idClient)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "DELETE FROM Client WHERE ClientId = @ClientId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", idClient);
                    command.ExecuteNonQuery();
                }
            }
        }

        internal void UpdateClient(decimal idClient, String Name, String Description, decimal Price, decimal Stock)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "UPDATE Client SET ClientName = @ClientName, Description = @Description, Price = @Price, StockQuantity = @StockQuantity WHERE ClientId = @ClientId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", idClient);
                    command.Parameters.AddWithValue("@ClientName", Name);
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@StockQuantity", Stock);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public class Client
    {
        public int IdClient { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
