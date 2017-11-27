using System;

namespace BooleanExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE: TIVOLI ENTRY REQUIREMENTS

            int customerAge = 12;
            int customerHeight = 152;
            int customerWeight = 49;

            // The three variables above are the metrics of a customer.
            // Write tests for the following fictitious Tivoli entry requirements:

            // To try Mariehønen, you must be at least 5 years old.
            bool canTryMariehønen = customerAge >= 5;
            // To try Veteranbilerne, you must be at least 1 year old and at least 60 cm tall.
            bool canTryVeteranbilerne = customerAge >= 1 && customerHeight >= 60;
            // To try Ballongyngerne, you must be at least 80 cm tall and must not weigh more than 170 kg.
            bool canTryBallongyngerne = customerHeight >= 80 && customerWeight <= 170;
            // To try Rutsjebanen, you must not be more than 210 cm or weigh more than 190 kg.
            bool canTryRutsjebanen = customerHeight >= 210 && customerWeight <= 190;
            // To try Dæmonen, you must be at least 16 years old and less than 80 years old - but no matter what you cannot be taller than 210 or weigh more than 150
            bool canTryDæmonen = (customerAge >= 16 && customerAge < 80) && (customerHeight <= 210 && customerWeight <= 150);
            // To try Kaoshuset, you cannot be exactly 100 years old, and you must either weigh between 40 and 60 or between 90 and 110.
            bool canTryKaoshuset = customerAge != 100 && ((customerWeight >= 40 && customerWeight <= 60) || (customerWeight >= 90 && customerWeight <= 110));

            Console.WriteLine(canTryMariehønen);
            Console.WriteLine("Can try Kaoshuset? " + canTryKaoshuset);
        
            Console.ReadKey();
        }
    }
}
