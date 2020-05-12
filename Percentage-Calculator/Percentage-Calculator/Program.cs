using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;


namespace Percentage_Calculator
{
    public class Program
    {
        static AddSubstract addsub = new AddSubstract();
        static MultiplyDivide multdiv = new MultiplyDivide();
        public static void Main(string[] args)
        {
            
            if (args.Length > 0)
            {
                if (args[0] == "1")
                {
                    // int [] myArray = { 10, 20, 30, 40, 50 };
                    // Console.WriteLine(myArray[2]);
                    Decimal totalValue = Convert.ToDecimal(args[1]);
                    Decimal percentage = Convert.ToDecimal(args[2]);
                    getPercentage(totalValue, percentage);
                }

                if (args[0] == "2")
                {
                    Double squreValue = Convert.ToDouble(args[1]);
                    getSquareRoot(squreValue);
                }

                if (args[0] == "3")
                {
                    Double value = Convert.ToDouble(args[1]);
                    getCube(value);
                }


                if (args[0] == "4")
                {
                    Double value = Convert.ToDouble(args[1]);
                    Double divisorvalue = Convert.ToDouble(args[2]);
                    getdivision(value, divisorvalue);
                }

                if (args[0] == "5")
                {
                    Double value = Convert.ToDouble(args[1]);
                    Double factorvalue = Convert.ToDouble(args[2]);
                    getmultiplication(value, factorvalue);
                }


                if (args[0] == "6")
                {
                    Double count = Convert.ToDouble(args[1]);
                    Double Tablestart = Convert.ToDouble(args[2]);
                    gettables(count, Tablestart);
                }

                if (args[0] == "7")
                {
                    Double value = Convert.ToDouble(args[1]);
                    Double subtractionvalue = Convert.ToDouble(args[2]);
                    getdifference(value, subtractionvalue);
                }


                if (args[0] == "8")
                {
                    Double value = Convert.ToDouble(args[1]);
                    Double value1 = Convert.ToDouble(args[2]);
                    getAddition(value, value1);
                }


            }
            else
            {
                Console.WriteLine("Please Enter Values In Following Formatt: Operation Name Value1 Value2. \n");
                Console.WriteLine(" Below are the Operation Names: \n");
                Console.WriteLine(" Please Enter A Number by Your Choice:\n" +
                    " 1 = Percentage Calculator \n" + " 2 = Squareroot Calculator, \n" + " 3 = Cube Calculator \n" + " 4 = Division Calculator \n" +
                    " 5 = Multiplication Calculator \n" + " 6 = Tables Calculator \n" + " 7 = Subtraction Calculator \n" + " 8 = Addition Calculator \n");
                


            }
             
        }


        public static void getPercentage(Decimal totalValue, Decimal percentage)
        {
        Decimal result = 0;
        result = (percentage * totalValue) / 100;
        Console.WriteLine(percentage + "percentage of " + totalValue + " is = $" + result);
        Console.ReadLine();

        }
        public static void getSquareRoot(Double squareValue)
        {
        Double result = 0;
        result = Math.Sqrt(squareValue);
        Console.WriteLine(squareValue + " Squre root is = " + result);
        Console.ReadLine();

        }

        public static void getCube(Double value)
        {
        Double result = 0;
        result = value * value * value;
        Console.WriteLine(" You entered : " + value + " and the cube of " + value + " is =" + result);
        Console.ReadLine();

        }
        public static void getdivision(Double value, Double divisorvalue)
        {
        Double result = 0;
            //result = (value / divisorvalue);
            result = multdiv.Divide(value, divisorvalue);
            Console.WriteLine("You questioned me what is  " + value + " divided by " + divisorvalue + " and the answer is = " + result);
        Console.ReadLine();
        }

        public static void getmultiplication(Double value, Double factorvalue)
        {
        Double result = 0;
            //result = (factorvalue * value);
            result = multdiv.Multiply(value, factorvalue);
            Console.WriteLine("You questioned me what is " + factorvalue + " multiplied by " + value + " and the answer is = " + result);
        Console.ReadLine();
        }


        public static void gettables(Double count, Double Tablestart)
        {
            Double Count = 0;
            Double TablValue = Tablestart;
            while (count < 10)
            {
                Console.WriteLine(Tablestart + " X " + count + " = " + TablValue);
                TablValue = TablValue + Tablestart;
                count = count + 1;
            }

        }
        public static void getdifference(Double subtractvalue, Double value1)
        {
            Double result = 0;
            //result = (subtractvalue - value1);
            result = addsub.Subtract(subtractvalue, value1);
            Console.WriteLine("You questioned me what is " + subtractvalue + " subtracted by " + value1 + " and the answer is = " + result);
            Console.ReadLine();

        }


        public static void getAddition(Double value, Double value1)
        {
            Double result = 0;
            //result = (value + value1);
            result = addsub.Add(value, value1);
            Console.WriteLine(value + " + " + value1 + " = " + result);
            Console.ReadLine();



        }


    }







}



