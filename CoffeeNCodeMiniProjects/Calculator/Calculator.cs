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
        private static string operatorInputMenu = "Please select the operation you would like to perform: \n" +
                "1) \t + \t addition" +
                "2) \t - \t subtraction" +
                "3) \t * \t multiplication" +
                "4) \t / \t division" +
                "5) \t % \t difference";

        public Calculator() {
        }

        public static string ProcessOperatorInput() {

            Console.WriteLine(operatorInputMenu);
            string input = Console.ReadLine();
            
/*            switch(input) {
                case '+' || "plus" || '1':
                    Console.WriteLine("Hi");
            }*/
            
            return "";
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
