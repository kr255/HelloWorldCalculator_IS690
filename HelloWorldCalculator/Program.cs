using System;

namespace HelloWorldCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //float a and b to store 2 numbers
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
            Console.ReadKey();

        }
    }
}