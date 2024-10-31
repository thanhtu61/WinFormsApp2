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
            button1.Click += button1_Click_1;
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
            btnSortByPrice.Location = new Point(662, 16);
            btnSortByPrice.Name = "btnSortByPrice";
            btnSortByPrice.Size = new Size(118, 23);
            btnSortByPrice.TabIndex = 3;
            btnSortByPrice.Text = "Sort by price";
            btnSortByPrice.UseVisualStyleBackColor = true;
            btnSortByPrice.Click += btnSortByPrice_Click_1;
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
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}