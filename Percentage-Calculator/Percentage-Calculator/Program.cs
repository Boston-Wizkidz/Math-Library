using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percentage_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal totalValue = Convert.ToDecimal(args[0]);
            Decimal percentage = Convert.ToDecimal(args[1]);
            Decimal result = 0;
            result = (percentage * totalValue) / 100;
            Console.WriteLine(percentage + "percentage of " + totalValue + " is = $" + result);
            Console.ReadLine();


        }
    }
}
