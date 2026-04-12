using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        List<Goal> goals = new List<Goal>();// create a list that stores all Goals.
        int score = 0; // stores variable

        while (true)// while loop or infinit Menu loop until the user chooses to quit
        {
            // Showing options available to the user
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            // Getting User Choice
            Console.Write("Select choice: ");//prompting the user for a choice
            int choice = int.Parse(Console.ReadLine()); // converting the read text into a number

            if (choice == 1)// On conditions of 1, a new Goal is created
            {
                Console.WriteLine("Goal Types:");// the Goal type
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                Console.Write("Which type? ");
                int type = int.Parse(Console.ReadLine());

                Console.Write("Goal name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == 1)// if 1 was typed, a new simpleGoal is created
                {
                    goals.Add(new SimpleGoal(name, desc, points));
                }

                else if (type == 2) // else if 2 an EternalGoal is created
                {
                    goals.Add(new EternalGoal(name, desc, points));
                }

                else if (type == 3) // if 3 a checklistGoal is created
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }

            else if (choice == 2)// conditions for the second choice below
            {
                Console.WriteLine("Goals:");

                for (int i = 0; i < goals.Count; i++)
                {
                    string status = goals[i].IsComplete() ? "[X]" : "[ ]";
                    Console.WriteLine($"{i}. {status} {goals[i].GetDetailsString()}");
                }
            }

            else if (choice == 3)// conditins for the 3 choice
            {
                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine());

                int points = goals[index].RecordEvent();
                score += points;

                Console.WriteLine($"You earned {points} points");
            }

            else if (choice == 4)// conditions for the 4th choice
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();

                using (System.IO.StreamWriter output = new System.IO.StreamWriter(file))
                {
                    output.WriteLine(score);

                    foreach (Goal g in goals)
                    {
                        output.WriteLine(g.GetStringRepresentation());
                    }
                }
                Console.WriteLine("Goals saved.");

            }

            else if (choice == 5) // Conditions for the 5th choice
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(file);

                score = int.Parse(lines[0]);
                goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split(":");

                    string type = parts[0];
                    string[] data = parts[1].Split(",");

                    if (type == "Simple")
                    {
                        goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));
                    }

                    else if (type == "Eternal")
                    {
                        goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                    }

                    else if (type == "Checklist")
                    {
                        goals.Add(new ChecklistGoal(
                            data[0],
                            data[1],
                            int.Parse(data[2]),
                            int.Parse(data[3]),
                            int.Parse(data[4])
                        ));
                    }
                }
                Console.WriteLine("Goals loaded.");
            }
            else if (choice == 6)// Conditions for the 6th choice which is to quit/break.
            {
                break;
            }
        }
    }
}