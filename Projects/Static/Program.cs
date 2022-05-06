using System;

namespace Static
{
    class Program
    {
        //Static is used to have the membership of the data type class
        //It could be to these levels: property, method and class.
        static void Main(string[] args)
        {
            People romeo = new People()
            {
                Name = "Romeo",
                Age = 13
            };
            
            People dante = new People()
            {
                Name = "Dante",
                Age = 6
            };

            Console.WriteLine(People.GetCount());

            Console.ReadKey();
        }
    }

    public static class A
    {
        public static void Some()
        {
            Console.WriteLine("something");
        }
    }
    class People
    {
        public static int Count = 0; 
        public string Name { get; set; }

        public int Age { get;  set; }

        public People()
        {
            Count++;
        }

        public static string GetCount()
        {
            //return "This class have been used " + Count + " times";

            //Interpolation
            return $"This class have been used { Count } times";
        }
    }
}
