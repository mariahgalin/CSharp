using System;
using System.Text.Json;

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

            //string json = "{\"Name\": \"Conserva Real\", \"Brand\": \"Torres\"}";

            //Serialize
            string json = JsonSerializer.Serialize(myWine);

            //Deserialize
            Wine wine = JsonSerializer.Deserialize<Wine>(json);

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

            //string json2 = "[" +
            //    "{\"Name\": \"Conserva Real\", \"Brand\": \"Torres\"}" +
            //    "{\"Name\": \"Claro de Luna\", \"Brand\": \"Cabernete\"}" +
            //    "]";
            
            //Serialize
            string json2 = JsonSerializer.Serialize(Wines);

            //Deserialize
            Wine[] wine2 = JsonSerializer.Deserialize<Wine[]>(json2);
        }
    }

    public class Wine
    {
        public string Name { get; set; }

        public string Brand { get; set; }
    }
}
