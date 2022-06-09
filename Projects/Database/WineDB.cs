using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Database
{
    public class WineDB : DB
    {
        public WineDB(string server, string dbName, string user, string password) : base (server, dbName, user, password)
        {
            
        }

        public List<Wine> GetAll()
        {
            Connect();

            List<Wine> wine = new List<Wine>();
            string query = "SELECT ID, Name, BrandID FROM Wine";
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);
                wine.Add(new Wine(id, name, brandId));
            }

            Close();

            return wine;
        }
    }
}
