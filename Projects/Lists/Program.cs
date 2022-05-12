using System;
using System.Collections.Generic;


namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(4);
            numbers.Add(5);

            Console.WriteLine(numbers.Count);

            List<int> numbers2 = new List<int>()
            {
                14,8,9,2
            };
            Console.WriteLine(numbers2.Count);

            numbers2.Clear();
            Console.WriteLine(numbers2.Count);

            List<string> countries = new List<string>()
            {
                "Mexico", "Colombia", "Peru"
            };
            Console.WriteLine(countries.Count);

            Console.ReadKey();
        }
    }
}
