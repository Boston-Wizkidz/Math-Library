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
            //Decimal totalValue = Convert.ToDecimal(args[0]);
            //Decimal percentage = Convert.ToDecimal(args[1]);
            //getPercentage(totalValue, percentage);


            //Double squreValue = Convert.ToDouble(args[0]);
            //getSquareRoot(squreValue);



            Double value = Convert.ToDouble(args[0]);
            getCube(value);
        }


        //static void getPercentage(Decimal totalValue, Decimal percentage)
        //{
            //Decimal result = 0;
            //result = (percentage * totalValue) / 100;
            //Console.WriteLine(percentage + "percentage of " + totalValue + " is = $" + result);
            //Console.ReadLine();

        //}

        //static void getSquareRoot(Double squareValue)
        //{
            //Double result = 0;
            //result = Math.Sqrt(squareValue);
            //Console.WriteLine(squareValue + " Squre root is = " + result);
            //Console.ReadLine();

        //}

            
        static void getCube(Double value)
        {
            Double  result = 0;
            result = value * value * value;
            Console.WriteLine( value + " Cube is = " + result);
            Console.ReadLine();

        }
            




}




    }

