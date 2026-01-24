using System;

class Program
// Additional creativity
// The program hides only unhidden words, ensuring that it doesn't attempt to hide words that are already hidden.



{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);

        string text = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him shall not perish but have everlasting life";

        Scripture scripture = new Scripture(reference, text);

        string input = "";

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }

}