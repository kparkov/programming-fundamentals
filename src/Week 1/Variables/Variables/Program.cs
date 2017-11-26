using System;

namespace Variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            RunBasicVariablesExample();
            RunMathOperatorsExample();
            RunExercises();

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

            // EXERCISE: BASIC VARIABLE DECLARATION

            // Declare a variable that contains your name.
            string name = "Kristian";

            // Declare a variable with your birthyear.
            int birthyear = 1980;

            // Declare a variable with your town of birth.
            string city = "København";

            // Declare a variable that presents yourself, referencing the variable above: "Hi, my name is (my name), I was born ... in ...".
            // Think about how you name the variables.
            // Write the presentation to the Console.

            string presentation = "Hi, my name is " + name + ". I was born in " + city + " in " + birthyear + ".";

            Console.WriteLine(presentation);

            int currentYear = DateTime.Now.Year;

            // The above variable holds the present year.
            // You have either had a birthday this year or not, which means you could be two different years of age right now.
            // Declare a variable for the max and min amount of years you could be, and let each be an expression referencing the
            // variables above.

            int maxAge = currentYear - birthyear;
            int minAge = maxAge - 1;

            Console.WriteLine("I am either " + minAge + " or " + maxAge + " years old.");
        }

        private static void RunMathOperatorsExample()
        {
            decimal x;

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

            // PARENTHESIS AND PRECEDENCE AS USUAL

            x = 10 + 4 * 2;
            Console.WriteLine("10 + 4 * 2 = " + x);

            x = (10 + 4) * 2;
            Console.WriteLine("(10 + 4) * 2 = " + x);

            // EXERCISE: MATH OPERATORS

            // Declare a variable representing each of the steps in the following story, when it makes sense. Make sure you think about the type
            // and name of each declared variable. Let the assigned value be a literal value or an expression referring the earlier
            // variables, depending on what makes sense. Retain as much information as possible in the expression to make it easier to read.

            // There is a group of 7 kids.

            int numberOfKids = 7;

            // Two of them have 20 kroner, three have 45 kroner, one has 13.75 kroner, and the last one has 4.50 kroner.
            // Generously of some, they decide to pool all of their money together. What is the sum?

            decimal sumOfMoney = 2 * 20 + 3 * 45 + 13.75m + 4.5m;

            Console.WriteLine("Money total: " + sumOfMoney);

            // A donut costs 15 kroner. They decide to buy as many donuts as they can for the sum. 
            // Given that no baker is willing to sell half a donut, how many whole donuts can they buy? (careful: this is tricky!)

            decimal restAfterBuying = sumOfMoney % 15;
            decimal spentOnDonuts = sumOfMoney - restAfterBuying;
            decimal numberOfDonuts = spentOnDonuts / 15;

            Console.WriteLine("They can buy " + numberOfDonuts);

            // They then decide to divide the donuts equally, potentially slicing individual donuts into smaller bits. 
            // How many do each kid get?

            decimal donutsPerKid = numberOfDonuts / numberOfKids;
            Console.WriteLine("Each kid gets " + donutsPerKid + " donuts.");

            // What amount of money do they have left after buying the donuts?

            Console.WriteLine("Money left: " + restAfterBuying);
        }

        private static void RunExercises()
        {
            // EXERCISE: WORKING WITH VARIABLES
            // The actual values of the variables in these exercises are not important, although doing realistic estimates will
            // make the results easier to read. Focus on the types chosen, variable names, the relation 
            // between variables and how you output it.

            // PART 1
            // Declare a variable with the name of a movie you want to see at the cinema.
            string movie = "Blade Runner 2049";

            // Declare a variable containing whether the movie is a Danish movie.
            bool isDanish = false;

            // Declare a variable containing the estimated price for the movie ticket.
            decimal ticketPrice = 110;

            // Declare a variable containing the estimated price for a beverage.
            decimal beveragePrice = 35;

            // Declare a variable containing the estimated price for popcorn.
            decimal popcornPrice = 30;

            // Declare a variable containing the total cost of going to see the movie.
            decimal cinemaTripPrice = ticketPrice + beveragePrice + popcornPrice;

            // Write to the console: the name of the movie, whether it is Danish and the total estimated cost of your visit.
            Console.WriteLine("I want to see " + movie + " (Danish: " + isDanish + "). It is going to cost me " + cinemaTripPrice + "-");

            // PART 2
            // Let's pretend that your estimates above are an average for everyone in the audience.
            // Declare a variable containing the estimated number of seats in the movie theater showing the picture.
            decimal seats = 300;

            // Declare a variable containing the expected average ratio of seats taken during a screening. (Example: 0.75 = 75% of seats sold on average)
            decimal avgRatioSold = 0.7m;

            // Declare a variable containing the expected number of seats sold for this screening.
            decimal expectedNumberSold = seats * avgRatioSold;

            // Declare a variable containing the expected cost for the cinema to do a single screening.
            decimal expectedCost = 18000;

            // Declare a variable containing the total revenue of this screening for the cinema.
            decimal expectedIncome = expectedNumberSold * cinemaTripPrice;
            decimal expectedRevenue = expectedIncome - expectedCost;

            // Present the calculation and results in the Console. Put some energy into formatting, so it is easy to read and understand.
            Console.WriteLine("");
            Console.WriteLine("Revenue of a single screening of " + movie);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Seats in theatre                         " + seats);
            Console.WriteLine("Ratio sold on average                    " + avgRatioSold);
            Console.WriteLine("Expected sold                            " + expectedNumberSold);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Income per customer                      " + cinemaTripPrice);
            Console.WriteLine("Total screening income                   " + expectedIncome);
            Console.WriteLine("Total screening cost                     " + expectedCost);
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Total revenue                            " + expectedRevenue);
            Console.WriteLine("");

            // PART 3
            // Update the value of the expected cost for the cinema (not by changing it above, but by re-assigning it below this line).
            expectedCost = 25000;

            // Output the value of the expected revenue again (below this line).
            Console.WriteLine("The revenue is the same as before, " + expectedRevenue);

            // Is the behaviour / result what you expected?

            // Yes. When expectedRevenue was evaluated, the cost was set at 18.000. The relation is not saved, only the result at the time of
            // evaluation.
        }
    }
}
