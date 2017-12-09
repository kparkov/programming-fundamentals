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

            //The program draws a number of numbers within a certain range, defined in a list. It exports the numbers drawn, to two separate lists which are defined by two variables. It could be a lottery program.


            //Declaring 3 lists of int variables
            List<int> lottoNumbers = new List<int>();
            List<int> mainNumbersDrawn = new List<int>();
            List<int> jokerNumbersDrawn = new List<int>();

            //Declaring 3 variables of int type
            int rangeOfLottoNumbers = 36;

            //used as number of entries in list lnum
            int mainLottonumbersToBeDrawn = 7;

            //used as number of entries in list anum
            int jokerNumbersToBeDrawn = 1;


            //Checks condition if two int type variables added yields a result numerical larger than a third
            if ((mainLottonumbersToBeDrawn + jokerNumbersToBeDrawn) > rangeOfLottoNumbers)
            {
                //If condition is true, the console writes an error message, and exits the program
                Console.WriteLine("The total numbers to be drawn exceeds the number of numbers which are available. Please change the number of main numbers or jokernumbers to a lower value and try again.");
                Console.ReadKey();
                Environment.Exit(1);
            }

            //Generates random number variable r
            Random r = new Random();


            //Declares int variable x and sets its value to 1
            int x = 1;

            //Loop that checks the condition if int variable x is smaller than, or equal to int variable ub
            while (x <= rangeOfLottoNumbers)
            {
                //While the loop runs because the condition is true, x is added to the list "pool"
                lottoNumbers.Add(x);
                //The variable x is added 1 every time the loop runs
                x = x + 1;
            }


            // We now expect 'pool' to contain the numbers from 1 to 36. (x = 37)

            
          

            //This loop runs while the number of entries in list "lnum" is less than variable lnt, or number of entries in the list "anum" is less than the variable ant.
            while (mainNumbersDrawn.Count < mainLottonumbersToBeDrawn || jokerNumbersDrawn.Count < jokerNumbersToBeDrawn)
            {
                //Generates a random number between 0 and number of entries in list "pool"
                int next = r.Next(0, lottoNumbers.Count);

                //Assigns the random number between 0 and number of entries in the list "pool" to "lnum"
                if (mainNumbersDrawn.Count < mainLottonumbersToBeDrawn)
                {
                    mainNumbersDrawn.Add(lottoNumbers[next]);
                }
                //Assigns the random number between 0 and number of entries in the list "pool" to "anum", when "lnum" is filled because it has reached "lnt"-value.
                else
                {
                    jokerNumbersDrawn.Add(lottoNumbers[next]);
                }

                //removes the number added to lnum or anum from pool.
                lottoNumbers.RemoveAt(next);
            }

            // We now expect lnum to contain lnt number of numbers from list "pool"
            // We now expect anum to contain ant number of numbers from list "pool"
            // We now expect pool to contain ub - (lnt+ant) numbers between 0 and ub

            //Sorts the lists lnum and anum ascending
            mainNumbersDrawn.Sort();
            jokerNumbersDrawn.Sort();

            Console.WriteLine("The Lottonumbers for this week are:  ");
            mainNumbersDrawn.ForEach(Console.WriteLine);
            Console.ReadKey();

            Console.WriteLine("The extra jokernumber(s) for this week is:  ");
            jokerNumbersDrawn.ForEach(Console.WriteLine);
            Console.ReadKey();

        }

    }
}
