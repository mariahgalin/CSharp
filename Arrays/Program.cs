using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friend = new string[5];

            friend[0] = "Marie";
            Console.WriteLine(friend[0]);

            string[] michis = new string[5]
            {
                "Bernardino",
                "Gaston",
                "Dante",
                "Tommas",
                null
            };
            

            michis[4] = "Romeo";

            Console.WriteLine(michis[4]);


            int index = 0;

            while (index < michis.Length) 
            {
                Console.WriteLine(michis[index]);
                index++;
            }
            Console.ReadKey();
        }
    }
}
