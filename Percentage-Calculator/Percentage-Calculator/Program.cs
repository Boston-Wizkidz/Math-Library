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



            //Double value = Convert.ToDouble(args[0]);
            // getCube(value);

            //Double value = Convert.ToDouble(args[0]);
            //Double divisorvalue = Convert.ToDouble(args[1]);
            //getdivision(value, divisorvalue);

            //Double factorvalue = Convert.ToDouble(args[0]);
            //Double value = Convert.ToDouble(args[1]);
            //getmultiplication(value, factorvalue);

            //Double count = Convert.ToDouble(args[0]);
            //Double Tablestart = Convert.ToDouble(args[1]);
            //gettables(count, Tablestart);

            //Double subtractionvalue = Convert.ToDouble(args[0]);
            //Double value1 = Convert.ToDouble(args[1]);
            //getdifference(subtractionvalue, value1);

            Double value = Convert.ToDouble(args[0]);
            Double value1 = Convert.ToDouble(args[1]);
            getAddition(value, value1);
        }


        //static void getPercentage(Decimal totalValue, Decimal percentage)
        // {
        // Decimal result = 0;
        //result = (percentage * totalValue) / 100;
        //Console.WriteLine(percentage + "percentage of " + totalValue + " is = $" + result);
        // Console.ReadLine();

        // }
        // static void getSquareRoot(Double squareValue)
        //{
        //Double result = 0;
        // result = Math.Sqrt(squareValue);
        //Console.WriteLine(squareValue + " Squre root is = " + result);
        // Console.ReadLine();

        //}
        // static void getCube(Double value)
        //{
        // Double result = 0;
        // result = value * value * value;
        // Console.WriteLine(" You entered : " + value + " and the cube of " + value + " is =" + result);
        //Console.ReadLine();

        //}
        // static void getdivision(Double value, Double divisorvalue)
        // {
        //Double result = 0;
        // result = (value / divisorvalue);
        // Console.WriteLine("You questioned me what is  " + value + " divided by " + divisorvalue + " and the answer is = " + result);
        //Console.ReadLine();
        //}

        // static void getmultiplication(Double value, Double factorvalue)
        //{
        // Double result = 0;
        //result = (factorvalue * value);
        // Console.WriteLine("You questioned me what is " + factorvalue + " multiplied by " + value + " and the answer is = " + result);
        //Console.ReadLine();
        //}


        //static void gettables(Double count, Double Tablestart)
        // {
        //Double Count = 0;
        //Double TablValue = Tablestart; 
        //while (count < 10)
        //{
        //Console.WriteLine(Tablestart + " X " + count + " = " + TablValue);
        //TablValue = TablValue + Tablestart;
        // count = count + 1;
        //}


        static void getdifference(Double subtractvalue, Double value1)
        {
            Double result = 0;
            result = (subtractvalue - value1);
            Console.WriteLine("You questioned me what is " + subtractvalue + " subtracted by " + value1 + " and the answer is = ");
            Console.ReadLine();

        }


        static void getAddition(Double value, Double value1)
        {
            Double result = 0;
            result = (value + value1);
            Console.WriteLine(value + " + " + value1 + " = " + result);
            Console.ReadLine();



        }


    }







}



