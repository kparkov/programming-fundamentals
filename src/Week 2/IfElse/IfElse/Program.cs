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

            bool isOldEnough = age >= movieMinimumAgeRequirement;
            bool hasMoneyEnough = money >= moviePrice;
            bool canSeeMovie = isOldEnough && hasMoneyEnough;

            if (canSeeMovie)
            {
                Console.WriteLine("Velkommen i biffen");
            }
            else
            {
                Console.WriteLine("Du er ikke velkommen af følgende årsager:");

                if (!isOldEnough)
                {
                    Console.WriteLine("- Du er ikke gammel nok.");
                }

                if (!hasMoneyEnough)
                {
                    Console.WriteLine("- Du har ikke penge nok.");
                }
            }


            // EXERCISE: SPECIFIC FEEDBACK
            // We want to provide more specific feedback to the customer. If the customer cannot go and see the movie, we want to
            // provide detailed feedback: was it his/her age, or lack of money, or perhaps both?

            Console.ReadKey();
        }
    }
}
