using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 6;

            Show();

            Sum(3,4);

            int m = Mul(3,2);

            Console.WriteLine(m);

            Console.ReadKey();
        }
        
        static void Show()
        {
            Console.WriteLine("This is a test line");
        }

        static void Sum(int num1, int num2)
        {
            int num3 = num1 + num2;
            //Best practice to write Console.Writeline faster
            //Type 'cw' continue with double tab, and ta-da!
            Console.WriteLine(num3);
        }

        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
