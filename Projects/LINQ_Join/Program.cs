using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var wine = new List<Wine>()
            {
                new Wine()
                {
                    Name="Cirsion", Country="España"
                },
                new Wine()
                {
                    Name="Quinta Monasterio", Country="México"
                },
                new Wine()
                {
                    Name="Mayra", Country="Turquía"
                }
            };

            var countries = new List<Country>()
            {
                new Country()
                {
                    Name="Mexico", Continent="America"
                },
                new Country()
                {
                    Name="España", Continent="Europa"
                },
                new Country()
                {
                    Name="Turquia", Continent="Asia"
                }
            };

            var wineWithContinent = from w in wine
                                    join country in countries
                                    on w.Country equals country.Name
                                    select new
                                    {
                                        Name = w.Name,
                                        Country = w.Country,
                                        Continent = country.Continent
                                    };

            foreach(var w in wineWithContinent)
            {
                Console.WriteLine($"{w.Name} {w.Country} {w.Continent}");
            }

            Console.ReadKey();
        }
    }

    class Wine
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }

    class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
    }
}
