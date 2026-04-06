using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // Intiating a Constructor with a base to prompt the following questions
    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity will help you reflect on times in your life when you have shown strength and resilience."

        )
    {
        // The prompts
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        // The questions
        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different that other times?",
            "What did you learn about yourself through this experience?",
        };
    } 

    // initiating a Run method to be called in the program file
    public void Run()   
    {
        // This class above calls the method below to display the starting message with the prompts below it .
        DisplayStartingMessage();

        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("\nWhen you have something in mind, press Enter");
        Console.ReadLine();

        Console.WriteLine("Now ponder the following questions:");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // A while loop that keeps time once it is less than the time expected to end.
        while (DateTime.Now < endTime)
        {
            // code below ensures random question from the list of question from the list above
            string question = _questions[random.Next(_questions.Count)];

            // code below displays the question while the spinner is activated awaiting the user's answer or duration for exercise.
            Console.WriteLine($"\n> {question}");
            ShowSpinner(5);
        }

        // This calls the method below that displays the ending message well done!!
        DisplayEndingMessage();

    }
}