using System;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Using complete path, it is important using @ before the path
                string content = File.ReadAllText("test.txt");
                Console.WriteLine(content);

                string content2 = File.ReadAllText("test2.txt");
                Console.WriteLine(content);

                throw new Exception("Something weird happend");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("The file does not exist");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This is executing anyway");
            }


            Console.ReadKey();
        }
    }
}
