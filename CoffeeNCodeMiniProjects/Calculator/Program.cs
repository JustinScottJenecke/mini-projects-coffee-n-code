// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to my console calculator \n");

Console.Write("Please enter your first number: ");
int num1Input = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine();

Console.Write("Please enter your second number: ");
int num2Input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n" + num1Input + " | " + num2Input);