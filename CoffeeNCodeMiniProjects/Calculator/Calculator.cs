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
        private readonly static string operatorInputMenu = "Please select the operation you would like to perform: \n" +
                "\t 1) \t + \t addition \n" +
                "\t 2) \t - \t subtraction\n" +
                "\t 3) \t * \t multiplication\n" +
                "\t 4) \t / \t division\n" +
                "\t 5) \t % \t difference\n";

        public Calculator() {
        }

        /// <summary>
        ///     Function which prints a menu of different operator choices to the console, captures the user's input from the console,
        ///     and processes the user's choice into a character that is usable in a mathematical equation, and returns said character.
        /// </summary>
        /// <returns type="string">
        ///     string output - an operator symbol with the datatype of string
        /// </returns>
        public static string ProcessOperatorInput()
        {
            Console.WriteLine(operatorInputMenu);
            string input = Console.ReadLine();

            string output;

            switch(input.ToLower()) {
                case "+":
                case "addition":
                case "1":
                    output = "+";
                    break;
                case "-":
                case "subraction":
                case "2":
                    output = "-";
                    break;
                case "*":
                case "multiplication":
                case "3":
                    output = "*";
                    break;
                case "/":
                case "division":
                case "4":
                    output = "/";
                    break;
                case "%":
                case "difference":
                case "5":
                    output = "%";
                    break;
                default:
                    Console.WriteLine("error: please select a valid option from the menu");
                    output = "null";
                    break;
            }
            return output;
        }

        /// <summary>
        ///     Function which grabs user input from the console for two Operands, and one Operator, and 
        ///     returns a mathematical expression in the form of an array
        /// </summary>
        /// <returns>
        ///     Array<string> - [0]: first operand - [1]: operator - [2]: second operand
        /// </returns>
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
