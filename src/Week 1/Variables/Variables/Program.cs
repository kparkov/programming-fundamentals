using System;

namespace Variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            RunBasicVariablesExample();
            // RunInferenceExample();
            // RunMathOperatorsExample();
            // RunUpdateExample();
            // RunExercise();

            Console.ReadKey();
        }

        private static void RunBasicVariablesExample()
        {
            // Let it be known that there is a text placeholder called 'president', and the contents of that placeholder is 'Trump'
            // declaration and assignment (initialization)
            // type variableName = expression;
            string president = "Trump";

            Console.WriteLine("The current president is " + president + ".");

            // int: whole, signed number (-4, 3, 10, 100)
            int numberOfBirdsOnTheRoof = 10;

            // bool: true or false
            bool isBetterThanOneInTheHand = false;

            // double: floating point values (use in science)
            double pi = 3.1415;

            // decimal: fixed point values (use in financial)
            decimal cost = 299.75m;

            // DEFINITION OF "Expression": a combination of values and operators that can be evaluated to a single value.

            // An expression can be a calculation
            int fingersOnOneHand = 1 + 1 + 1 + 1 + 1;
            int numberOfHands = 2;
            int fingersOnBothHands = numberOfHands * fingersOnOneHand;

            // An expression can be a string concatenation
            string fingerSummary = "There are " + fingersOnBothHands + " fingers on a pair of hands.";
            Console.WriteLine(fingerSummary);

            // declaration without assignment. Will resolve to the default value of the type (for int, that is 0).
            int peopleInParliament;

            int danishMembersOfParliament = 175;
            int greenlandMembersOfParliament = 2;
            int faeroeMembersOfParliament = 2;

            // assignment after declaration (reassignment)
            peopleInParliament = danishMembersOfParliament + greenlandMembersOfParliament + faeroeMembersOfParliament;

            string summary = "There are " + peopleInParliament + " people in parliament.";

            Console.WriteLine(summary);
        }

        private static void RunInferenceExample()
        {
            // the type is inferred from the initial assignment when we prefix with var
            var diameter = 10;
            var pi = 3.1415;
            var president = "Trump";
            var doAndroidsDreamOfElectricSheep = true;

            // mixing types are possible when there is a reasonable common type to fall back to (int * double = double)
            var circumference = diameter * pi;

            // if you want to clarify an ambigious assignment, either prefix with the type...
            double diameter2 = 10;

            // ...or use the special numeric suffix:
            var diameter3 = 10d;
        }

        private static void RunMathOperatorsExample()
        {
            double x;

            // PLUS
            x = 10 + 5;

            x = 10;
            x += 5;

            Console.WriteLine("10 + 5 = " + x);

            // MINUS
            x = 10 - 5;

            x = 10;
            x -= 5;

            Console.WriteLine("10 - 5 = " + x);

            // MULTIPLICATION
            x = 10 * 5;

            x = 10;
            x *= 5;

            Console.WriteLine("10 * 5 = " + x);

            // DIVISION
            x = 10 / 5;

            x = 10;
            x /= 5;

            Console.WriteLine("10 / 5 = " + x);

            // MODULO (return the remainder after a division)
            x = 10 % 4;

            x = 10;
            x %= 4;

            Console.WriteLine("10 % 4 = " + x);
        }

        private static void RunUpdateExample()
        {
            // A variable can be declared only once in the same scope:
            var x = 1;
            // var x = 20;

            Console.WriteLine("x (1): " + x);

            // But we can reassign it anytime we like (like declaration, just omitting the type):
            x = 2;

            Console.WriteLine("x (2): " + x);

            // x MUST keep its type throughout its life. We can NEVER assign something that does not (implicitly) conform to its type:
            // x = "Test"

            // And we can perform operations on it during reassignment:
            x = 4 * 5;

            Console.WriteLine("x (3): " + x);

            // We can reference other variables while reassigning it:
            int y = 4;
            int z = 5;

            x = y * z + 5;

            // QUESTION: What do you think the value of x is at this point?

            x = y * (z + 5) + 2;

            // QUESTION: What do you think the value of x is at this point?

            var a = "The answer is " + x + ", but what is the question?";

            // QUESTION: What do you think the value of a is?
            // QUESTION: Why did we need the 'a' variable instead of reusing the 'x' variable for this assignment?

            // We can reference the variable itself during reassignment:

            x = 10;
            x = x + 3;

            Console.WriteLine("x (4): " + x);

            x = 3;
            x = x * x;

            Console.WriteLine("x (5): " + x);

            // Shorthand way of self-referencing: (x = x + 3) = (x += 3)

            x = 10;
            x += 3;

            Console.WriteLine("x (6): " + x);

            y = 5;
            y -= 2;

            Console.WriteLine("y (7): " + y);

            x = y * z + 5;

            // QUESTION: What do you think the value of x is at this point?

            // CODE SMELL: reusing a variable from an earlier context in a new meaning just to save declaring a new one.
            // CODE SMELL: variable names that do not indicate their role in the context.

            // todo: x++
            // todo: string concatenation

            // Shorthand way of incrementing and decrementing: (x = x + 1) = (x++)

            x = 10;
            x++;

            Console.WriteLine("x (8): " + x);

            // x was declared in this scope. Once we leave this scope, x ceases to exist. The same goes for 
            // y and z.
        }

        private static void RunExercise()
        {
            // EXERCISE: WORKING WITH VARIABLES
            // The actual values of the variables in these exercises are not important, although doing realistic estimates will
            // make the results easier to read. Focus on the types chosen, variable names, the relation 
            // between variables and how you output it.

            // PART 1
            // Declare a variable that contains your name.
            // Declare a variable that presents yourself, referencing the variable above: "Hi, my name is (my name)".
            // Think about how you name the variables.
            // Write the presentation to the Console.

            // PART 2
            // Declare a variable with the name of a movie you want to see at the cinema.
            // Declare a variable containing whether the movie is a Danish movie.
            // Declare a variable containing the estimated price for the movie ticket.
            // Declare a variable containing the estimated price for a beverage.
            // Declare a variable containing the estimated price for popcorn.
            // Declare a variable containing the total cost of going to see the movie.
            // Write to the console: the name of the movie, whether it is Danish and the total estimated cost of your visit.

            // PART 3
            // Let's pretend that your estimates above are an average for everyone in the audience.
            // Declare a variable containing the estimated number of seats in the movie theater showing the picture.
            // Declare a variable containing the expected average ratio of seats taken during a screening. (Example: 0.75 = 75% of seats sold on average)
            // Declare a variable containing the expected number of seats sold for this screening.
            // Declare a variable containing the expected cost for the cinema to do a single screening.
            // Declare a variable containing the total revenue of this screening for the cinema.
            // Present the calculation and results in the Console. Put some energy into formatting, so it is easy to read and understand.

            // PART 4
            // Update the value of the expected cost for the cinema (not by changing it above, but by re-assigning it below this line).
            // Output the value of the expected revenue again (below this line).
            // Is the behaviour / result what you expected?
        }
    }
}
