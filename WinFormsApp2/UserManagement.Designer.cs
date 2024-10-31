namespace WinFormsApp2
{
    partial class UserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            numericUpDownId = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            label6 = new Label();
            textBoxPassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            button4 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(269, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 322);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(0, -3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(722, 423);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Finish";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 262);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 41;
            label5.Text = "Address";
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(14, 52);
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(120, 23);
            numericUpDownId.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 219);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 39;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 175);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 38;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 78);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 37;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 34);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 36;
            label1.Text = "Id User";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(16, 193);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 33;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(14, 96);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 32;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(176, 333);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(95, 333);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 333);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 23);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add Client";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(16, 236);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(100, 23);
            textBoxPhone.TabIndex = 42;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(16, 280);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 23);
            textBoxAddress.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 131);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 44;
            label6.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(14, 149);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 415);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 48;
            label8.Text = "Delete: Only enter IdUser";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 387);
            label7.Name = "label7";
            label7.Size = new Size(134, 15);
            label7.TabIndex = 47;
            label7.Text = "Edit: Enter all the button";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 363);
            label9.Name = "label9";
            label9.Size = new Size(159, 15);
            label9.TabIndex = 46;
            label9.Text = "Note: Add : Not enter Id User";
            // 
            // button4
            // 
            button4.Location = new Point(676, 363);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 50;
            button4.Text = "ProductManagement";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(676, 394);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 49;
            button3.Text = "OrderManagement";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(textBoxPassword);
            Controls.Add(label6);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPhone);
            Controls.Add(label5);
            Controls.Add(numericUpDownId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Label label5;
        private NumericUpDown numericUpDownId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private Label label6;
        private TextBox textBoxPassword;
        private Label label8;
        private Label label7;
        private Label label9;
        private Button button4;
        private Button button3;
    }
}