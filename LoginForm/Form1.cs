using System.Data;
using Microsoft.Data.SqlClient;
namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void label1_Username(object sender, EventArgs e)
        {

        }
        private void textBox1_Username(object sender, EventArgs e)
        {

        }

        private void Label2_Password(object sender, EventArgs e)
        {

        }
        private void textBox1_Password(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(_str.ConnectionString);
            string username = txtUsername.Text;
            string password = txtPassword.Text.Trim();
            connection.Open();
            string query = $"select * from Tbl_Window where UserName = '{username}' and Password = '{password}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            connection.Close();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("You User Name Or Password incorrect!");

            }
            else
            {
                MessageBox.Show("You SuccessFully Login!");
                this.DialogResult = DialogResult.OK;
            }
        }

        //private void btn_Cancel(object sender, EventArgs e)
        //{
        //    txtUsername.Clear();
        //    txtPassword.Clear();
        //    this.DialogResult = DialogResult.OK;
        //}

        private void Create_Account(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
