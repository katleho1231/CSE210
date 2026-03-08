using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to count up to: ");
        string? input = Console.ReadLine();
        int max;

        if (!int.TryParse(input, out max))
        {
            Console.WriteLine("Invalid input! Exiting...");
            return;
        }

        for (int i = 1; i <= max; i++)
        {
            Console.WriteLine(i);
        }
    }
}
