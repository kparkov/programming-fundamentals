using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = Computer.ThinkOfNumber();

            bool gameIsWon = false;
            int counter = 0;
            string textBase = "Forkert. Dit næste gæt skal være";
            string highGuessText = textBase + " lavere.";
            string lowGuessText = textBase + " højere.";

            while (!gameIsWon)
            {
                int userGuess = User.GetGuess();
                counter = counter + 1;

                if (userGuess > secretNumber)
                {
                    Console.WriteLine(highGuessText);
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine(lowGuessText);
                }
                else
                {
                    gameIsWon = true;
                }
            }

            Console.WriteLine("Tillykke. Du klarede det på " + counter + " gæt.");

            if (counter > 7)
            {
                Console.WriteLine("Vidste du, at en optimal spilstrategi sikrer, at du aldrig skal gætte mere end 7 gange?");
            }

            Console.ReadKey();
        }
    }
}