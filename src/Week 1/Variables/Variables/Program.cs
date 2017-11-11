using System;
using System.Security.Cryptography.X509Certificates;

namespace Variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            // RunBasicVariablesExample();
            // RunInferenceExample();
            RunUpdateExample();

            Console.ReadKey();
        }

        private static void RunBasicVariablesExample()
        {
            // Let it be known that there is a text called 'name', and the contents of that text is 'Kristian'
            // declaration and assignment (initialization)
            // type variableName = expression;
            string name = "Kristian";

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
            int fingersOnBothHands = 2 * fingersOnOneHand;
            Console.WriteLine("There are " + fingersOnBothHands + " fingers on a pair of hands.");


            // declaration without assignment. Will resolve to the default value of the type (for int, that is 0).
            int peopleInParliament;

            int danishMembersOfParliament = 175;
            int greenlandMembersOfParliament = 2;
            int faeroeMembersOfParliament = 2;

            // assignment after declaration
            peopleInParliament = danishMembersOfParliament + greenlandMembersOfParliament + faeroeMembersOfParliament;

            string summary = "There are " + peopleInParliament + " in parliament.";

            Console.WriteLine(summary);
        }

        private static void RunInferenceExample()
        {
            // the type is inferred from the initial assignment
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

            // Shorthand way of self-referencing:

            x = 10;
            x += 3;

            Console.WriteLine("x (6): " + x);

            y = 5;
            y -= 2;

            Console.WriteLine("y (7): " + y);

            x = y * z + 5;

            // QUESTION: What do you think the value of x is at this point?

            // CODE SMELL: reusing a variable from an earlier context just to save declaring a new one.
            // CODE SMELL: variable names that do not indicate their role in the context.



            // x was declared in this scope. Once we leave this scope, x ceases to exist. The same goes for 
            // y and z.
        }
    }
}
