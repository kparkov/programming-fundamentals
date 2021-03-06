﻿using System;

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
            // 1B. Modify the outputted line so it writes the number of times the loop has been running on screen (1, 2, 3, 4, and so on).
            // 1C. Modify the numbering, so it begins counting from "startNumber", and still adds 1 each time (4, 5, 6, 7, and so on). It should still run "repeat" TIMES in total. 
            // 1D. Modify the numbering, so it adds "stepNumber" instead of 1 each time (4, 7, 10, 13, and so on).
            // 1E. Your solution should use the variables above, and if their values are changed, it should be reflected when we run the loop. It should have no fixed upper limits for repeat.
            // 1F. In addition to writing the current number, also write whether that number is even or odd (4 is even, 7 is odd, 10 is even, 13 is odd, and so on).

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

            Console.WriteLine(group);
            Console.ReadKey();
        }
    }
}