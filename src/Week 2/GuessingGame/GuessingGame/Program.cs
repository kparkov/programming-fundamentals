using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can get a new random number like this:
            int secretNumber = Computer.ThinkOfNumber();
            Console.WriteLine("Jeg tænker på det meget hemmelige tal: " + secretNumber);

            // We can get a user guess like this:
            int userGuess = User.GetGuess();
            Console.WriteLine("Brugeren gættede på: " + userGuess);
        }
    }
}