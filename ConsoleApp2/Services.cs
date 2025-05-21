using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.Extensibility;

namespace ConsoleApp2
{
    internal class Services
    {
        private readonly SqlConnectionStringBuilder _str = new SqlConnectionStringBuilder()
        {
            DataSource = "DELL",
            InitialCatalog = "DotNetTraining",
            UserID = "SA",
            Password = "root",
            TrustServerCertificate = true
        };
        public void Read()
        {

            SqlConnection connection = new SqlConnection(_str.ConnectionString);
            connection.Open();

            string query = "select * from Tbl_HomeWork";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            connection.Close();
            //First Loop Database
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                DataColumn col1 = dt.Columns["Roll_No"];
                DataColumn col2 = dt.Columns["Name"];
                DataColumn col3 = dt.Columns["GitHubUserName"];
                Console.Write(dr[col1] + " ");
                Console.Write(dr[col2] + " ");
                Console.WriteLine(dr[col3] + "");
                Console.WriteLine("=======================================");
            }

            foreach (DataRow dr in dt.Rows)
            {
                DataColumn col1 = dt.Columns["Roll_No"];
                DataColumn col2 = dt.Columns["Name"];
                DataColumn col3 = dt.Columns["GitHubUserName"];
                Console.WriteLine(dr[col1] + " " + dr[col2] + " " + dr[col3]);
            }


        }

        public void ReadDetail(int no)
        {
            SqlConnection connnection = new SqlConnection(_str.ConnectionString);
            connnection.Open();
            string query = $"select * from Tbl_HomeWork where Roll_No = {no}";
            SqlCommand cmd = new SqlCommand(query, connnection);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            connnection.Close();
            if (dt.Rows.Count == 0)
            {
                Console.WriteLine("Row Are Not Found");
                return;
            }
            DataRow dr = dt.Rows[0];
            DataColumn col1 = dt.Columns["Roll_No"];
            DataColumn col2 = dt.Columns["Name"];
            DataColumn col3 = dt.Columns["GitHubUserName"];
            Console.WriteLine(dr[col1] + " " + dr[col2] + " " + dr[col3]);
        }

        public void Create()
        {
            Console.Write("Enter Your Name : ");
            string Name = Console.ReadLine()!;

            Console.Write("Enter Your Github User Name : ");
            string GitHubUserName = Console.ReadLine()!;

            Console.Write("Enter Your Github Repo Link : ");
            string GitHubRepoLink = Console.ReadLine()!;


            SqlConnection connection = new SqlConnection(_str.ConnectionString);
            connection.Open();
            string query = $@"INSERT INTO [dbo].[Tbl_HomeWork]
           ([Name]
           ,[GitHubUserName]
           ,[GitHubRepoLink])
     VALUES
           ('{Name}'
           ,'{GitHubUserName}'
           ,'{GitHubRepoLink}')";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("You Insert Successfully");
        }

        public void Login()
        {
        BeforeUserName:
            Console.Write("Enter Your Roll_No: ");
            string Roll_No = Console.ReadLine()!;
            int.TryParse(Roll_No, out int roll_no);

            SqlConnection connection = new SqlConnection(_str.ConnectionString);
            connection.Open();
            string query = $@"Sp_Login";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Roll_No", roll_no);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            connection.Close();
            if (dt.Rows.Count == 0)
            {
                Console.WriteLine("User Name Not Found");
                goto BeforeUserName;
            }
            DataRow dr = dt.Rows[0];
            DataColumn dc1 = dt.Columns["Roll_No"];
            DataColumn dc2 = dt.Columns["Name"];
            DataColumn dc3 = dt.Columns["GitHubUserName"];
            Console.WriteLine("Login successful!");
            Console.WriteLine(dr[dc1] + " " + dr[dc2] + " " + dr[dc3]);

        }

        public void Update()
        {
        BeforeUpdate:
            Console.Write("Enter Your Roll Number:");
            string Roll_No = Console.ReadLine()!;
            int.TryParse(Roll_No, out int roll_no);
            SqlConnection conn = new SqlConnection(_str.ConnectionString);
            conn.Open();
            string query1 = $"select * from Tbl_HomeWork where Roll_No = @Roll_No";
            SqlCommand cmd = new SqlCommand(query1, conn);
            cmd.Parameters.AddWithValue("@Roll_No", roll_no);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            conn.Close();
            if (dt.Rows.Count == 0)
            {
                Console.WriteLine("Your Roll_No Not Found");
                goto BeforeUpdate;
            }



            Console.Write("Enter Your Edit Name:");
            string Name = Console.ReadLine()!;

            Console.Write("Enter Your Edit Github Name:");
            string GitHubUserName = Console.ReadLine()!;


            SqlConnection connection = new SqlConnection(_str.ConnectionString);
            connection.Open();
            string query = $@"Sp_Update";
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Roll_No", Roll_No);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@GitHubUserName", GitHubUserName);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("You Update Successfully");
        }

        public void Delete()
        {
        BeforeDelete:
            Console.Write("Enter Your Roll_No : ");
            int Roll_No = Convert.ToInt32(Console.ReadLine());
            SqlConnection conn = new SqlConnection(_str.ConnectionString);
            conn.Open();
            string query1 = @"select * from Tbl_HomeWork where Roll_No = @Roll_No";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@Roll_No", Roll_No);
            SqlDataAdapter adt = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            conn.Close();
            if (dt.Rows.Count == 0)
            {
                Console.WriteLine("Your Roll No Not Found");
                goto BeforeDelete;
            }
            Console.WriteLine("Are You Sure Delete (y/n)");
            string yes = Console.ReadLine();
            if (yes.ToUpper() == "Y")
            {
                conn.Open();
                string query2 = @"DELETE FROM Tbl_HomeWork
      WHERE Roll_No = @Roll_No";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@Roll_No", Roll_No);
                cmd2.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("You Delete Successfully");
            }


        }

        public void LoginWithDapper()
        {
            using IDbConnection connection = new SqlConnection(_str.ConnectionString);
            Console.Write("Enter Your Roll No : ");
            int Roll_No = Convert.ToInt32(Console.ReadLine());
            string query = "select * from Tbl_HomeWork where Roll_No = @Roll_No";
            var list = connection.Query<HomeWork>(query, new {Roll_No});
            if (list.Any())
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item.GitHubUserName);
                    return;
                }
            }else
            {
                Console.WriteLine("Your Roll No Not Found");
                return;
            }
            
           
        }

    }
}