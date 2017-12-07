using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // To make these exercises manageable, solve each sub-exercise (1A, 1B, etc.) completely before proceeding to the next one.
            // The sub-exercises modify your existing code, so you shouldn't write a separate chunk of code for each sub-exercise (unless you want to).

            // EXERCISE 1

            int repeat = 10;
            int startNumber = 4;
            int stepNumber = 3;

            // 1A. Write a while loop. It should run as many times as the "repeat" variable states. Write the same line of text to the console each time. OK
            // 1B. Modify the outputted line so it writes the number of times the loop has been running on screen (1, 2, 3, 4, and so on). OK
            // 1C. Modify the numbering, so it begins counting from "startNumber", and still adds 1 each time (4, 5, 6, 7, and so on). It should still run "repeat" TIMES in total. OK
            // 1D. Modify the numbering, so it adds "stepNumber" instead of 1 each time (4, 7, 10, 13, and so on).
            // 1E. Your solution should use the variables above, and if their values are changed, it should be reflected when we run the loop. It should have no fixed upper limits for repeat.
            // 1F. In addition to writing the current number, also write whether that number is even or odd (4 is even, 7 is odd, 10 is even, 13 is odd, and so on).

            int counter = startNumber;

            while (counter < repeat * startNumber)
            {
                Console.WriteLine("Vi tæller:  " + counter);

                if (counter % 2 == 0)
                {
                    Console.WriteLine("Det var et lige tal!");
                }
                else
                {
                    Console.WriteLine("Det var et ulige tal!");
                }

                counter = counter + stepNumber;
            }
        
    
  

         

            // EXERCISE 2

            // The local scouts puts their members in a certain group, depending on their age.
            // 0 - 5 years: haletudser
            // 6 - 7 years: bævere
            // 8 - 10: ulveunger
            // 11 - 14: tropspejdere
            // 15 - 16: seniorspejdere
            // 17 - (no limit): klanspejdere

            int scoutAge;
            int notLeaderAge;
            int isScoutLeader;

            Console.WriteLine("Hej Spejder! Er du leder? Tryk 1 for JA og 2 for NEJ");

            if (int.TryParse(Console.ReadLine(), out isScoutLeader))
            {
                if (isScoutLeader == 1)
                {
                    Console.WriteLine("Du siger du er leder. Men hvor gammel er du? Skriv din alder:  ");
                    if (int.TryParse(Console.ReadLine(), out scoutAge))
                    {
                        if (scoutAge >= 15)
                        {
                            Console.WriteLine("Jo! Du er søreme leder!");
                        }
                        else if (scoutAge < 5)
                        {
                            Console.WriteLine("Du er ikke gammel nok til at være leder! Men du kan være Haletudse!");
                        }
                        else if (scoutAge >= 6 && scoutAge <= 7)
                        {
                            Console.WriteLine("Du er ikke gammel nok til at være leder, men du kan være Bæver!");
                        }
                        else if (scoutAge >= 8 && scoutAge <= 10)
                        {
                            Console.WriteLine("Du er ikke gammel nok til at være leder, men du kan være Ulveunge!");
                        }
                        else if (scoutAge >= 11 && scoutAge <= 14)
                        {
                            Console.WriteLine("Du er ikke gammel nok til at være leder, men du kan være Tropspejder!");
                        }

                    }
                }
                else if (isScoutLeader != 1)

              
                {
                    Console.WriteLine("Så du er ikke leder? Hvor gammel er du?  ");
                    if (int.TryParse(Console.ReadLine(), out notLeaderAge))
                    {
                        if (notLeaderAge <= 5)
                        {
                            Console.WriteLine("Så er du Haletudse!");
                        }
                        else if (notLeaderAge >= 6 && notLeaderAge <= 7)
                        {
                            Console.WriteLine("Så er du Bæver!");
                        }
                        else if (notLeaderAge >= 8 && notLeaderAge <= 10)
                        {
                            Console.WriteLine("Så er du Ulveunge!");
                        }
                        else if (notLeaderAge >= 11 && notLeaderAge <= 14)
                        {
                            Console.WriteLine("Så er du Tropspejder!");
                        }
                        else if (notLeaderAge >= 15 && notLeaderAge <= 16)
                        {
                            Console.WriteLine("Så er du Seniorspejder!");
                        }
                        else if (notLeaderAge >= 17)
                        {
                            Console.WriteLine("Så er du Klanspejder!");
                        }
                    }
                }   
            }
        }
    }
}




