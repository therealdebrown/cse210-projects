using System;
using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        
            Console.WriteLine("Hello Prep3 World!");

            Console.Write("Enter the magic number: ");
            int magicNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your guess: ");
            int guess = int.Parse(Console.ReadLine());
        
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You have guess it");
            }
        
    

    string playAgain;
        do
        {
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guess it right. it took you {guessCount} guesses.");
                }
            }
            Console.WriteLine("Do you still want to play? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");
        Console.WriteLine("Thanks for playing.");
    }
}