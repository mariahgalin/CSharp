using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Timb", 56),
                new Shark("Jaws", 60)
            };

            IFish[] fishs = new IFish[]
            {
                new Siren(100),
                new Shark("Timb", 56)
            };

            ShowFish(sharks);
            ShowAnimal(sharks);
            ShowFish(fishs);

            Console.ReadLine();
        }

        public static void ShowAnimal(IAnimal[] animals)
        {
            Console.WriteLine("  -- Shows the animals --");

            int i = 0;
            while (i < animals.Length)
            {
                Console.WriteLine(animals[i].Name);
                i++;
            }
        }

        public static void ShowFish(IFish[] fishs)
        {
            Console.WriteLine("  -- Shows the fishs --");

            int i = 0;
            while (i < fishs.Length)
            {
                Console.WriteLine(fishs[i].Swim());
                i++;
            }
        }
    }

    public class Siren : IFish
    {
        public int Speed { get; set; } 

        public Siren(int speed)
        {
            this.Speed = speed;
        }

        public string Swim()
        {
            return $"The siren swims at {Speed} km/h";
        }
    }

    public class Shark: IAnimal, IFish
    {
        public string Name { get; set; }

        public int Speed { get; set; }

        public Shark(string name, int speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public string Swim()
        {
            return $"{Name} swim {Speed} km/h";
        }
    }

   public interface IAnimal
    {
         string Name { get; set; }
    }

    public interface IFish
    {
        int Speed { get; set; }

        string Swim();
    }
}
