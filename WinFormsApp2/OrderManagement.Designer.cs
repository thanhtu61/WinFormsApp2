namespace WinFormsApp2
{
    partial class OrderManagement
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            numericUpDownId = new NumericUpDown();
            label1 = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 305);
            dataGridView1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(679, 366);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 37;
            button4.Text = "ProductManagement";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(679, 398);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 36;
            button3.Text = "UserManagement";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(725, 427);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 35;
            button2.Text = "Finish";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 1);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 34;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(12, 366);
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(120, 23);
            numericUpDownId.TabIndex = 43;
           // numericUpDownId.ValueChanged += numericUpDownId_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 348);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 42;
            label1.Text = "Id Order";
            label1.Click += label1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // OrderManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownId);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "OrderManagement";
            Text = "OrderManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private NumericUpDown numericUpDownId;
        private Label label1;
        private Button btnDelete;
    }
}