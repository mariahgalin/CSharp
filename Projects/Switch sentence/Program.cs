using System;

namespace Switch_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 5;

            switch (op)
            {
                case 1:
                    Console.WriteLine("You have been selected case 1");
                    break;
                case 2:
                    Console.WriteLine("You have been selected case 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("You have been selected cases 3 & 4");
                    break;
                //case < 0:
                //    Console.WriteLine("Out of range");
                //    break;
                //case > 4 and 10;
                //    Console.WriteLine("You have been selected between 4 and 10");
                //    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
                    
            }

            Console.ReadKey();
        }
    }
}
