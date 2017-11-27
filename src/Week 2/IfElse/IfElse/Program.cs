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
            bool canSeeMovie = age > movieMinimumAgeRequirement && money > moviePrice;
            if (canSeeMovie)
            {
                Console.WriteLine("You can see movie.");

            }
            else
            {
                Console.WriteLine("You can't see movie.");
            }

            // EXERCISE: SPECIFIC FEEDBACK
            // We want to provide more specific feedback to the customer. If the customer cannot go and see the movie, we want to
            // provide detailed feedback: was it his/her age, or lack of money, or perhaps both?
            if (!canSeeMovie && (age < movieMinimumAgeRequirement && money > moviePrice))
            {
                Console.WriteLine("You are too young.");
            }
            else if (!canSeeMovie && (age > movieMinimumAgeRequirement && money < moviePrice))
            {
                Console.WriteLine("You are too poor.");
            }
            else if (!canSeeMovie && (age < movieMinimumAgeRequirement && money < moviePrice))
            {
                Console.WriteLine("You are too young and too poor.");
            }
                Console.ReadKey();
        }
    }
}
