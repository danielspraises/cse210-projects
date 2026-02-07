using System;

// Exceeding Requirements:
// Added user personalization by collecting the user's name and using it throughout
// the program to provide a more engaging and mindful experience.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program 🌿");
        Console.WriteLine();
        Console.Write("Before we begin, please enter your name: ");
        string userName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Hello, {userName}! We're glad you're here.");
        Console.WriteLine("Take a deep breath and choose an activity when you're ready...");
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();

        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Menu");
            Console.WriteLine();
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine($"Alright {userName}, let's begin a breathing exercise...");
                Console.ReadLine();
                new BreathingActivity().Run();
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine($"{userName}, take a moment to prepare for reflection...");
                Console.ReadLine();
                new ReflectionActivity().Run();
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                Console.WriteLine($"{userName}, get ready to focus on the good things in your life...");
                Console.ReadLine();
                new ListingActivity().Run();
            }
        }

        Console.Clear();
        Console.WriteLine($"Thank you for taking time to be mindful today, {userName}.");
        Console.WriteLine("Remember: even a few quiet moments can make a difference.");
        Console.WriteLine("Take care and have a wonderful day!");
        Console.WriteLine();
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}
