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
            int minAgMarie = 5;

            bool canTryMarie = customerAge >= minAgMarie;



            // To try Veteranbilerne, you must be at least 1 year old and at least 60 cm tall.
            int minAgeVet = 1;
            int minHeightVet = 60;

            bool tryVet = customerAge >= minAgeVet && customerHeight >= minHeightVet;

            // To try Ballongyngerne, you must be at least 80 cm tall and must not weigh more than 170 kg.
            int minHeightBallon = 80;
            int maxWeightBallon = 170;

            bool tryBallon = customerAge >= minHeightBallon && customerWeight <= maxWeightBallon;

            // To try Rutsjebanen, you must not be more than 210 cm or weigh more than 190 kg.
            int maxHeightRut = 210;
            int maxWeightRut = 190;

            bool tryRut = customerHeight <= maxHeightRut && customerWeight <= maxWeightRut;

            // To try Dæmonen, you must be at least 16 years old and less than 80 years old - but no matter what you cannot be taller than 210 or weigh more than 150
            int minAgeDæm = 16;
            int maxAgeDæm = 80;
            int maxHeightDæm = 210;
            int maxWeightDæm = 150;

            bool tryDæm = customerAge >= minAgeDæm && customerAge <= maxAgeDæm && customerHeight <= maxHeightDæm && customerHeight <= maxWeightDæm;

            // To try Kaoshuset, you cannot be exactly 100 years old, and you must either weigh between 40 and 60 or between 90 and 110.
            int minWeight1Kaos = 40;
            int maxWeight1Kaos = 60;
            int minWeight2Kaos = 90;
            int maxWeight2Kaos = 110;
            int ageNotAlowed = 100;


            if custumerAge == !ageNotAlowed
                { }
            bool tryKaos = !(customerAge == ageNotAlowed) && maxWeight1Kaos =< customerWeight >= minWeight1Kaos || maxWeight2Kaos =< customerWeight >= maxWeight2Kaos;

            
        }
    }
}
