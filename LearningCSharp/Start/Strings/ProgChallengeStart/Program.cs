using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            bool isPlaying = true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int guessCount = 0;
            int currentGuess = 0;

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            do
            {
                System.Console.WriteLine("What's your guess?");
                string guess = Console.ReadLine();
                bool isNum = Int32.TryParse(guess, out currentGuess);
                guessCount++;

                if (!isNum)
                {
                    System.Console.WriteLine("That doesn't seem to be a valid number. Please try again!");
                    continue;
                }

                if (currentGuess == -1)
                {
                    System.Console.WriteLine($"The number I was thinking of is {theNumber}");
                    isPlaying = false;
                }

                if (currentGuess == theNumber)
                {
                    isPlaying = false;
                    System.Console.WriteLine($"You got it in {guessCount} guesses!");
                }
                else
                {
                    System.Console.WriteLine("Nope, you need to guess {0}", theNumber > currentGuess ? "higher" : "lower");
                }
            }
            while (isPlaying);


        }
    }
}
