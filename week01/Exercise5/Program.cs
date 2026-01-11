using System;

class Program
{
    static void Main(string[] args)
    {
        // Function to display welcome message
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Function to prompt the user for their name and return it
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // Function to collect the user favorite number
        static int PromtUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // Function to prompt the user for square number, calculate it and return the result
        // Accepts an integer as a parameter and returns that number squared (as an integer)

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        // Main program flow
        DisplayWelcomeMessage();
        string name = PromptUserName();
        int favNumber = PromtUserNumber();
        int squared = SquareNumber(favNumber);

        Console.WriteLine($"{name}, the square of your number is {squared}");




    }
}