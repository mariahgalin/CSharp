using System;
using System.Collections.Generic;

namespace ListCommonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                3,5,8,2
            };
            Show(numbers);

            //Insert
            numbers.Insert(0,9);

            Show(numbers);

            //Contains
            if (numbers.Contains(33))
            {
                Console.WriteLine("\n Exist");
            }
            else
            {
                Console.WriteLine("\n Does not exist");
            }

            //Index of
            int pos = numbers.IndexOf(2);
            Console.WriteLine(pos);

            pos = numbers.IndexOf(6);
            Console.WriteLine(pos);

            //Sort
            numbers.Sort();
            Show(numbers);

            string name = "María";
            //Se aplica hacia el mismo objeto, porque string es inmutable
            name = name.ToUpper();
            Console.WriteLine(name);

            //Add range
            var numbers2 = new List<int>(){ 299, 399, 199 };

            numbers.AddRange(numbers2);
            Show(numbers);
            Console.ReadKey();
        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("  --- Numbers --- ");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
