using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

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
            for (int i = 0; i < dt.Rows.Count; i++) {
            DataRow dr = dt.Rows[i];
                DataColumn col1 = dt.Columns["Roll_No"];
                DataColumn col2 = dt.Columns["Name"];
                DataColumn col3 = dt.Columns["GitHubUserName"];
                Console.Write(dr[col1] + " ");
                Console.Write(dr[col2] + " ");
                Console.WriteLine(dr[col3] + "");
                Console.WriteLine("=======================================");
            }

            foreach (DataRow dr in dt.Rows) {
                DataColumn col1 = dt.Columns["Roll_No"];
                DataColumn col2 = dt.Columns["Name"];
                DataColumn col3 = dt.Columns["GitHubUserName"];
                Console.WriteLine(dr[col1] + " " + dr[col2] + " " + dr[col3]);
            }


        }

        public void ReadDetail(string no)
        {
            SqlConnection connnection = new SqlConnection(_str.ConnectionString); 
            connnection.Open();
            string query = $"select * from Tbl_HomeWork where Roll_No = '{no}'";
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
            Console.WriteLine(dr[col1]+ " " + dr[col2]+ " " + dr[col3]);
        }
    }

}