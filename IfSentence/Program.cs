using System;

namespace IfSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areYouHungry = true;
            bool youHaveMoney = true;

            if (areYouHungry && youHaveMoney && IsOpenRestaurant("Carls Jr", 12))
            {
                Console.WriteLine("Eat!");
            }
            else
            {
                Console.WriteLine("Dont eat :( ");
            }

            Console.ReadKey();
           
        }
        static bool IsOpenRestaurant(string name, int hour = 0)
        {
            if (name == "Carls Jr" && hour > 8 && hour <23)
            {
                return true;
            }
            else if (name == "Restaurant 24 hrs")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
