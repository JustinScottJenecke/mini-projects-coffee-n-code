namespace LuckyNumber {
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the lucky number!");

            Random numberGenerator = new Random();

            int realNumber = numberGenerator.Next(1, 8); // generate number between 1 - 7
            Console.WriteLine(realNumber);

            Console.WriteLine("Please guess a number between 1 and 7");
            Console.Write("Guess: ");
            int guess = Int32.Parse(Console.ReadLine());

            while (guess != realNumber) {
                Console.WriteLine("Unlucky, you guessed wrong, try again.");
                guess = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Congrats, you are lucky");
        }
    }
}