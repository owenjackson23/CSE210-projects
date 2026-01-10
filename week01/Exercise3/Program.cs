using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepPlaying = true;
        int userGuess;
        int guessCount = 0;

        do
        {
            // Generate a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // Loop until the user guesses the magic number
            do
            {
                // Prompt the user for a guess
                Console.Write("Guess the magic number: ");
                string guessString = Console.ReadLine();
                userGuess = int.Parse(guessString);
                guessCount++;

                // Check the user's guess
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
                }
            } while (userGuess != magicNumber);

            Console.WriteLine($"You guessed the magic number in {guessCount} tries.");

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainResponse = Console.ReadLine().ToLower();
            while (playAgainResponse != "yes" && playAgainResponse != "no")
            {
                Console.WriteLine("Invalid response.");
                Console.Write("Please enter 'yes' or 'no': ");
                playAgainResponse = Console.ReadLine().ToLower();
            }

            if (playAgainResponse != "yes")
            {
                keepPlaying = false;
            }
            else
            {
                // Reset guess count for the new game
                guessCount = 0;
            }
        } while (keepPlaying);
    }
}