using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ClientLogin : Form
    {
        private int clientID;
        private DatabaseAccess dbAccess; // Create a database access instance

        public ClientLogin()
        {
            InitializeComponent();
            dbAccess = new DatabaseAccess(); // Initialize DatabaseAccess
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Check login credentials
            clientID = CheckLogin(username, password);
            if (clientID != 0)
            {
                // If login is successful, open ClientForm
                ClientForm clientForm = new ClientForm(clientID);
                clientForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // If login fails, display an error message
                MessageBox.Show("Username or password is incorrect. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Navigate to CreateAccountActivityForm
            CreateAccountActivityForm createAccountForm = new CreateAccountActivityForm();
            createAccountForm.Show();
            this.Hide(); // Hide the login form
        }

        private int CheckLogin(string username, string password)
        {
            // SQL query to check login credentials
            string query = "SELECT Client.ClientID FROM Client JOIN [User] ON Client.UserID = [User].UserID WHERE Username = @username AND Password = @password";

            // Use DatabaseAccess to execute the query and return the client ID
            var result = dbAccess.ExecuteScalar<int>(query, command =>
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
            });

            return result; // Return the client ID or 0 if not found
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show(); // Show the main form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Logic to handle text box changes if needed
        }
    }
}