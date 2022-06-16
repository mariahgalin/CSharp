using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WineDB wineDb = new WineDB(@"DESKTOP-QOKB6J4", "CSharpDB", "sa", "123456");

                bool again = true;
                int op = 0;

                do
                {
                    ShowMenu();
                    Console.WriteLine("Choose an option: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Show(wineDb);
                            break;
                        case 2:
                            Add(wineDb);
                            break;
                        case 5:
                            again = false;
                            break;
                    }


                } while (again);

                List<Wine> wine = wineDb.GetAll();

                foreach(var w in wine)
                {
                    Console.WriteLine(w.Name);
                }
                //database.Connect();
                //Console.WriteLine("Successfully connected");

                //database.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Cannot connect"+ "\n\n" + e.Message);
            }
            

            Console.ReadKey();
            
        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n ------------- MENU ------------- ");
            Console.WriteLine("    1. Show");
            Console.WriteLine("    2. Add");
            Console.WriteLine("    3. Update");
            Console.WriteLine("    4. Delete");
            Console.WriteLine("    5. Exit");
        }
        public static void Show(WineDB wineDb)
        {
            Console.Clear();
            Console.WriteLine("  Wine from database:");
            List<Wine> wine = wineDb.GetAll();

            foreach (var w in wine)
            {
                Console.WriteLine(w.Name);
            }
        }

        public static void Add(WineDB wineDb)
        {
            Console.Clear();
            Console.WriteLine("Add a wine");
            Console.WriteLine(" Write the name:");
            string name = Console.ReadLine();

            Console.WriteLine(" Write the brand ID");
            int brandID = int.Parse(Console.ReadLine());

            Wine wine = new Wine(name, brandID);
            wineDb.Add(wine);
        }
    }
}
