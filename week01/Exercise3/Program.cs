using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string playAgain = "yes";

        while (playAgain == "yes")
        {

            int guessCount = 0;

            Console.Write("Hello and What is your Magic Number? ");
            string magicInput = Console.ReadLine();
            int magicNumber = int.Parse(magicInput);

            Console.Write("What is your guess then? ");
            string guessInput = Console.ReadLine();
            int guessNumber = int.Parse(guessInput);

            while (guessNumber != magicNumber)
            {
                guessCount++;

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                Console.Write("What's your guess number this time? ");
                guessNumber = int.Parse(Console.ReadLine());
            }



            Console.WriteLine("Correct Guess, You Nailed it! ");
            Console.WriteLine($"It took you {guessCount} guesses.");


            Console.WriteLine();
            Console.WriteLine("The Computer will generate the magic number randomly! ");

            // Creating Random Generator below
            Random randomGenerator = new Random();
            int randomMagicNumber = randomGenerator.Next(1, 101);

            int randomGuessCount = 0;
            Console.Write("What's your guess? ");
            int randomGuess = int.Parse(Console.ReadLine());

            while (randomGuess != randomMagicNumber)
            {
                randomGuessCount++;

                if (randomGuess > randomMagicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (randomGuess < randomMagicNumber)
                {
                    Console.WriteLine("Higher");
                }

                Console.Write("What's your guess this time? ");
                randomGuess = int.Parse(Console.ReadLine());
            }

            randomGuessCount++;

            Console.WriteLine("Correct guess, You nailed it! ");
            Console.WriteLine($"It took you {randomGuessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        }
    }
}