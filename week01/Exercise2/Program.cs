using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string UserGrade = Console.ReadLine();
        int grade = int.Parse(UserGrade);

        // Determine the letter grade
        string letter = "";

        if (grade >= 90)
        {
            if (grade >= 93)
            {
                letter = "A";
            }
            else
            {
                letter = "A-";
            }
        }
        else if (grade >= 80)
        {
            if (grade >= 87)
            {
                letter = "B+";
            }
            else if (grade >= 83)
            {
                letter = "B";
            }
            else
            {
                letter = "B-";
            }
        }
        else if (grade >= 70)
        {
            if (grade >= 77)
            {
                letter = "C+";
            }
            else if (grade >= 73)
            {
                letter = "C";
            }
            else
            {
                letter = "C-";
            }
        }
        else if (grade >= 60)
        {
            if (grade >= 67)
            {
                letter = "D+";
            }
            else if (grade >= 63)
            {
                letter = "D";
            }
            else
            {
                letter = "D-";
            }
        }
        else
        {
            letter = "F";
        }

        // Display a message based on pass/fail
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations!");
            Console.WriteLine($"Your letter grade is {letter}.");
            Console.WriteLine("You have passed the course.");
        }
        else
        {
            Console.WriteLine($"Unfortunately, Your letter grade is {letter}.");
            Console.WriteLine("You have not passed the course.");
            Console.WriteLine("Better luck next time!");
        }
    }
}