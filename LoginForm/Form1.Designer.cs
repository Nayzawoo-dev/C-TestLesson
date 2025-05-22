
namespace LoginForm
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
            btnLogin = new Button();
            btnCancel = new Button();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            txtPassword = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(79, 328);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btn_Login;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(184, 328);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(70, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btn_Cancel;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(84, 159);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(359, 27);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += textBox1_Username;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 136);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            label1.Click += label1_Username;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 215);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.Click += Label2_Password;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(84, 284);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(84, 238);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(359, 27);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox1_Password;
            // 
            // button1
            // 
            button1.Location = new Point(79, 374);
            button1.Name = "button1";
            button1.Size = new Size(175, 30);
            button1.TabIndex = 8;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Create_Account;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(141, 9);
            label3.Name = "label3";
            label3.Size = new Size(212, 31);
            label3.TabIndex = 9;
            label3.Text = "Login Your Account";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 601);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnLogin;
        private Button btnCancel;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox txtPassword;
        private Button button1;
        private Label label3;
    }
}
