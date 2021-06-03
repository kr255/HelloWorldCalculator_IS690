using System;

namespace HelloWorldCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            {/*  //float a and b to store 2 numbers
            double i, j = 0;
            
            //Welcome Dialog
            Console.WriteLine("Welcome To Hello World Calculator " + args[0] + " \n");
            
            //prompt for the first number
            Console.WriteLine("Type the first number, and then press Enter");
            i = Convert.ToDouble(Console.ReadLine());
            
            //prompt for the second number
            Console.WriteLine("Type the second number, and then press Enter");
            j = Convert.ToDouble(Console.ReadLine());



            //options to choose from
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tw - Multiply");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");

            if (!(j.Equals(0))) {
                Console.WriteLine("\td - Divide");
            }
            Console.Write("What will be your option? ");

            switch (Console.ReadLine())
            {
                case "w":
                    Console.WriteLine($"Your result: {i} * {j} = " + (i * j));
                    break;
                case "a":
                    Console.WriteLine($"Your result: {i} + {j} = " + (i + j));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {i} - {j} = " + (i - j));
                    break;
                case "d":
                    if (!(j.Equals(0)))
                    {
                        Console.WriteLine($"Your result: {i} / {j} = " + (i / j));
                    }
                    else { Console.WriteLine($"Tired to divide by { j }, the second number cant be { j }"); }
                    break;

            }
            //close the application
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();*/
            }
            bool terminateApp = false;
            Console.WriteLine("Welcome To Hello World Calculator " + " \n");

            while (!terminateApp) {

                string i = "";
                string j = "";
                double result = 0;

                Console.WriteLine("Type the first number, and then press Enter");
                i = Console.ReadLine();
                double cleanI = 0;
                while (!double.TryParse(i, out cleanI)) {

                    Console.Write("This is not valid input. Please enter an integer value: ");
                    i = Console.ReadLine();
                }
                //prompt for the second number
                Console.WriteLine("Type the second number, and then press Enter");
                j = Console.ReadLine();
                double cleanJ = 0;
                while (!double.TryParse(j, out cleanJ))
                {

                    Console.Write("This is not valid input. Please enter an integer value: ");
                    j = Console.ReadLine();
                }
                //options to choose from
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\tw - Multiply");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                if (!(cleanJ.Equals(0)))
                {
                    Console.WriteLine("\td - Divide");
                }
                Console.Write("What will be your option? ");
                string op = Console.ReadLine();
                try
                {
                    result = Calculator.AllOperations(cleanI, cleanJ, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") terminateApp = true;

                
            }

            Console.WriteLine("Goodbye!\n"); // Friendly exit message?.
        }
    }
    class Calculator {

        public static double AllOperations(double i, double j, string notOperand) {

            double results = double.NaN;
            switch (notOperand)
            {
                case "w":
                    //Console.WriteLine($"Your result: {i} * {j} = " + (i * j));
                    results = (i * j);
                    break;
                case "a":
                    //Console.WriteLine($"Your result: {i} + {j} = " + (i + j));
                    results = (i + j);
                    break;
                case "s":
                    //Console.WriteLine($"Your result: {i} - {j} = " + (i - j));
                    results = (i - j);
                    break;
                case "d":
                    results = (i / j);
                    break;
                default:
                    break;

            }
            return results;
        }
    }
}