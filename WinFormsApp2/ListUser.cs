using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class ListUser
    {
        private DatabaseAccess dbAccess;

        public ListUser()
        {
            dbAccess = new DatabaseAccess();
        }

        public List<User> GetUsers()
        {
            List<User> listUsers = new List<User>();
            string query = "SELECT UserID, Username, Email, Password, Phone, Address FROM [User];";

            try
            {
                dbAccess.ExecuteReader(query, command => { }, reader =>
                {
                    var user = new User
                    {
                        IdUser = reader.GetInt32(0),
                        UserName = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Email = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Password = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Address = reader.IsDBNull(5) ? null : reader.GetString(5)
                    };
                    listUsers.Add(user);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return listUsers;
        }

        internal void AddUser(User user)
        {
            string query = "INSERT INTO [User] (UserName, Password, Email, Phone, Address) VALUES (@UserName, @Password, @Email, @Phone, @Address)";
            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Phone", user.Phone);
                    command.Parameters.AddWithValue("@Address", user.Address);
                });

                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        internal void DeleteUser(int idUser)
        {
            string query = "DELETE FROM [User] WHERE UserId = @UserId;";
            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@UserId", idUser);
                });

                MessageBox.Show("Account deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        internal void UpdateUser(int idUser, string name, string email, string password, string phone, string address)
        {
            string query = "UPDATE [User] SET UserName = @UserName, Email = @Email, Password = @Password, Phone = @Phone, Address = @Address WHERE UserId = @UserId";
            try
            {
                dbAccess.ExecuteNonQuery(query, command =>
                {
                    command.Parameters.AddWithValue("@UserId", idUser);
                    command.Parameters.AddWithValue("@UserName", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);
                });

                MessageBox.Show("Account updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
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