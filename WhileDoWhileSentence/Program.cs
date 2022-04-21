using System;

namespace WhileDoWhileSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine("Iteration of X " + x);
                // x = x + 1;
                x++;
            }


            int y = 0;
            while (y < 50)
            {
                if (y > 30)
                    break;

                Console.WriteLine("Iteration of Y " + y);
                y++;
            }

            bool run = false;
            do
            {
                Show();

            } while (run);

            Console.ReadKey();
        }

        static void Show()
        {
            Console.WriteLine("Just for once");
        }
    }
}
