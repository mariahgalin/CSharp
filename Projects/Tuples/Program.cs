using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (int id, string name) product = (1, "Black cat");

            Console.WriteLine($"{product.id} {product.name}");

            product.name = "Merlot wine";

            var person = (3, "Maria");

            Console.WriteLine($"{person.Item1} {person.Item2}");

            var people = new[]
            {
                (1, "Marie"),
                (2, "Amanda"),
                (3, "Lizzete")
            };

            foreach (var p in people)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }

            (int id, string name)[] people2 = new[]
            {
                (1, "Marie"),
                (2, "Amanda"),
                (3, "Lizzete")
            };

            foreach (var p in people2)
            {
                Console.WriteLine($"{p.id} {p.name}");
            }

            var cityInfo = getLocationAgs();
            Console.WriteLine($"lat:{cityInfo.lat} long:{cityInfo.lng} name:{cityInfo.name}");

            var (_, lng, _) = getLocationAgs();
            Console.WriteLine("Getting just lng" + lng);

            Console.ReadKey();
        }

        public static (float lat, float lng, string name) getLocationAgs()
        {
            float lat = 16789.765f;
            float lng = -23566.85043f;
            string name = "Ags";

            return (lat, lng, name);
        }
    }
}
