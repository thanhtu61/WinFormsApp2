using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class AdminForm : Form
    {
        private List<Product> products;
        private ListProduct listProduct;
        public AdminForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts();
            dataGridView1.DataSource = products;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu bạn muốn xử lý sự kiện khi người dùng click vào các ô trong DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Product selectedProduct = (Product)dataGridView1.SelectedRows[0].DataBoundItem;
                textBoxName.Text = selectedProduct.ProductName;
                textBoxDescription.Text = selectedProduct.Description;
                numericUpDownPrice.Value = selectedProduct.Price;
                numericUpDownStock.Value = selectedProduct.StockQuantity;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            listProduct = new ListProduct();
            products = listProduct.SortProduct();
            dataGridView1.DataSource = products;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            decimal Id = numericUpDownId.Value;
            listProduct.DeleteProduct(Id);
            LoadData();
            ClearInputFields();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            decimal Id = numericUpDownId.Value;
            string Name = textBoxName.Text;
            string Description = textBoxDescription.Text;
            decimal Price = numericUpDownPrice.Value;
            decimal Stock = numericUpDownStock.Value;

            listProduct.UpdateProduct(Id, Name, Description, Price, Stock);
            LoadData();
            ClearInputFields();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                ProductName = textBoxName.Text,
                Description = textBoxDescription.Text,
                Price = numericUpDownPrice.Value,
                StockQuantity = (int)numericUpDownStock.Value
            };

            listProduct.AddProduct(newProduct);
            LoadData();
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
            numericUpDownPrice.Value = 0;
            numericUpDownStock.Value = 0;
            numericUpDownId.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserManagement form1 = new UserManagement();
            this.Hide();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderManagement form1 = new OrderManagement();
            this.Hide();
            form1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts1();
            dataGridView1.DataSource = products;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts2();
            dataGridView1.DataSource = products;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listProduct = new ListProduct();
            products = listProduct.GetProducts3();
            dataGridView1.DataSource = products;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listProduct = new ListProduct();
            products = listProduct.SortProduct1();
            dataGridView1.DataSource = products;
        }
    }
}
