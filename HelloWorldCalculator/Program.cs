using System;

namespace HelloWorldCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a, b = 0;

            Console.WriteLine("Welcome To Hello World Calculator " + args[0] + " \n");
            Console.WriteLine("Type a number, and then press Enter");

            a = Convert.ToInt32(Console.ReadLine());
        }
    }
}