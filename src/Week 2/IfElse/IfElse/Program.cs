using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer wants to see a movie, but has to fulfill to criteriae

            int minimumAgeRequirement = 12;
            int moviePrice = 110;

            Console.WriteLine("Så du vil gerne i biffen!");
            Console.WriteLine("Hvor gammel er du?");

            int customerAge;

            if (int.TryParse(Console.ReadLine(), out customerAge))

            {
                if (customerAge >= minimumAgeRequirement)
                {
                    Console.WriteLine("Du er gammel nok til at se din film!");
                    Console.WriteLine("Men har du penge nok? Indtast det beløb du har til bif-billetten!");

                    int customerMoney;

                    if (int.TryParse(Console.ReadLine(), out customerMoney))

                    {
                        if (customerMoney >= moviePrice)

                        {
                            Console.WriteLine("Du har også penge nok! Det ser ud til du skal i biffen");
                        }

                        else 

                        {
                            Console.WriteLine("Du har desværre ikke penge nok!");
                        }

                    }
                                  
                    
                }
                else
                {
                    Console.WriteLine("Du er desværre ikke gammel nok! Prøv Peter Plys!");
                }
            }
            
            
            // EXERCISE: SPECIFIC FEEDBACK
            // We want to provide more specific feedback to the customer. If the customer cannot go and see the movie, we want to
            // provide detailed feedback: was it his/her age, or lack of money, or perhaps both?

            Console.ReadKey();
        }
    }
}
