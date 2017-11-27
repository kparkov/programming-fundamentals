using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer
            int age = 15;
            decimal money = 95m;

            // Requirements
            int movieMinimumAgeRequirement = 13;
            decimal moviePrice = 110m;

            // EXERCISE: CAN WE GO SEE THE MOVIE?
            // Write an if/else that checks whether the customer fulfills all the requirements for seeing the movie, and write the result in the Console.

            bool hasRightAge = age >= movieMinimumAgeRequirement;
            bool hasEnoughMoney = money >= moviePrice;
            
            if (hasRightAge && hasEnoughMoney)

            {
                Console.WriteLine("Du må gerne se filmen");
       
            }
            else
            {
                Console.WriteLine("Der var følgende problemer");
            }            
            if (!hasRightAge)
            {
                Console.WriteLine("Du er ikke gammel nok.");
            
            }
            if (!hasEnoughMoney)
            {
                Console.WriteLine("Du har ikke nok penge.");
            }
          


            // EXERCISE: SPECIFIC FEEDBACK
            // We want to provide more specific feedback to the customer. If the customer cannot go and see the movie, we want to
            // provide detailed feedback: was it his/her age, or lack of money, or perhaps both?

            Console.ReadKey();
        }
    }
}
