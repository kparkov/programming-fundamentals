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
            // To try Veteranbilerne, you must be at least 1 year old and at least 60 cm tall.
            // To try Ballongyngerne, you must be at least 80 cm tall and must not weigh more than 170 kg.
            // To try Rutsjebanen, you must not be more than 210 cm or weigh more than 190 kg.
            // To try Dæmonen, you must be at least 16 years old and less than 80 years old - but no matter what you cannot be taller than 210 or weigh more than 150
            // To try Kaoshuset, you cannot be exactly 100 years old, and you must either weigh between 40 and 60 or between 90 and 110.


            bool cantryMariehonen = customerAge >= 5;
            Console.WriteLine("Du kan prøve Mariehønen: " + cantryMariehonen);

            bool cantryveteranbilerne = customerAge >= 1 && customerHeight >= 60;
            Console.WriteLine("Du kan prøve Veteranbilerne: " + cantryveteranbilerne);

            bool cantryBallongyngerne = customerHeight >= 80 && customerWeight <= 170;
            Console.WriteLine("Du kan prøve Ballongyngerne: " + cantryBallongyngerne);

            bool cantryRutsjebanen = customerHeight <= 210;
            Console.WriteLine("Du kan prøve Rutsjebanen: " + cantryRutsjebanen);

            bool cantryDaemonen = customerAge >= 16 && customerAge < 80 && customerHeight < 210 && customerWeight < 150;
            Console.WriteLine("Du kan prøve Daemonen: " + cantryDaemonen);


            Console.ReadKey();
        }
    }
}
