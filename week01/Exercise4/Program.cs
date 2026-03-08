using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter numbers one by one and hit 0 to stop if you please: ");

        do
        {
            Console.Write("Enter a number of your choice: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = (double)sum / numbers.Count;
            int max = numbers.Max();

            Console.WriteLine("Sum of numbers: " + sum);
            Console.WriteLine("Average of numbers: " + average);
            Console.WriteLine("Maximum number: " + max);
        }
        else
        {
            Console.WriteLine("No numbers were entered. ");
        }
        Console.WriteLine($"You entered: {numbers.Count} numbers.");

    }
}