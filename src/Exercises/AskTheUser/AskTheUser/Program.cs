using System;

namespace AskTheUser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Øvelse 1Bed høfligt om brugerens navn, fødeår og hjemby.Informationerne skal gemmes i tre forskellige variabler.
            //    Lav en samlet præsentation af brugeren: "Du hedder ..., er født i ..., og bor i ...".


            List<int> userYears = new List<int>()
            {

            };
            Console.WriteLine("Hvad er dit navn?");
            string userName = Console.ReadLine();
            

            if (userName.Contains(" "))

            { Console.WriteLine("Hejsa " + userName.Substring(0 , userName.IndexOf( " "))); }

            else
                Console.WriteLine("Hejsa " + userName);





            Console.WriteLine("Hvilket år er du født?");
            string userBirthYear = Console.ReadLine();

            int userBirthYearNumber = int.Parse(userBirthYear);

            Console.WriteLine("Hvilken by er du født i?");
            string userBirthTown = Console.ReadLine();
            int userAge = (2017 - userBirthYearNumber);

            Console.WriteLine("Hej " + userName + "." + " Du er " + userAge + " år gammel, og er født i byen " + userBirthTown + ".");

            int userMinLeapYear = (userAge / 4);

            

            if((userBirthYearNumber%4) == 0 )
            { Console.WriteLine("Du har oplevet " + (userMinLeapYear + 1) + " skudår"); }

            else
            {
                Console.WriteLine("Du har oplevet " + (userMinLeapYear) + " skudår");
            }


            //Lav en liste med alle de år user har levet. For hvert år der er deleligt med 4 tilføjes et år til en anden liste eller counter


            Console.ReadKey();
        }
    }
}
