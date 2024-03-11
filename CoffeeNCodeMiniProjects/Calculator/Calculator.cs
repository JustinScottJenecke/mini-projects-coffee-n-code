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
            Console.Write("Input: ");
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

            // Ask user what operation they would like to perform
            userInput[0] = ProcessOperatorInput();
            Console.WriteLine();


            Console.Write("Please enter your first number: ");
            userInput[1] = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Please enter your second number: ");
            userInput[2] = Console.ReadLine();

            Console.WriteLine();

            return userInput;
        }

        public static int CalculateAnswer(string[] expressionArray) 
        {
            int answer = 0;

            int num1 = Int32.Parse( expressionArray[1] );
            int num2 = Int32.Parse( expressionArray[2] );
            string op = expressionArray[0];

            switch (op) {
                case "+":
                    answer = Addition(num1, num2);
                    break;
                case "-":
                    answer = Subtraction(num1, num2);
                    break;
                case "*":
                    answer = Multiplication(num1, num2);
                    break;
                case "/":
                    answer = Division(num1, num2);
                    break;
                case "%":
                    answer = Difference(num1, num2);
                    break;
            }
            return answer;
        }

        public static int Addition(int num1, int num2) {
            return num1 + num2;
        }
        public static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Difference(int num1, int num2) 
        {
            return num1 % num2;
        }
    }
}
