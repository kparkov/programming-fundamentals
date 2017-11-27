using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can get a new random number like this:
            int secretNumber = Computer.ThinkOfNumber();
            Console.WriteLine("Jeg tænker på et meget hemmeligt tal, skriv dit gæt");

            // We can get a user guess like this:
            //int userGuess = User.GetGuess();
            //Console.WriteLine("Brugeren gættede på: " + userGuess);

            // Console.WriteLine("Brug while og if/else if/else til at lave det til et gættespil.");

            bool keepPlaying = true;
            int userGuess = User.GetGuess();
            while (keepPlaying)
            {
                

                if (userGuess > secretNumber)   
                {

                    
                    Console.WriteLine("Guess lower");
                }

                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Guess higher");
                }
            }

            
            Console.WriteLine("Tillykke");

        }
    }
}