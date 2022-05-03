using System;

namespace ClassesObjects
{
    /// <summary>
    ///PARADIGMA. Un estilo para programación con código. 
    ///Uno de los más usados: Orientado a objetos, que tiene clases y objetos. 
    ///    *Un objeto es la representación de una entidad, con sus respectivas funcionalidades. 
    ///    *La clase es la definicion o el molde de esos objetos
    ///    
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(100, DateTime.Now);

            //sale1.Show();
            Console.WriteLine(sale1.GetInfo());

            Console.ReadKey();
        }
    }

    class Sale
    {
        int total;
        DateTime date;
       

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string GetInfo()
        {
            return total + "  " + date.ToLongDateString();
        }
        public void Show()
        {
            Console.WriteLine("Testing line");
        }
    }
}
