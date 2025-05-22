namespace LoginForm
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_Create = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 38);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 92);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 318);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 163);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 233);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "BirthDate";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(103, 115);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(378, 27);
            txtUserName.TabIndex = 5;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(101, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(380, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 27);
            textBox1.TabIndex = 7;
            textBox1.Text = "Year-Month-Day";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 341);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(380, 27);
            textBox2.TabIndex = 8;
            textBox2.Text = "09-";
            // 
            // btn_Create
            // 
            btn_Create.BackColor = SystemColors.ActiveCaptionText;
            btn_Create.Cursor = Cursors.Hand;
            btn_Create.FlatAppearance.BorderColor = Color.White;
            btn_Create.FlatAppearance.BorderSize = 0;
            btn_Create.FlatStyle = FlatStyle.Flat;
            btn_Create.ForeColor = Color.White;
            btn_Create.Location = new Point(101, 436);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new Size(380, 39);
            btn_Create.TabIndex = 9;
            btn_Create.Text = "Create Account";
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += btn_Create_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(101, 391);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(169, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Remember Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 704);
            Controls.Add(checkBox1);
            Controls.Add(btn_Create);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_Create;
        private CheckBox checkBox1;
    }
}