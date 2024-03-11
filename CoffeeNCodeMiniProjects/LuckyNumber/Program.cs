namespace LuckyNumber {
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the lucky number!");

            Random numberGenerator = new Random();
            int totalGuesses = 0;

            int realNumber = numberGenerator.Next(1, 101); // generate number between 1 - 7
            // Console.WriteLine(realNumber);

            Console.WriteLine("Please guess a number between 1 and 100");
            Console.Write("Guess: ");
            int guess = Int32.Parse(Console.ReadLine());
            totalGuesses++;

            while (guess != realNumber) {

                Console.WriteLine($"Unlucky, you guessed wrong, try something {(guess > realNumber ? "smaller" : "bigger")}");
                Console.Write("Guess: ");
                guess = Int32.Parse(Console.ReadLine());
                totalGuesses++;
            }

            Console.WriteLine();
            Console.WriteLine("Congrats, you are lucky! The Lucky Number was:" + realNumber);
            Console.WriteLine("Total attempts: " + totalGuesses);
        }
    }
}