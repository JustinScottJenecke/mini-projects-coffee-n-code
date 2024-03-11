using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Calculator!");

            // Display console prompts, save inputs to array, and return array
            string[] equation = Calculator.GetUserInput();

            // Destructure array into seperate variables, resolve expression, and return answer
            int answer = Calculator.CalculateAnswer(equation);

            Console.WriteLine($"The result of {equation[1]} {equation[0]} {equation[2]} is {answer}");
        }
    }
}