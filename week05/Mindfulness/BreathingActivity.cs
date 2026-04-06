using System;

public class BreathingActivity : Activity
{
    // declaring the BreathingActivity with a base with two parameters
    public BreathingActivity()
        : base(
            "Breathing",
             "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."   
        )
    {
        // No constructor module declared 
    }

    // Below is a Run method declared to display the starting/ending message for the BreathingActivity with datetime according to duration
    public void Run()
    {
        DisplayStartingMessage();

        DateTime StartTime = DateTime.Now;
        DateTime endTime = StartTime.AddSeconds(_duration);

        // A while loop below to prompt the user on when to breath in/out while it counts the number of seconds involved in the process.
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);

            Console.Write("\nBreathe out... ");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }        
}