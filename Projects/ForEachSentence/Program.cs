using System;
using System.Collections.Generic;

namespace ForEachSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para agregar namespace necesarios
            //Control + .

            var numbers = new List<int>()
            {
                6,3,886,432,0
            };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //List<People> students = new List<People>()
            var students = new List<People>()
            {
                new People() {Name = "Maria", Country="Mexico"},
                new People() {Name = "Amanda", Country="Brazil"}
            };

            Show(students);

            Console.ReadKey();

        }

        static void Show(List<People> students)
        {
            Console.WriteLine("--- People ---");

            foreach(var s in students)
            {
                Console.WriteLine($"Nombre: {s.Name}, País: {s.Country}");
            }
        }
    }

    class People
    {
        public string Name { get; set; }

        public string Country { get; set; }
    }
}
