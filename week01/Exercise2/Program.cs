using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Please What is your grade percentage? ");
        string valueUserGrade = Console.ReadLine();

        int score = int.Parse(valueUserGrade);
        string letter = "";
        string sign = "";


        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80 && score < 90)
        {
            letter = "B";
        }
        else if (score >= 70 && score < 80)
        {
            letter = "C";
        }
        else if (score >= 60 && score < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = score % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }
        
        Console.WriteLine($"Your grade is:  {letter}{sign}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations, You Passed the Course!");
        }
        else
        {
            Console.WriteLine("Put More Effort, You will do better next time!");
        }
    }
}