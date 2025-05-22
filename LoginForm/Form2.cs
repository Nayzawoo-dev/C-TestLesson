using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LoginForm
{
    public partial class Form2 : Form
    {
        Service services;
        public Form2()
        {
            InitializeComponent();
            services = new Service();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string query = @"INSERT INTO [dbo].[Tbl_Window]
           ([UserName]
           ,[Password])
     VALUES
           (@Username
           ,@Password)";
            services.CreateQuery(query, new SqlParameter("@Username", username),new SqlParameter("@Password",password));
            MessageBox.Show("Your Account Successfully Create!");
            this.DialogResult = DialogResult.OK;

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
