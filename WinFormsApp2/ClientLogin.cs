using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ClientLogin : Form
    {
        public ClientLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Giả sử bạn có một hàm kiểm tra thông tin đăng nhập
            if (CheckLogin(username, password))
            {
                // Nếu thông tin đăng nhập đúng, mở form AdminForm
                ClientForm clientForm = new ClientForm();
                clientForm.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                // Nếu thông tin đăng nhập không đúng, hiển thị thông báo
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng nhập lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Chuyển sang CreateAccountActivityForm
            CreateAccountActivityForm createAccountForm = new CreateAccountActivityForm();
            createAccountForm.Show();
            this.Hide(); // Ẩn form đăng nhập
        }

        private bool CheckLogin(string username, string password)
        {
            // Đường dẫn đến cơ sở dữ liệu của bạn
            string dbPath = "ComputerStote.db"; // Thay đổi đường dẫn đến cơ sở dữ liệu của bạn

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();

                // Truy vấn để kiểm tra thông tin đăng nhập
                string query = "select * from Client join [user] on Client.UserID= [user].UserID WHERE Username = @username AND Password = @password";
                using (var command = new SQLiteCommand(query, connection))
                {
                    // Thêm tham số vào câu lệnh
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    // Thực hiện truy vấn và kiểm tra kết quả
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Nếu có ít nhất một dòng kết quả
                        {
                            return true; // Đăng nhập thành công
                        }
                        else
                        {

                            return false; // Đăng nhập thất bại
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
