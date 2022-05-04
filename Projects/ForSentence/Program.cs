using System;

namespace ForSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] michis = new string[5]
          {
                "Johnny",
                "Bernardino",
                "Gaston",
                "Dante",
                "Romeo"
          };

            bool run = true;

            for (int i = 0; i < michis.Length && run; i++)
            {
                Console.WriteLine(michis[i]);
            }

            Console.ReadKey();
        }
    }
}
