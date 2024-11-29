using System;
using System.Data.SqlClient; // Use SqlClient to connect to SQL Server
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class AdminLogin : Form
    {
        private DatabaseAccess dbAccess; // Create a database access instance

        public AdminLogin()
        {
            InitializeComponent(); // Initialize the components
            dbAccess = new DatabaseAccess(); // Initialize the DatabaseAccess class
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get username and password from text boxes
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Check login information
            if (CheckLogin(username, password))
            {
                // If login is successful, open AdminForm
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // If login fails, show an error message
                MessageBox.Show("Username or password is incorrect. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckLogin(string username, string password)
        {
            // SQL query to check login information
            string query = "SELECT * FROM Admin JOIN [User] ON Admin.UserID = [User].UserID WHERE Username = @username AND Password = @password";

            // Use DatabaseAccess to execute the query
            var result = dbAccess.ExecuteReader(query, command =>
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
            }, reader => reader.Read()); // Read action to return true if a record exists

            return result.Count > 0; // Return true if any records were found
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Show the main form
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}