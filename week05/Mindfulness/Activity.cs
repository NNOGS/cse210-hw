using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    // leaving the variables protected below for the derived classes to access instead of private.
    protected string _name;
    protected string _description;
    protected int _duration;

    // initiating the constructor module below
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //returning a void DisplayStartingMessage method
    public void DisplayStartingMessage()
    {
        // The code below leaves the screen clean so the menu looks neat every time.
       Console.Clear(); 

        // Set a welcome message to the name of the activity 
       Console.WriteLine($"Welcome to the {_name} Activity.");

       // Describe the activity.
       Console.WriteLine(_description);

       //query how long in seconds the user would like for the session
       Console.WriteLine("How long, in seconds, would you like for your session? ");
       _duration = int.Parse(Console.ReadLine());

        //Prompt the user to begin with the Spinner counting
       Console.WriteLine("\nGet ready to begin...");





    }

    //returning a void DisplayEndingMessage method
    public void DisplayEndingMessage()
    {
        // Making sure all messaged end the same way
        Console.WriteLine("Well done!!");
        ShowSpinner(3);

        //Showing the user have a side activity in stipulated duration
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }


    //initiating a ShowSpinner method with int seconds as parameter for the animation code below both for a for and while loop.
    public void ShowSpinner(int Seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine("Done.");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}