namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdminLogin = new Button();
            btnClientLogin = new Button();
            SuspendLayout();
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Location = new Point(327, 104);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(133, 46);
            btnAdminLogin.TabIndex = 0;
            btnAdminLogin.Text = "Admin";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += button1_Click;
            // 
            // btnClientLogin
            // 
            btnClientLogin.Location = new Point(327, 177);
            btnClientLogin.Name = "btnClientLogin";
            btnClientLogin.Size = new Size(133, 45);
            btnClientLogin.TabIndex = 1;
            btnClientLogin.Text = "Client";
            btnClientLogin.UseVisualStyleBackColor = true;
            btnClientLogin.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClientLogin);
            Controls.Add(btnAdminLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdminLogin;
        private Button btnClientLogin;
    }
}
