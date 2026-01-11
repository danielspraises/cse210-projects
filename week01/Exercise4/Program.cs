using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers, type 0 when finished.\n");

        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Calculate the sum
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        // Display the sum
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the largest number
        int largest = int.MinValue;
        foreach (int n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

    }
}
