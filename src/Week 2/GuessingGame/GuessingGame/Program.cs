using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can get a new random number like this:
            int secretNumber = Computer.ThinkOfNumber();


            // We can get a user guess like this:


            //bool win = false;
            bool keepPlaying = true;
            int counter = 0;
            while (keepPlaying)
            {
                int userGuess = User.GetGuess();
                counter = counter + 1;
               
                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Forkert - det er for lavt.");
                    
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Forkert - det er for højt.");
                    

                }
                else
                {
                    Console.WriteLine("Tillykke - du gættede rigtigt! Så mange gæt brugte du: " + counter);
                    
                    keepPlaying = false;
                }

                
            }



            


            Console.ReadKey();

            
        }
    }
}