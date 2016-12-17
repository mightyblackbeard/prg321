using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_TaxCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse( args[0] );
            double rate = double.Parse( args[1] );
            double res = (1 + rate) * price;
            Console.WriteLine(res);
        }
    }
}
