using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can get a new random number like this:
            int secretNumber = Computer.ThinkOfNumber();
            
            Console.WriteLine("Jeg tænker på et meget hemmeligt tal. Gæt!");

            bool keepPlaying = true;
            int counter = 0;

            while (keepPlaying)
            {
                int userGuess = User.GetGuess();
                counter = counter + 1;
                bool correct = userGuess == secretNumber;
                bool tooLow = userGuess < secretNumber;
                bool tooHigh = userGuess > secretNumber;
                
                    if (correct)
                {
                    keepPlaying = false;
                }
                    else if (tooLow)
                {
                    Console.WriteLine("Too low. Guess again.");
                    
                }
                    else if (tooHigh)
                {
                    Console.WriteLine("too high. Guess again.");
                    
                }

             }

            Console.WriteLine("Correct! You used " + counter + " guesses.");
            Console.ReadKey();









        }
    }
}