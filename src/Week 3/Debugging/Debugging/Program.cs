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


            //Declaring 3 lists of int variables
            List<int> pool = new List<int>();
            List<int> lnum = new List<int>();
            List<int> anum = new List<int>();

            //Declaring 3 variables of int type
            int ub = 36;
            int lnt = 7;
            int ant = 1;


            //Checks condition if two int type variables added yields a result numerical larger than a third
            if ((lnt + ant) > ub)
            {
                //If condition is true, the console writes an error message, and exits the program
                Console.WriteLine("ERROR! FAILURE INEVITABLE. Success impossible. Process will end. OK, bye.");
                Console.ReadKey();
                Environment.Exit(1);
            }

            //Generates random numbers
            Random r = new Random();
            //Console.WriteLine(r);
            //Console.ReadKey();

            //Declares int variable x and sets its value to 1
            int x = 1;

            //Loop that checks the condition if int variable x is smaller than, or equal to int variable ub
            while (x <= ub)
            {
                //While the loop runs because the condition is true, x is added to the list "pool"
                pool.Add(x);
                //The variable x is added 1 every time the loop runs
                x = x + 1;
            }

            // We now expect 'pool' to contain the numbers from 1 to 36

            Console.WriteLine(pool);
            Console.ReadKey();
          

            //This loop runs while the number of 
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
