using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class CartForm : Form
    {
        private List<ListCart.Cart> carts; // Changed from CartForm to Cart
        private ListCart listCart;
        public int ClientID; // Use property for better encapsulation

        public CartForm(int clientID)
        {
            this.ClientID = clientID;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            listCart = new ListCart();
            carts = listCart.ClientGetCart(this.ClientID);
            dataGridView1.DataSource = carts;
            //dataGridView1.Columns["clientID"].Visible = false;
        }
       
        private void ClearInputFields()
        {

            numericUpDown1.Value = 0;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm form1 = new ClientForm(ClientID);
            this.Hide();
            form1.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            decimal Id = numericUpDown1.Value;
            listCart.DeleteCart(Id);
            LoadData();
            ClearInputFields();
        }
    }


}