using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();
        int number;

        if (!int.TryParse(input, out number))
        {
            Console.WriteLine("Invalid input! Exiting...");
            return;
        }

        if (number > 0)
        {
            Console.WriteLine("Positive number");
        }
        else if (number < 0)
        {
            Console.WriteLine("Negative number");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}
