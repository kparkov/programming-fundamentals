using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE: ORDER FROM CHAOS

            List<int> numbers = new List<int>();
            Random random = new Random();

            int counter = 0;

            while (counter < 10)
            {
                numbers.Add(random.Next(1, 101)); // The upper bound of random.Next(min, max) is EXCLUSIVE, so this will be a number from 1 to 100.
                counter += 1;
            }
            
            // The list 'numbers' contains 10 random numbers, each in the range 1-100.
            // a. Output all the numbers in the list to the console.
            // b. Calculate the sum of all the numbers in the list.
            // c. Create a new list containing all the numbers in 'numbers' that are higher than or equal to 50.
            // d. Display the three highest numbers in the list.

            // EXERCISE: A MINUSCULE MISTAKE

            string swedenPrime = "kjell stefan löfven";

            // Capitalize the first letter of each name in the full name. The solution should - of course - work for any name.
        }
    }
}
