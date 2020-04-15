using System;
using JoesLib;

namespace Joe_LabExam4_2
{
    class Program
    {
        static void Main()
        {
            int MAX_RANGE = 1000;
            Random seed = new Random(); 

            int magic_number = Convert.ToInt16(seed.NextDouble() * MAX_RANGE);
            int userGuess = 0;
            int userGuesses = 0;

            Console.WriteLine(@"Welcome. To play this game, guess a number
and the computer will tell you if you're high or low.
Attempt the lowest number of guesses!
");

            while (true)
            {
                userGuess = Convert.ToInt16(jonsole.getUserNumber("Enter a guess from 0 to " + Convert.ToString(MAX_RANGE) + ": "));
                userGuesses++;
                if (userGuess > magic_number)
                {
                    Console.WriteLine("Your guess was too high, try again, You are on turn {0}", userGuesses);
                }

                if (userGuess < magic_number)
                {
                    Console.WriteLine("Your guess was too low, try again. You are on turn {0}", userGuesses);
                }

                if (userGuess == magic_number)
                {
                    Console.WriteLine("Your guess was correct! The number was {0}, you completed in {1} guesses.", magic_number, userGuesses);
                    return;
                }
            }
        }
    }
}
