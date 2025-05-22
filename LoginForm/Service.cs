using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LoginForm
{
    internal class Service
    {
        private readonly SqlConnectionStringBuilder _str = new SqlConnectionStringBuilder()
        {
            DataSource = "DELL",
            InitialCatalog = "DotNetTraining",
            UserID = "SA",
            Password = "root",
            TrustServerCertificate = true
        };



        public DataTable ReadQuery(string query,List<SqlParameter> parameter)
        {
            SqlConnection connection = new SqlConnection(_str.ConnectionString);  
            connection.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddRange(parameter.ToArray());
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dt);
            connection.Close();
            return dt; 
        }

        public int CreateQuery(string query,params SqlParameter[] parameter)
        {
            SqlConnection connection = new SqlConnection(_str.ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddRange(parameter);
            int res = cmd.ExecuteNonQuery();
            connection.Close();
            return res;
        }
    }
}
