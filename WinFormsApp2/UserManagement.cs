using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace WinFormsApp2
{
    public partial class UserManagement : Form
    {
        private List<User> Users;
        private ListUser listUser;

        public UserManagement()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            listUser = new ListUser();
            Users = listUser.GetUsers();
            dataGridView1.DataSource = Users; 
            dataGridView1.Columns["Password"].Visible = false;
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            decimal Id = numericUpDownId.Value;
            listUser.DeleteUser(Id);
            LoadData();
            ClearInputFields();
        }
       
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            decimal Id = numericUpDownId.Value;
            string Name = textBoxName.Text;
            string Email = textBoxEmail.Text;
            string Password= textBoxPassword.Text;
            string Phone = textBoxPhone.Text;
            string Address = textBoxAddress.Text;


            listUser.UpdateUser(Id, Name, Email, Password, Phone, Address);
            LoadData();
            ClearInputFields();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            User newUser = new User
            {
                UserName = textBoxName.Text,
                Email = textBoxEmail.Text,
                Password = textBoxPassword.Text,
                Phone = textBoxPhone.Text,
                Address = textBoxAddress.Text
            };

            listUser.AddUser(newUser);
            LoadData();
            ClearInputFields();
        }


        private void ClearInputFields()
        {
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxPhone.Clear();
            textBoxAddress.Clear();
            numericUpDownId.Value = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm form1 = new AdminForm();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }    
    }
}
