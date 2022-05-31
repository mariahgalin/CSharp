using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Wine> wine = new List<Wine>()
            {
                new Wine()
                {
                    Name="Viñedo Chadwick", Country="Chile"
                },
                new Wine()
                {
                    Name="Finca Las Moras", Country= "Argentina"
                },
                 new Wine()
                {
                    Name="Quinta Monasterio", Country="México"
                }
            };

            foreach (var w in wine)
                Console.WriteLine(w);

            Console.WriteLine("------------------------------------------");

            //select
            var wineName = from w in wine
                           select new
                           {
                               Name = w.Name,
                               Letters = w.Name.Length,
                               Fixed = 1
                           };
            foreach (var wn in wineName)
                Console.WriteLine($"{wn.Name} {wn.Letters} {wn.Fixed}");

            Console.WriteLine("------------------------------------------");

            var getWineName = from w in wineName
                           select new
                           {
                               Name = w.Name
                           };

            foreach (var gwn in getWineName)
                Console.WriteLine($"{gwn.Name}");

            Console.WriteLine("------------------------------------------");

            var wineMéxico = from w in wine
                              where w.Country == "México"
                              || w.Country == "Argentina"
                             select w;
            
            foreach(var w in wineMéxico)
                Console.WriteLine(w);

            Console.WriteLine("------------------------------------------");

            var orderedWine = from w in wine
                              orderby w.Country descending
                              select w;

            foreach (var ow in orderedWine)
            Console.WriteLine(ow);

     Console.WriteLine("------------------------------------------");

            Console.ReadKey();
        }
    }

    class Wine
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Country: {Country}";
        }
    }
}
