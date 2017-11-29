using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can get a new random number like this:
            

            int secretNumber = Computer.ThinkOfNumber();

            Console.WriteLine("Jeg tænker nu på et hemmeligt tal. Prøv at gætte det.");

            bool noWin = true;

            int Counter = 0;

            while (noWin)

            {
                int userGuess = User.GetGuess();

               
                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Dit gæt var for lavt. prøv igen");
                }

                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Dit gæt var for højt. Prøv igen.");
                }

                else if (userGuess == secretNumber)
            {
                Console.WriteLine("Tillykke. Du har vundet!");
                 

            }
            }
                

           Counter = Counter + 1;
            Console.WriteLine("Du har nu brugt " + Counter + " gæt");




            // We can get a user guess like this:




            Console.WriteLine("Brug while og if/else if/else til at lave det til et gættespil.");
        }
    }
}