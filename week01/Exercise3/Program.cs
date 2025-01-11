using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            int guess = 0;
            int attempts = 0;

            while (guess != randomNumber)
            {
                Console.Write("What is your guess? ");
                int userInput;

                // Validate input
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    guess = userInput; // Update guess with user input
                    attempts++;

                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {attempts} guesses.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thank you for playing!");
            }
        }
    }
}