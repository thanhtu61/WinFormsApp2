namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một instance của form AdminLogin
            AdminLogin adminLoginForm = new AdminLogin();

            // Hiển thị form AdminLogin
            adminLoginForm.Show(); // Hoặc sử dụng adminLoginForm.ShowDialog() nếu bạn muốn nó là modal

            // Nếu bạn muốn đóng form hiện tại sau khi mở form AdminLogin
            this.Hide(); // Hoặc this.Close(); nếu bạn muốn đóng form hiện tại
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tạo một instance của form AdminLogin
            ClientLogin clientLoginForm = new ClientLogin();

            // Hiển thị form AdminLogin
            clientLoginForm.Show(); // Hoặc sử dụng adminLoginForm.ShowDialog() nếu bạn muốn nó là modal

            // Nếu bạn muốn đóng form hiện tại sau khi mở form AdminLogin
            this.Hide(); // Hoặc this.Close(); nếu bạn muốn đóng form hiện tại
        }
    }
}
