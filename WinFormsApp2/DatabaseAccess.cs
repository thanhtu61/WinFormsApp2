using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public class DatabaseAccess
    {
        private string connectionString;

        public DatabaseAccess()
        {
            connectionString = "Server=192.168.0.102;Database=TelephoneStore;User Id=aa;Password=113112111Tien;";
        }

        public void ExecuteNonQuery(string query, Action<SqlCommand> parameterAction)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    parameterAction(command);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void ExecuteReader(string query, Action<SqlCommand> prepareCommand, Action<SqlDataReader> readAction)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    prepareCommand(command);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            readAction(reader); // Call the action for each row
                        }
                    }
                }
            }
        }
        public T ExecuteScalar<T>(string query, Action<SqlCommand> prepareCommand)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        prepareCommand(command);
                        var result = command.ExecuteScalar();
                        return (T)Convert.ChangeType(result, typeof(T)); // Convert result to the expected type
                    }
                }
          
        }

        public List<T> ExecuteReader<T>(string query, Action<SqlCommand> parameterAction, Func<SqlDataReader, T> readAction)
        {
            var result = new List<T>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    parameterAction(command);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(readAction(reader));
                        }
                    }
                }
            }
            return result;
        }
    }
}