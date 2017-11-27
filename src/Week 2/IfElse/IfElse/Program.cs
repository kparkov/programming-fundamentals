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
            bool hasEnoughMoney = money >= moviePrice;
            bool canSeeMovie = (isOldEnough && hasEnoughMoney);

            //Print kriterierne:
            Console.WriteLine("Din alder er: " + age);
            Console.WriteLine("og du har: " + money + " penge");
            Console.WriteLine("Man skal være: " + movieMinimumAgeRequirement + " år gammel, og filmen koster " + moviePrice);

            //selve tjek:
            if (canSeeMovie == true) 
            {
                Console.WriteLine("Du må gerne se filmen!");
                Console.WriteLine("Din alder er: " + age + " så den er: " + isOldEnough);
                Console.WriteLine("Din pengebeholdning er: " + money + " så den er: " + hasEnoughMoney);
            }
            else 
            {
                Console.WriteLine("Du kan ikke se filmen");
                Console.WriteLine("Din alder er: " + age + " så den er: " + isOldEnough);
                Console.WriteLine("Din pengebeholdning er: " + money + " så den er: " + hasEnoughMoney);
            }

            // EXERCISE: SPECIFIC FEEDBACK
            // We want to provide more specific feedback to the customer. If the customer cannot go and see the movie, we want to
            // provide detailed feedback: was it his/her age, or lack of money, or perhaps both?

            Console.ReadKey();
        }
    }
}
