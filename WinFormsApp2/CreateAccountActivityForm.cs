using System;
using System.Data.SQLite; // Make sure to use the correct namespace if you are using SQL Server.
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class CreateAccountActivityForm : Form
    {
        private DatabaseAccess dbAccess; // Create a database access instance

        public CreateAccountActivityForm()
        {
            InitializeComponent();
            dbAccess = new DatabaseAccess(); // Initialize DatabaseAccess
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            // Validate input (you can add more validation as needed)
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password are required.");
                return;
            }

            // SQL query to insert into User table
            string userInsertQuery = "INSERT INTO [User] (Username, Password, Email, Phone, Address) VALUES (@Username, @Password, @Email, @Phone, @Address); SELECT last_insert_rowid();";

            try
            {
                // Use DatabaseAccess to execute the user insert and retrieve the new user ID
                long userId = dbAccess.ExecuteScalar<long>(userInsertQuery, command =>
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Address", address);
                });

                // Check if the user was created successfully
                if (userId > 0)
                {
                    MessageBox.Show("Account created successfully!");

                    // Insert into Client table
                    string clientInsertQuery = "INSERT INTO Client (UserID) VALUES (@UserID);";
                    dbAccess.ExecuteNonQuery(clientInsertQuery, command =>
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                    });
                }
                else
                {
                    MessageBox.Show("Error creating account.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show(); // Show the main form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }
}