namespace WinFormsApp2
{
    partial class ClientForm
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
            btnSortByPrice = new Button();
            dataGridView1 = new DataGridView();
            AddToCart = new Button();
            cart = new Button();
            numericUpDownQuantity = new NumericUpDown();
            numericUpDownProductId = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
           // button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(713, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Finish";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSortByPrice
            // 
            btnSortByPrice.Location = new Point(679, 32);
            btnSortByPrice.Name = "btnSortByPrice";
            btnSortByPrice.Size = new Size(118, 23);
            btnSortByPrice.TabIndex = 3;
            btnSortByPrice.Text = "Sort by price";
            btnSortByPrice.UseVisualStyleBackColor = true;
            //btnSortByPrice.Click += btnSortByPrice_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(250, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(547, 259);
            dataGridView1.TabIndex = 5;
            // 
            // AddToCart
            // 
            AddToCart.Location = new Point(118, 282);
            AddToCart.Name = "AddToCart";
            AddToCart.Size = new Size(75, 23);
            AddToCart.TabIndex = 6;
            AddToCart.Text = "Add to cart";
            AddToCart.UseVisualStyleBackColor = true;
            AddToCart.Click += AddToCart_Click;
            // 
            // cart
            // 
            cart.Location = new Point(713, 338);
            cart.Name = "cart";
            cart.Size = new Size(75, 23);
            cart.TabIndex = 7;
            cart.Text = "Cart";
            cart.UseVisualStyleBackColor = true;
            cart.Click += cart_Click;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(108, 214);
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(120, 23);
            numericUpDownQuantity.TabIndex = 8;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownProductId
            // 
            numericUpDownProductId.Location = new Point(108, 157);
            numericUpDownProductId.Name = "numericUpDownProductId";
            numericUpDownProductId.Size = new Size(120, 23);
            numericUpDownProductId.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 139);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 10;
            label1.Text = "Product Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 196);
            label2.MinimumSize = new Size(1, 1);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 11;
            label2.Text = "Quantity";
            // 
            // button3
            // 
            button3.Location = new Point(250, 17);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Telephone";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(341, 17);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Ipad";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(432, 17);
            button5.Name = "button5";
            button5.Size = new Size(113, 23);
            button5.TabIndex = 14;
            button5.Text = "Other Equipment";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(564, 32);
            button6.Name = "button6";
            button6.Size = new Size(109, 23);
            button6.TabIndex = 15;
            button6.Text = "Sort by quantity";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownProductId);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(cart);
            Controls.Add(AddToCart);
            Controls.Add(dataGridView1);
            Controls.Add(btnSortByPrice);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnSortByPrice;
        private DataGridView dataGridView1;
        private Button AddToCart;
        private Button cart;
        private NumericUpDown numericUpDownQuantity;
        private NumericUpDown numericUpDownProductId;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}