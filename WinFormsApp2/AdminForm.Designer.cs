namespace WinFormsApp2
{
    partial class AdminForm
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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSortByPrice = new Button();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            numericUpDownStock = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDownId = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 1);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(725, 427);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Finish";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(260, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(540, 318);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 331);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(81, 331);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(162, 331);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSortByPrice
            // 
            btnSortByPrice.Location = new Point(690, 16);
            btnSortByPrice.Name = "btnSortByPrice";
            btnSortByPrice.Size = new Size(96, 23);
            btnSortByPrice.TabIndex = 18;
            btnSortByPrice.Text = "Sort by Price";
            btnSortByPrice.UseVisualStyleBackColor = true;
            btnSortByPrice.Click += btnSortByPrice_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 123);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 19;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 179);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(100, 23);
            textBoxDescription.TabIndex = 20;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(12, 289);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 23);
            numericUpDownStock.TabIndex = 21;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(14, 232);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 23;
            label1.Text = "Id Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 105);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 24;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 25;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 214);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 26;
            label4.Text = "Price";
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(13, 70);
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(120, 23);
            numericUpDownId.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 271);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 28;
            label5.Text = "Stock Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 374);
            label6.Name = "label6";
            label6.Size = new Size(178, 15);
            label6.TabIndex = 29;
            label6.Text = "Note: Add : Not enter Id Product";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 398);
            label7.Name = "label7";
            label7.Size = new Size(134, 15);
            label7.TabIndex = 30;
            label7.Text = "Edit: Enter all the button";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 426);
            label8.Name = "label8";
            label8.Size = new Size(156, 15);
            label8.TabIndex = 31;
            label8.Text = "Delete: Only enter IdProduct";
            // 
            // button3
            // 
            button3.Location = new Point(679, 398);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 32;
            button3.Text = "UserManagement";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(679, 366);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 33;
            button4.Text = "OrderManagement";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(575, 16);
            button6.Name = "button6";
            button6.Size = new Size(109, 23);
            button6.TabIndex = 37;
            button6.Text = "Sort by quantity";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(443, 1);
            button5.Name = "button5";
            button5.Size = new Size(113, 23);
            button5.TabIndex = 36;
            button5.Text = "Other Equipment";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(352, 1);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 35;
            button7.Text = "Ipad";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(261, 1);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 34;
            button8.Text = "Telephone";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numericUpDownId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownStock);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(btnSortByPrice);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSortByPrice;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private NumericUpDown numericUpDownStock;
        private NumericUpDown numericUpDownPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownId;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
    }
}