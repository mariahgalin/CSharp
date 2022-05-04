using System;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine(b.Hi());

            Sale sale = new Sale(10);
            sale.Add(2);
            sale.Add(3);
            Console.WriteLine(sale.GetTotal());


            SaleWithTax saletax = new SaleWithTax(10, 1.16m);
            saletax.Add(2);
            saletax.Add(4);
            Console.WriteLine(saletax.GetTotal());

            Console.ReadKey();
        }
    }

    public class Sale
    {
        private decimal[] _amounts;
        private int _n;
        private int _end;

        public Sale(int n)
        {
            _amounts = new decimal[n];
            _n = n;
            _end = 0; 
        }

        public void Add(decimal amount)
        {
            if (_end < _n)
            {
                _amounts[_end] = amount;
                _end++;
            }

        }
        public virtual decimal GetTotal()
        {
            decimal result = 0;
            int i = 0;

            while (i < _amounts.Length)
            {
                result += _amounts[i];
                i++;
            }

            return result;
        }

    }

    public class SaleWithTax : Sale
    {
        private decimal _tax;
        public SaleWithTax(int n, decimal tax) : base(n)
        {
            _tax = tax;
        }

        public override decimal GetTotal()
        {
            //return base.GetTotal() * 1.16m; 
            return base.GetTotal() * _tax;
        }
    }

    public class A
    {
        //if it is protected, you can only run in children methods.
        //With virtual
        public virtual string Hi()
        {
            return "This is A";
        }
    }

    public class B : A
    {
        //With override before the type, you can replace the info in the parent method
        //With base you do reference with the parent
        public string Hi()
        {
            //return "This is B";
            return base.Hi() + "  | This is B";
        }
    }
}
