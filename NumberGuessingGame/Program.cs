using System;

namespace numberguessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new System.Random();
            int guessingNumber = random.Next(1, 50);
            int guesses = 10;
            string playAgain;

            System.Console.WriteLine("Guess a number from 1-50:");
            int guess = int.Parse(Console.ReadLine());

            while (guesses >= 1)
            {

                if (guess == guessingNumber)
                {
                    System.Console.WriteLine("Congratulations! You guessed the mystery number");
                    System.Console.WriteLine("Would you like to play again? yes or no?");
                    playAgain = Console.ReadLine();

                    if (playAgain == "yes")
                    {
                        guesses = 10;
                        guessingNumber = random.Next(1, 50);
                        System.Console.WriteLine("Guess a number from 1-50:");
                        guess = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }
                else 
                {
                    if (guess < guessingNumber) 
                    {
                        guesses--;
                        System.Console.WriteLine("Your guess was too low, you have {0} guesses remaining. Guess again.", guesses);
                        guess = int.Parse(Console.ReadLine());
                    }
                    else 
                    {
                        guesses--;
                        System.Console.WriteLine("Your guess was too high, you have {0} guesses remaining. Guess again", guesses);
                        guess = int.Parse(Console.ReadLine());
                    }
                }
                if (guesses == 1)
                {
                    System.Console.WriteLine("You have run out of guesses! The correct number was {0}!", guessingNumber);
                    System.Console.WriteLine("Would you like to play again? yes or no?");
                    playAgain = Console.ReadLine();
                    
                    if (playAgain == "yes")
                    {
                        guesses = 10;
                        guessingNumber = random.Next(1, 50);
                        System.Console.WriteLine("Guess a number from 1-50:");
                        guess = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }

            }
           
        }
    }
}
