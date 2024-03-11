namespace LuckyNumber {
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the lucky number!");

            Random numberGenerator = new Random();

            int realNumber = numberGenerator.Next(1, 8); // generate number between 1 - 7
            Console.WriteLine(realNumber);

            Console.ReadLine();
        }
    }
}