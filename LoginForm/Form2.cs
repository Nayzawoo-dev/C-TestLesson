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
        public Form2()
        {
            InitializeComponent();
        }
        private readonly SqlConnectionStringBuilder _str = new SqlConnectionStringBuilder()
        {
            DataSource = "DELL",
            InitialCatalog = "DotNetTraining",
            UserID = "SA",
            Password = "root",
            TrustServerCertificate = true
        };

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            SqlConnection connection = new SqlConnection(_str.ConnectionString);
            connection.Open();
            string query = @"INSERT INTO [dbo].[Tbl_Window]
           ([UserName]
           ,[Password])
     VALUES
           (@Username
           ,@Password)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery();
            connection.Close();
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
