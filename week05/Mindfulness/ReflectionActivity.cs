using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone.",
        "Think of a time you did something difficult.",
        "Think of a time you helped someone."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "How can you apply this again?"
    };

    private List<string> _usedQuestions = new List<string>();

    public ReflectionActivity()
        : base("Reflection", "Reflect on times you showed strength.") { }

    public void Run()
    {
        Start();

        Random rand = new Random();

        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("Reflect on this...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (_usedQuestions.Count == _questions.Count)
                _usedQuestions.Clear();

            string question;
            do
            {
                question = _questions[rand.Next(_questions.Count)];
            } while (_usedQuestions.Contains(question));

            _usedQuestions.Add(question);

            Console.WriteLine("\n" + question);
            ShowSpinner(4);
        }

        End();
    }
}
