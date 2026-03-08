using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> items = new List<string>();
        string? input;

        while (true)
        {
            Console.Write("Enter an item (or 'done' to finish): ");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "done")
                break;

            items.Add(input);
        }

        Console.WriteLine("\nYour items:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
