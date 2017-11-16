using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            RunForLoopExample();

            Console.ReadKey();
        }

        private static void RunForLoopExample()
        {
            // for (initialization; condition; update)

            // initialization: "Let it be known that we start with i with value 1" 
            // condition: "and that we keep on going as long as i is less than or equal to 10"
            // update: "and that we should add 1 to i just before we check the condition and go again"

            for (int i = 1; i <= 10; i += 1)
            {
                Console.WriteLine($"Number of times this line was visited: {i}");
            }

            // initialization: "Let it be known that we start with i with value 135"
            // condition: "and that keep on going as long as i is greater than 0"
            // update: "and that we should subtract 5 from i just before we check the condition and go again"

            for (int i = 135; i > 0; i = i - 5)
            {
                Console.WriteLine($"The value of i is {i}.");
            }

            // QUESTION: What is the last outputted line of the above loop, and why?

            // we are not required to supply any of the parameters. With no parameters, it runs indefinitely:
            // for (;;) Console.WriteLine("Loop madness!");

            // we are not required to refer to the same variable. Any initialization goes. Any boolean expression goes. Any update goes.
            // Atypical loops like the following are rare, but they are good study examples.

            string result = "";
            int shouts = 0;
            string name;

            for (name = "Trump!"; shouts < 5; result = result + name + " ")
            {
                shouts += 1;
            }

            // EXERCISE: FOLLOW THE PATH

            // Make a table in Excel or on paper with a column for each variable involved in the above loop (result, shouts, name).
            // The first row represents the initial state upon entering the loop, and every subsequent row represents
            // the state when ending a loop round-trip. Without actually running any code, your task is to determine what 
            // the values of each of the variables are in each row.



        }

        private static void RunWhileLoopExample()
        {
            int i = 0;
            bool continueLooping = true;

            while (continueLooping)
            {
                if (i / )

                i = i + 1;

            }
        }

        private static void RunMultiplicationExercise()
        {
            Console.Write("Write the base number: ");
            int baseNumber = int.Parse(Console.ReadLine().Trim());

            Console.Write("Write the number of entries of the multiplication table to generate: ");
            int numberOfEntries = int.Parse(Console.ReadLine().Trim());

            // EXERCISE: WRITING A MULTIPLICATION TABLE
            // We want to display a multiplication table based on the numbers given above.
            // If the base number is 2, and the number of entries is 3, the result should be:
            // 2
            // 4
            // 6
        }
    }
}
