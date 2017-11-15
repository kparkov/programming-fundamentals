using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunListExample();
            RunForEachExample();
            Console.ReadKey();
        }

        public static void RunListExample()
        {
            var names = new List<string> { "Abe", "Putin", "Merkel", "Trump", "Rasmussen" };

            Console.WriteLine(names);

            string firstName = names[0];
            Console.WriteLine($"The first name in the array is {firstName}.");

            string thirdName = names[2];
            Console.WriteLine($"The third name in the array is {thirdName}.");

            int lengthOfList = names.Count;
            Console.WriteLine($"There are {lengthOfList} names in the array.");

            string lastName = names[lengthOfList - 1];
            Console.WriteLine($"The last name in the list is {lastName}.");
        }

        public static void RunForEachExample()
        {
            var numbers = new List<int>() { 12, 45, 88, 23, 3, 9 };
            var sum = 0;

            foreach (var number in numbers)
            {
                sum = sum + number;
            }

            Console.WriteLine(sum);
        }
    }
}
