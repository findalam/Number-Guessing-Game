using System;

namespace guessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;




            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";



                number = random.Next(min, max + 1);


                while (true)
                {
                    Console.WriteLine($"Guess a number between {min} and {max}");


                    string userInput = Console.ReadLine();

                    if (!int.TryParse(userInput, out guess))
                    {
                        Console.WriteLine("Invalid input. You have to enter only numbers.");
                        continue;
                    }

                    Console.WriteLine($"You have guessed : {guess}");

                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is too low!");
                    }
                    else
                    {
                        break;
                    }


                    guesses++;

                }

                Console.WriteLine($"The secret number was : {number}");
                Console.WriteLine("Congratulation, YOU WIN!");
                Console.WriteLine($"You took {guesses} attempt to win.");

                Console.WriteLine("Would you like to play again? (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;

                }




            }

            Console.WriteLine("Thank you for playing the guessing game, see you next time!");
            Console.ReadKey();
        }
    }
}
