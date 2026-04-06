using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    // Inititating a constructor below for the prompt question following.
    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can."
        )
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // The Run method below was initiated to display the start and end message with a prompt count of the time taken in response to conclude each prompted question
    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int count = 0;

        // A while loop below calculate the number of activities time taken for each one embarked upon before the endtime of the total activity.
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"\nYou listed {count} Items!");

        DisplayEndingMessage();

    }

}
