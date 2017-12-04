using System;
using System.Diagnostics.Tracing;

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

            // 1A. Write a while loop. It should run as many times as the "repeat" variable states. Write the same line of text to the console each time.
            Console.WriteLine("1A");

            int counter = 0;
            while (counter < repeat)
            {
                Console.WriteLine("Her er en linie.");
                counter += 1;
            }

            // 1B. Modify the outputted line so it writes the number of times the loop has been running on screen (1, 2, 3, 4, and so on).
            Console.WriteLine("1B");

            counter = 0;
            while (counter < repeat)
            {
                int result = counter + 1;
                Console.WriteLine(result);
                counter += 1;
            }

            // 1C. Modify the numbering, so it begins counting from "startNumber", and still adds 1 each time (4, 5, 6, 7, and so on). It should still run "repeat" TIMES in total. 
            Console.WriteLine("1C");

            counter = 0;
            while (counter < repeat)
            {
                int result = counter + startNumber;
                Console.WriteLine(result);
                counter += 1;

            }
            
            // 1D. Modify the numbering, so it adds "stepNumber" instead of 1 each time (4, 7, 10, 13, and so on).
            Console.WriteLine("1D");

            counter = 0;
            while (counter < repeat)
            {
                int result = counter * stepNumber + startNumber;
                Console.WriteLine(result);
                counter += 1;
            }

            // 1E. Your solution should use the variables above, and if their values are changed, it should be reflected when we run the loop. It should have no fixed upper limits for repeat.
            // 1F. In addition to writing the current number, also write whether that number is even or odd (4 is even, 7 is odd, 10 is even, 13 is odd, and so on).
            Console.WriteLine("1F");

            counter = 0;
            while (counter < repeat)
            {
                int result = counter * stepNumber + startNumber;
                bool isEven = result % 2 == 0;
                string presentation;

                if (isEven)
                {
                    presentation = result + " er et lige tal.";
                }
                else
                {
                    presentation = result + " er et ulige tal.";
                }

                Console.WriteLine(presentation);
                counter += 1;
            }

            // EXERCISE 2

            // The local scouts puts their members in a certain group, depending on their age.
            // 0 - 5 years: haletudser
            // 6 - 7 years: bævere
            // 8 - 10: ulveunger
            // 11 - 14: tropspejdere
            // 15 - 16: seniorspejdere
            // 17 - (no limit): klanspejdere

            int age = 9;
            string group = "(No group yet)";
            bool isScoutLeader = true;

            // 1A. Construct an if / else if / else statement that assigns the group depending on the age.
            // 1B. However, if you are a scout leader, you will always be assigned to the "Ledere" group, no matter what your age is.
            // 1C. But they do require that you are at least 15 years of age to become a leader, so if you are less than 15 and a leader, we should write an error.

            if (isScoutLeader)
            {
                if (age < 15)
                {
                    Console.WriteLine("Der er noget galt. Du er leder, men under 15.");
                    group = "UGYLDIG";
                }
                else
                {
                    group = "Ledere";
                }
            }
            else if (age <= 5)
            {
                group = "Haletudser";
            }
            else if (age >= 6 && age <= 7)
            {
                group = "Bævere";
            }
            else if (age >= 8 && age <= 10)
            {
                group = "Ulveunger";
            }
            else if (age >= 11 && age <= 14)
            {
                group = "Tropspejdere";
            }
            else if (age >= 15 && age <= 16)
            {
                group = "Seniorspejdere";
            }
            else
            {
                group = "Klanspejdere";
            }

            Console.WriteLine(group);

            Console.ReadKey();
        }
    }
}