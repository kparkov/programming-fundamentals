using System;
using System.Collections.Generic;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE: THE LAZY DEVELOPER
            // The following code works as intended, but is hard to understand.
            // a. Write a comment above each line of code. Explain what each line of code does or is expected to do.
            // b. Mix pure analysis, Console.WriteLine and debugging to explain what the code as a whole does. You might even arrive at an idea of what it could be used for.
            // c. Rename each variable to improve the readability of the entire program.
            // d. Change the error message to something sane that actually gives us information about why the program must terminate.

            //Laver en liste der kan indeholde tal der hedder Pool
            List<int> pool = new List<int>();
            
            //Laver en liste der kan indeholde tal der hedder lnum

            List<int> lnum = new List<int>();

            //Laver en liste der kan indeholde tal der hedder lnum
            List<int> anum = new List<int>();

            //Laver 3 variable der er tal
            int ub = 36;
            int lnt = 7;
            int ant = 1;
            
            
            //Så længe  variablerne lnt+ant er større end variablen ub skriver den koden under, OG DET ER DÅRLIGT for så kommer programmet ikke videre
            if ((lnt + ant) > ub)
            {
                Console.WriteLine("ERROR! FAILURE INEVITABLE. Success impossible. Process will end. OK, bye.");
                Console.ReadKey();
                Environment.Exit(1);
            }

            //Genererer en variabel af tilfældige tal
            Random r = new Random();

            int x = 1;

            while (x <= ub)
            {
                pool.Add(x);
                x = x + 1;
            }

            // We now expect 'pool' to contain ...36 ints
            //Så længe listen lnum couner er mindre end variablen lnt ELLER listen anums tæller er mindre en variablen ant

            while (lnum.Count < lnt || anum.Count < ant)
            {
                int next = r.Next(0, pool.Count);

                if (lnum.Count < lnt)
                {
                    lnum.Add(pool[next]);
                }
                else
                {
                    anum.Add(pool[next]);
                }

                pool.RemoveAt(next);
            }

            // We now expect lnum to contain ...
            // We now expect anum to contain ...
            // We now expect pool to contain ...

            lnum.Sort();
            anum.Sort();
        }
    }
}
