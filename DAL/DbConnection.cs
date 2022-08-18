using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADWApp.DAL
{
    internal class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection()
        {
            _connectionString = "Server=BERKE; Database = AdventureWorksDW2012; Trusted_Connection = True";

        }
        private SqlConnection GetSqlConnection()
        {
            SqlConnection cnn = new SqlConnection(_connectionString);
            if(cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Open();
            }
            else
            {
                cnn.Open();
            }
            return cnn;
        }
        public SqlCommand GetSqlCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetSqlConnection();
            return cmd;
        }

    }
}
