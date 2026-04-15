using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // EXCEEDING REQUIREMENTS:
        // - Level system based on score
        // - Bonus messages for completed goals
        // - Motivational titles (Amapiano Master 😄)

        List<Goal> goals = new List<Goal>();
        int score = 0;

        while (true)
        {
            Console.WriteLine($"\n🔥 Score: {score}");

            if (score >= 1000)
            {
                Console.WriteLine("🎧 Level Up! You are now an Amapiano Master!");
            }

            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            // CREATE GOAL
            if (choice == "1")
            {
                Console.WriteLine("1. Simple  2. Eternal  3. Checklist");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    goals.Add(new SimpleGoal(name, desc, points));
                }
                else if (type == "2")
                {
                    goals.Add(new EternalGoal(name, desc, points));
                }
                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }

            // RECORD EVENT
            else if (choice == "2")
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i}. {goals[i].GetStatus()}");
                }

                Console.Write("Select goal: ");
                int index = int.Parse(Console.ReadLine());

                score += goals[index].RecordEvent();
            }

            // SHOW GOALS
            else if (choice == "3")
            {
                foreach (Goal g in goals)
                {
                    Console.WriteLine(g.GetStatus());
                }
            }

            // SAVE
            else if (choice == "4")
            {
                File.WriteAllText("goals.txt", score + "\n");

                foreach (Goal g in goals)
                {
                    File.AppendAllText("goals.txt", g.SaveData() + "\n");
                }

                Console.WriteLine("✅ Saved!");
            }

            // LOAD
            else if (choice == "5")
            {
                if (File.Exists("goals.txt"))
                {
                    string[] lines = File.ReadAllLines("goals.txt");

                    score = int.Parse(lines[0]);
                    goals.Clear();

                    foreach (string line in lines.Skip(1))
                    {
                        string[] parts = line.Split("|");

                        if (parts[0] == "Simple")
                        {
                            goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                        }
                        else if (parts[0] == "Eternal")
                        {
                            goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        }
                        else if (parts[0] == "Checklist")
                        {
                            goals.Add(new ChecklistGoal(
                                parts[1],
                                parts[2],
                                int.Parse(parts[3]),
                                int.Parse(parts[5]),
                                int.Parse(parts[6])
                            ));
                        }
                    }

                    Console.WriteLine("✅ Loaded!");
                }
                else
                {
                    Console.WriteLine("No save file found.");
                }
            }

            // QUIT
            else if (choice == "6")
            {
                break;
            }
        }
    }
}
