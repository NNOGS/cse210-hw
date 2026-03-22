using System;
using System.Collections.Generic;

// EXCEEDING REQUIREMENTS:
// This program improves functionality by only hiding words that are not already hidden
// and randomly selecting how many words to hide each time.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer!");

        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            "For God so loved the world that he gave his one and only Son",
            new Reference("John", 3, 16)));

        scriptures.Add(new Scripture(
            "Trust in the Lord with all thine heart and lean not unto thine own understanding",
            new Reference("Proverbs", 3, 5, 6)));

        scriptures.Add(new Scripture(
            "I can do all things through Christ which strengtheneth me",
            new Reference("Philippians", 4, 13)));

        // ✅ Pick random scripture
        Random rnd = new Random();
        Scripture s = scriptures[rnd.Next(scriptures.Count)];

        // Main loop
        while (true)
        {
            Console.WriteLine(s.GetDisplayText());
            Console.WriteLine();

            if (s.IsCompletelyHidden())
            {
                Console.WriteLine(s.GetDisplayText());
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Optional: random number of words
            int numberToHide = rnd.Next(1, 4);
            s.HideRandomWords(numberToHide);

            Console.Clear();
        }
    }
}
