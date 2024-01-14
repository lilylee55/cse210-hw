using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        Random randomGenerator = new Random();

        while (playAgain == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessCount = 0;
            while (magicNumber != guess)
            {
                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                guessCount++;
            }
            Console.WriteLine($"You guessed it in {guessCount} guesses.");
            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine();    
        }

    }
}