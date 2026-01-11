using System;

class Program
{
    static void Main(string[] args)
    {

        string session = "yes";
        do 
        {
            // Generate a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 101);

            int GuessCount = 0;
            // Prompt the user for their guess
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);

            // Add guess count
            GuessCount += 1;

            // Run guess loop
            while (guess != magic)
            {
                // Compare the guess to the magic number and provide feedback
                if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }

                // Prompt the user for another guess
                Console.Write("What is your guess? ");
                guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                GuessCount += 1;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {GuessCount} guesses to find the number.");
            Console.Write("Do you want to play again? (yes/no) ");
            session = Console.ReadLine().ToLower();

        } while (session == "yes");
    }
}