using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale mySale = new Sale(10, DateTime.Now);

            //mySale.Total = -1359893;
            mySale.Total = 20;
            Console.WriteLine(mySale.Total);

            Console.ReadKey();
        }
    }

    class Sale
    {
        private int total;
        private DateTime date;

        //Accessors
        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
        }

        public int Total
        {
            get
            {
                return total;
                //return total.ToString("#.00");
            }
            set
            {
                if (value < 0)
                    value = 0;
                total = value;
            }
        }
        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

    }
}
