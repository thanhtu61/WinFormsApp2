namespace WinFormsApp2
{
    partial class CreateAccountActivityForm
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            username = new Label();
            password = new Label();
            email = new Label();
            phone = new Label();
            address = new Label();
            SuspendLayout();
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
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(368, 398);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Create Account";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(358, 63);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(358, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(358, 124);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(358, 252);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(357, 314);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 9;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(357, 45);
            username.Name = "username";
            username.Size = new Size(63, 15);
            username.TabIndex = 10;
            username.Text = "Username:";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(357, 106);
            password.Name = "password";
            password.Size = new Size(60, 15);
            password.TabIndex = 11;
            password.Text = "Password:";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(357, 172);
            email.Name = "email";
            email.Size = new Size(39, 15);
            email.TabIndex = 12;
            email.Text = "Email:";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(357, 234);
            phone.Name = "phone";
            phone.Size = new Size(44, 15);
            phone.TabIndex = 13;
            phone.Text = "Phone:";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(358, 296);
            address.Name = "address";
            address.Size = new Size(52, 15);
            address.TabIndex = 14;
            address.Text = "Address:";
            // 
            // CreateAccountActivityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(address);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "CreateAccountActivityForm";
            Text = "CreateAccountActivityForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Label username;
        private Label password;
        private Label email;
        private Label phone;
        private Label address;
    }
}