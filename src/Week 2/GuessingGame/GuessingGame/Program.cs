using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can get a new random number like this:
            int secretNumber = Computer.ThinkOfNumber();
            //Console.WriteLine("Jeg tænker på det meget hemmelige tal: " + secretNumber);

            // We can get a user guess like this:
            //int userGuess = User.GetGuess();
            // Console.WriteLine("Brugeren gættede på: " + userGuess);
            int tæller = 0;
            bool win = false;
            string høj = "Dit gæt er for højt";
            string lav = "Dit gæt er for lavt";
            while (!win)

            {
                int userGuess = User.GetGuess();

                if (userGuess == secretNumber)
                {
                    win = true;

                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine(høj);
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine(lav);
                }

                tæller = tæller + 1;
            }

           

            Console.WriteLine("Tillykke! Du er for vild. Du brugte " + tæller + " gæt");

            Console.ReadKey();
        }
    }
}