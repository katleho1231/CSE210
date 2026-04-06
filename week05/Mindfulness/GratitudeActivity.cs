using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base("Gratitude", "Focus on things you are grateful for.") { }

    public void Run()
    {
        Start();

        Console.WriteLine("\nThink of 3 things you are grateful for...");

        ShowCountdown(5);

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"Thing {i}: ");
            Console.ReadLine();
        }

        Console.WriteLine("\nGratitude improves happiness!");
        ShowSpinner(3);

        End();
    }
}
