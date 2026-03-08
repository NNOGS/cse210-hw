using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string UserName = PromptUserName();

        int FavNumber = PromptUserNumber();

        int SquaredNumber = SquareNumber(FavNumber);
        
        DisplayResult(UserName, SquaredNumber);
    }


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What's your Name? ");
            string UserName = Console.ReadLine();
            return UserName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favourite number? ");
            int FavNumber = int.Parse(Console.ReadLine());
            return FavNumber;
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string UserName, int SquareNumber)
        {
            Console.WriteLine($"{UserName}, the square of your number is {SquareNumber} ");
        }
    
}