using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

       // An added code to calculate the number of activities completed in the project or exercise.    
        int activitiesCompleted = 0;

        string choice = "";
        // A while loop that keeps going till the user's choice becomes 4 to quit
        while (choice != "4")
        {
            // The code below clears the screen, making it easier to see without making it congested
            Console.Clear();

            // The option menu below
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine("Select a choice from the Menu above: ");
            choice = Console.ReadLine();
            
            // Condition if the choice was 1 
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                activitiesCompleted++;
            }
            else if (choice == "2") // if it is 2
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                activitiesCompleted++;
            }
            else if (choice == "3") // if it is 3 
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                activitiesCompleted++;
            }

            // Below records and displays the number of activities performed and completed, prompts to continue and allows the user to indicate the option of his/her choice.
            Console.WriteLine($"\nActivities completed so far: {activitiesCompleted}");
            Console.WriteLine("Press Enter to continue ...");
            Console.ReadLine();
        }
    }
}