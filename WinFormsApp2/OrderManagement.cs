using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class OrderManagement : Form
    {
        private List<ListOrder.Order> orders;
        private ListOrder listOrder;

        public OrderManagement()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                listOrder = new ListOrder();
                orders = listOrder.GetOrders();
                dataGridView1.DataSource = orders;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при загрузке данных заказа:{ex.Message}", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm form1 = new AdminForm();
            this.Hide();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserManagement form1 = new UserManagement();
            this.Hide();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int Id = (int)numericUpDownId.Value;
            listOrder.DeleteOrder(Id);
            LoadData();
            numericUpDownId.Value = 0;
        }

       
    }
}