using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public class ListUser
    {
        //private const string ConnectionString = $"Data Source=ComputerStore.db;Version=3;";

        public List<User> GetUsers()
        {
            List<User> listUsers = new List<User>();

            try
            {
                string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

                using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))

                {
                    connection.Open();
                    string query = "SELECT UserID, Username, Email,Password, Phone, Address from [User];";

                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var User = new User
                            {
                                IdUser = reader.GetInt32(0),
                                UserName = reader.IsDBNull(1) ? null : reader.GetString(1),
                                Email = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Password = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                                Address = reader.IsDBNull(5) ? null : reader.GetString(5)
                              
                            };
                            listUsers.Add(User);
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

            return listUsers;
        }
        
        internal void AddUser(User User)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "INSERT INTO [User] (UserName, Password, Email, Phone, Address) VALUES (@UserName, @Password, @Email, @Phone, @Address)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", User.UserName);
                    command.Parameters.AddWithValue("@Password", User.Password);
                    command.Parameters.AddWithValue("@Email", User.Email);
                    command.Parameters.AddWithValue("@Phone", User.Phone);
                    command.Parameters.AddWithValue("@Address", User.Address);
                    int result = command.ExecuteNonQuery();

                    // Kiểm tra xem có thêm thành công không
                    if (result > 0)
                    {
                        // Lấy UserID vừa tạo
                        long userId = connection.LastInsertRowId;

                        // Chèn vào bảng Client
                        string insertClientQuery = "INSERT INTO Client (UserID) VALUES (@UserID);";
                        using (SQLiteCommand clientCommand = new SQLiteCommand(insertClientQuery, connection))
                        {
                            clientCommand.Parameters.AddWithValue("@UserID", userId);
                            clientCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show("Account created successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error creating account.");
                    }
                }
            }
        }

        internal void DeleteUser(decimal idUser)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                // Xóa bản ghi trong bảng Client trước
                string deleteClientQuery = "DELETE FROM Client WHERE UserId = @UserId;";
                using (var clientCommand = new SQLiteCommand(deleteClientQuery, connection))
                {
                    clientCommand.Parameters.AddWithValue("@UserId", idUser);
                    int clientResult = clientCommand.ExecuteNonQuery();

                    // Kiểm tra xem có xóa thành công không
                    if (clientResult <= 0)
                    {
                        MessageBox.Show("No associated client records found to delete.");
                    }
                }

                // Sau đó xóa bản ghi trong bảng User
                string  Query = "DELETE FROM [User] WHERE UserId = @UserId;";
                using (var command = new SQLiteCommand( Query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", idUser);
                    int result = command.ExecuteNonQuery();

                    // Kiểm tra xem có xóa thành công không
                    if (result > 0)
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
        internal void UpdateUser(decimal idUser, string Name, string Email, string Password, string Phone, string Address)
        {
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string query = "UPDATE [User] SET UserName = @UserName, Email = @Email, Password = @Password, Phone = @Phone, Address = @Address WHERE UserId = @UserId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", idUser);
                    command.Parameters.AddWithValue("@UserName", Name);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Address", Address);

                    command.ExecuteNonQuery();
                }
            }
        }
      
    }

    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}


