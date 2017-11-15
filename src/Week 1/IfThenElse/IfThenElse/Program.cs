using System;

namespace IfThenElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your guess? ");
            var guess = Console.ReadLine();

            Console.WriteLine(guess);
            Console.ReadKey();
        }

        private static void RunSimpleIfExample()
        {
            int age = 20;

            if (age >= 18)
            {
                Console.WriteLine("Du kan begynde at tage et kørekort.");
            }

            bool isAdult = false;

            if (age >= 18)
            {
                isAdult = true;
            }

            Console.WriteLine($"isAdult: {isAdult}");
        }

        private static void RunIfElseExample()
        {
            int age = 15;
            int minAgeRequirement = 18;

            if (age >= minAgeRequirement)
            {
                Console.WriteLine("Du er gammel nok.");
            }
            else
            {
                Console.WriteLine($"Du må desværre vente til du fylder {minAgeRequirement} år.");
            }


        }
    }
}
