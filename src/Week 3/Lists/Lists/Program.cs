using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE: ORDER FROM CHAOS

            List<int> numbers = new List<int>();
            List<int> numbersEqualtToOrLargerThanFifty = new List<int>();
            Random random = new Random();

            int counter = 0;
            

            while (counter < 10)
            {
                numbers.Add(random.Next(1, 101)); // The upper bound of random.Next(min, max) is EXCLUSIVE, so this will be a number from 1 to 100.
                counter += 1;            

            }
            foreach (int theRandomNumber in numbers)
            {              
                string presentation = "In the list of random numbers, we now have: " + theRandomNumber;
                Console.WriteLine(presentation);
                              
            };
            var randomNumberSum = numbers.Sum();
            Console.WriteLine("The sum of all the numbers in the random number list is: " + randomNumberSum);
 


            Console.ReadKey();


            // The list 'numbers' contains 10 random numbers, each in the range 1-100.
            // a. Output all the numbers in the list to the console. OK

            // b. Calculate the sum of all the numbers in the list.OK

            // c. Create a new list containing all the numbers in 'numbers' that are higher than or equal to 50. OK



            foreach (int theHighNumbers in numbers)
            {
                if (theHighNumbers >= 50) numbersEqualtToOrLargerThanFifty.Add(theHighNumbers);
            }

            //Result block
            Console.WriteLine("The numbers higher than, or equal to 50, in our list or random numbers, are:  ");
            numbersEqualtToOrLargerThanFifty.Sort();
            numbersEqualtToOrLargerThanFifty.ForEach(Console.WriteLine);
            Console.ReadKey();

            // d. Display the three highest numbers in the list.

            numbers.Sort();
            numbers.Reverse();

            List<int> threeHighestNumbers = numbers.GetRange(0, 3);
            threeHighestNumbers.Sort();
            Console.WriteLine("The three highest numbers in the list are:  ");
            threeHighestNumbers.ForEach(Console.WriteLine);

            Console.ReadKey();





           

                                        

            // EXERCISE: A MINUSCULE MISTAKE

            string swedenPrime = "kjell stefan löfven";

            // Capitalize the first letter of each name in the full name. The solution should - of course - work for any name.
        }
    }
}
