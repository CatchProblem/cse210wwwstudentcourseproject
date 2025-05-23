using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Welcome to the Guess My Number game!");

                // Step 1: Generate a random magic number between 1 and 100
                Random random = new Random();
                int magicNumber = random.Next(1, 101);

                int guessCount = 0; // Track the number of guesses
                int userGuess = 0;

                Console.WriteLine("I have selected a magic number between 1 and 100. Try to guess it!");

                // Step 2: Loop until the user guesses correctly
                while (userGuess != magicNumber)
                {
                    Console.Write("What is your guess? ");
                    string userInput = Console.ReadLine();

                    // Validate if the input is a valid integer
                    if (int.TryParse(userInput, out userGuess))
                    {
                        guessCount++; // Increment guess count

                        if (userGuess < magicNumber)
                        {
                            Console.WriteLine("Higher");
                        }
                        else if (userGuess > magicNumber)
                        {
                            Console.WriteLine("Lower");
                        }
                        else
                        {
                            Console.WriteLine("You guessed it!");
                            Console.WriteLine($"It took you {guessCount} guesses.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }

                // Step 3: Ask if the user wants to play again
                Console.Write("Do you want to play again? (yes/no): ");
                string playAgainInput = Console.ReadLine()?.ToLower();

                if (playAgainInput != "yes")
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing! Goodbye!");
                }
            }
        }
    }
}
