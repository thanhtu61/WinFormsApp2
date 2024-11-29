using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class ListClient
    {
        private DatabaseAccess dbAccess;

        public ListClient()
        {
            dbAccess = new DatabaseAccess();
        }

        public List<Client> GetClients()
        {
            List<Client> listClients = new List<Client>();
            string query = "SELECT ClientId, ClientName, Description, Price, StockQuantity FROM Client;";

            try
            {
                dbAccess.ExecuteReader<Client>(query, command => { }, reader =>
                {
                    // Create a new Client object for each row
                    var client = new Client
                    {
                        IdClient = reader.GetInt32(0), // ClientId
                        ClientName = reader.IsDBNull(1) ? null : reader.GetString(1), // ClientName
                        Description = reader.IsDBNull(2) ? null : reader.GetString(2), // Description
                        Price = reader.GetDecimal(3), // Price
                        StockQuantity = reader.GetInt32(4) // StockQuantity
                    };
                    listClients.Add(client); // Add the client to the list
                    return client; // Return the client object
                });
            }
            catch (SqlException ex)
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
            List<Client> listClients = new List<Client>();
            string query = "SELECT ClientId, ClientName, Description, Price, StockQuantity FROM Client ORDER BY Price;";

            try
            {
                dbAccess.ExecuteReader<Client>(query, command => { }, reader =>
                {
                    // Create a new Client object for each row
                    var client = new Client
                    {
                        IdClient = reader.GetInt32(0), // ClientId
                        ClientName = reader.IsDBNull(1) ? null : reader.GetString(1), // ClientName
                        Description = reader.IsDBNull(2) ? null : reader.GetString(2), // Description
                        Price = reader.GetDecimal(3), // Price
                        StockQuantity = reader.GetInt32(4) // StockQuantity
                    };
                    listClients.Add(client); // Add the client to the list
                    return client; // Return the client object
                });
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return listClients;
        }

        internal void AddClient(Client client)
        {
            string query = "INSERT INTO Client (ClientName, Description, Price, StockQuantity) VALUES (@ClientName, @Description, @Price, @StockQuantity)";

            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@ClientName", client.ClientName);
                    command.Parameters.AddWithValue("@Description", client.Description);
                    command.Parameters.AddWithValue("@Price", client.Price);
                    command.Parameters.AddWithValue("@StockQuantity", client.StockQuantity);
                });
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        internal void DeleteClient(int idClient)
        {
            string query = "DELETE FROM Client WHERE ClientId = @ClientId";

            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@ClientId", idClient);
                });
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        internal void UpdateClient(int idClient, string name, string description, decimal price, int stock)
        {
            string query = "UPDATE Client SET ClientName = @ClientName, Description = @Description, Price = @Price, StockQuantity = @StockQuantity WHERE ClientId = @ClientId";

            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@ClientId", idClient);
                    command.Parameters.AddWithValue("@ClientName", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@StockQuantity", stock);
                });
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
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