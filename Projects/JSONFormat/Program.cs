using System;

namespace JSONFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Wine myWine = new Wine()
            {
                Name = "Conserva Real",
                Brand = "Torres"
            };

            string json = "{\"Name\": \"Conserva Real\", \"Brand\": \"Torres\"}";
            

            Wine[] Wines = new Wine[]
            {
                new Wine()
                {
                    Name = "Conserva Real",
                    Brand = "Torres"
                },
                new Wine()
                {
                    Name = "Claro de Luna",
                    Brand = "Cabernete"
                }
            };

            string json2 = "[" +
                "{\"Name\": \"Conserva Real\", \"Brand\": \"Torres\"}" +
                "{\"Name\": \"Claro de Luna\", \"Brand\": \"Cabernete\"}" +
                "]";
            
        }
    }

    public class Wine
    {
        public string Name { get; set; }

        public string Brand { get; set; }
    }
}
