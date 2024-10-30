using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class CreateAccountActivityForm : Form
    {
        public CreateAccountActivityForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;



            string dbPath = "ComputerStote.db"; 
            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                try
                {
                    connection.Open();
                    // Chèn vào bảng User
                    string  Query = "INSERT INTO [User] (Username, Password, Email, Phone, Address) VALUES (@Username, @Password, @Email, @Phone, @Address);";
                    using (SQLiteCommand command = new SQLiteCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);

                        int result = command.ExecuteNonQuery();

                        // Kiểm tra xem có thêm thành công không
                        if (result > 0)
                        {
                            MessageBox.Show("Account created successfully!");

                            // Lấy UserID vừa tạo
                            long userId = connection.LastInsertRowId;

                            // Chèn vào bảng Client
                            string insertClientQuery = "INSERT INTO Client (UserID) VALUES (@UserID);";
                            using (SQLiteCommand clientCommand = new SQLiteCommand(insertClientQuery, connection))
                            {
                                clientCommand.Parameters.AddWithValue("@UserID", userId);
                                clientCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error creating account.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
