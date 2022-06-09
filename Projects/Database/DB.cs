using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Database
{
    public class DB
    {
        private string _connectionString;
        protected SqlConnection _connection; 

        public DB(string server, string dbName, string user, string password)
        {
            _connectionString = $"Data Source={server}; Initial Catalog={dbName};" +
                $"User={user}; Password={password}; Trusted_Connection = True";
        }

        public void Connect()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void Close()
        {
            if(_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
            
        }
    }
}
