using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can get a new random number like this:
            int secretNumber = Computer.ThinkOfNumber();
            Console.WriteLine("Jeg tænker på et meget hemmeligt tal");

            // We can get a user guess like this:
            int userGuess = 0;
            bool UserIsRight = userGuess == secretNumber;
            int numberofGuesses = 0;

            while (!UserIsRight) 
            {
                userGuess = User.GetGuess();
                Console.WriteLine("Brugeren gættede på: " + userGuess);

                if (userGuess < secretNumber) 
                {
                    Console.WriteLine("Det var sgu for lavt");
                    UserIsRight = false;
                }
               
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Det var sgu for højt");
                    UserIsRight = false;
                }
                else 
                {
                    UserIsRight = true;   
                }
                numberofGuesses++;
            }
            Console.WriteLine("Du gættede mit tal, der var: " + secretNumber);
            Console.WriteLine("Flot. Og kun på: " + numberofGuesses + " gæt");



        }
    }
}