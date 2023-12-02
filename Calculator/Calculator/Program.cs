﻿class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN;


        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num2 - num1;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":

                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;

            default:
                break;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("--------------------------");

        while (!endApp)
        {

            string numInput1 = "";
            string numInput2 = "";
            double result = 0;


            Console.WriteLine("Type a number, and then press Enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.WriteLine("This is not a valid input. Please enter an integer: ");
                numInput1 = Console.ReadLine();
            }


            Console.WriteLine("Type another number, and then press Enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.WriteLine("This is not a valid input. Please enter an integer: ");
                numInput2 = Console.ReadLine();
            }


            Console.WriteLine("Choose an operator from the following list: ");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("Your option?: ");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error. \n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the maths.\n");
            }

            Console.WriteLine("------------------------");


            Console.WriteLine("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}