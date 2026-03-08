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

        int squared = Square(number);
        Console.WriteLine($"The square of {number} is {squared}");
    }

    static int Square(int x)
    {
        return x * x;
    }
}
