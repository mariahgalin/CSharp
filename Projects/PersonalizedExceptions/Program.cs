using System;

namespace PersonalizedExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Wine wine = new Wine()
                {
                    Name = "Cabernet Sauvignon",
                   // Brand = "Gato Negro"
                };

                Console.WriteLine(wine);
            }
            catch (InvalidWineException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }

    public class InvalidWineException : Exception
    {
        public InvalidWineException(): base("The wine does not have name or brand, so it is invalid.")
        {

        }
    }
    public class Wine
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            if (Name == null || Brand == null)
                throw new InvalidWineException();

            //return base.ToString();
            return $"Wine: {Name}, Brand: {Brand}";
        }
    }
}
