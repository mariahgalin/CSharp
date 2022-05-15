using System;

namespace Anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            var maria = new
            {
                Name = "Maria",
                Country = "Aguascalientes"
            };

            Console.WriteLine($"{maria.Name} {maria.Country}");

            var beers = new[] 
            {
                new { Name = "Red", Brand = "Delirium" }, 
                new { Name = "London Porter", Brand = "Fullers"}
            };

            foreach (var b in beers)
            {
                Console.WriteLine($"Beer {b.Name} Brand {b.Brand}");
            }
            Console.ReadKey();
        }
    }
}
