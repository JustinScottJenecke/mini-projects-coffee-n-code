using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    { 
        public Calculator() {
        }

        public static string[] GetUserInput() {

            string[] userInput = new string[3];

            Console.Write("Please enter your first number: ");
            userInput[0] = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Please enter your second number: ");
            userInput[1] = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Please the operation you would like to perform:");
            userInput[2] = Console.ReadLine();

            return userInput;
        }

        public static int Addition() {
            return 0;
        }
        public static int Subtraction()
        {
            return 0;
        }
        public static int Mutiplication()
        {
            return 0;
        }
        public static int Division()
        {
            return 0;
        }
        public static int Modulo() {
            return 0;
        }
    }
}
