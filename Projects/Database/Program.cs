using System;
using System.Data.SqlClient;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DB database = new DB(@"DESKTOP-QOKB6J4", "CSharpDB", "sa", "123456");

                database.Connect();
                Console.WriteLine("Successfully connected");

                database.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Cannot connect"+ "\n\n" + e.Message);
            }
            

            Console.ReadKey();
            
        }
    }
}
