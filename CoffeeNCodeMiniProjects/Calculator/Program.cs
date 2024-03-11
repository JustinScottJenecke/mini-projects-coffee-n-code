using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Returning data test
            string[] equationArray = Calculator.GetUserInput();

            for (int i = 0; i < equationArray.Length; i++)
            {
                Console.WriteLine(equationArray[i]);
            }

            // Get operator and user input checks
            Console.WriteLine(Calculator.ProcessOperatorInput());
        }
    }
}