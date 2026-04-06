using System;

// EXCEEDING REQUIREMENTS:
// - Added Gratitude Activity
// - Prevented repeated questions in Reflection Activity
// - Improved spinner animation
// - Better user experience with prompts

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Quit");

            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                new BreathingActivity().Run();
            else if (choice == "2")
                new ReflectionActivity().Run();
            else if (choice == "3")
                new ListingActivity().Run();
            else if (choice == "4")
                new GratitudeActivity().Run();
            else if (choice == "5")
                break;

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
