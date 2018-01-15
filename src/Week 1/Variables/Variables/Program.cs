using System;

namespace Variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            //RunBasicVariablesExample();
            // RunInferenceExample();
            // RunMathOperatorsExample();
            // RunBooleanOperatorsExample();
            // RunUpdateExample();
            // RunExercises();
             RunExtendedExercises();

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

            string firstname = "Helena";

            Console.WriteLine("My name is " + firstname + " ");

            // Declare a variable with your birthyear.

            int Birthyear = 1986;

            Console.WriteLine("My name is " + firstname + " and I was born in " + Birthyear + ".");

            // Declare a variable with your town of birth.

            string Birthtown = "Kgs. Lyngby";

            Console.WriteLine("My name is " + firstname + " and I was born in " + Birthyear + ". " + "I was raised in " + Birthtown);

            // Declare a variable that presents yourself, referencing the variable above: "Hi, my name is (my name), I was born ... in ...".

            String presentation = "Hi, my name is " + firstname + ", I was born in " + Birthyear + " in " + Birthtown;

                Console.WriteLine(presentation);

            // Think about how you name the variables.
            // Write the presentation to the Console.

            int currentYear = DateTime.Now.Year;

            // The above variable holds the present year.
            // You have either had a birthday this year or not, which means you could be two different years of age right now.
            // Declare a variable for the max and min amount of years you could be, and let each be an expression referencing the
            // variables above.

            int age = currentYear - Birthyear;
            String agepresentation = "If already birthday, then I am " + age + " , if not then " + (age - 1);
            Console.WriteLine(agepresentation);

            //ellers

            int minage = age - 1;



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

            int kids = 7;

            // Two of them have 20 kroner, three have 45 kroner, one has 13.75 kroner, and the last one has 4.50 kroner.
            // Generously of some, they decide to pool all of their money together. What is the sum?

            decimal kidA = 20.0m;
            decimal kidB = 45.0m;
            decimal kidC = 13.75m;
            decimal kidD = 4.50m;

           decimal sumkids= (2 * kidA) + (3 * kidB) + kidC + kidD;

            Console.WriteLine(sumkids);



            // A donut costs 15 kroner. They decide to buy as many donuts as they can for the sum. 

            decimal donuts = sumkids % 15;

            decimal howmany = (sumkids - donuts)/15;

            Console.WriteLine(howmany);

            // Given that no baker is willing to sell half a donut, how many whole donuts can they buy? (careful: this is tricky!)



            // They then decide to divide the donuts equally, potentially slicing individual donuts into smaller bits. 

            decimal eating = howmany / 7;

            
            // How many do each kid get?

            Console.WriteLine(eating);
            // What amount of money do they have left after buying the donuts?

            Console.WriteLine(donuts);

            Console.WriteLine("The 7 kids have " + sumkids + " kroner. " + "A donut costs 15kr, so they can buy " + howmany + " donuts. Each kid can eat " + eating + " donuts, and they have " + donuts + "kr left." );
        }

        private static void RunBooleanOperatorsExample()
        {
            int age = 16;
            decimal money = 20;

            bool isChild = age < 18;
            bool isAdult = !isChild;
            bool isRetirementAge = age >= 65;
            bool isWorkingAge = isAdult && !isRetirementAge;

            bool getsDiscountInTheBus = isChild || isRetirementAge;
            bool getsDiscountInTheBus2 = age < 18 || age >= 65;

            bool isTwenty = age == 20;
            bool isDifferentFromTwenty = age != 20;

            decimal ticketPrice = 25;
            decimal reducedTicketPrice = 15;

            bool canRideTheBus = money >= ticketPrice || (getsDiscountInTheBus && money >= reducedTicketPrice);

            // EXERCISE: 

            int customerAge = 12;
            int customerHeight = 152;
            int customerWeight = 49;

            // The three variables above are the metrics of a customer.
            // Write tests for the following fictitious Tivoli entry requirements:

            // To try Grøften, you must be at least 3 years old and weigh between 5 and 600 kg.
            bool canTryGrøften = customerAge >= 3 && customerWeight >= 5 && customerWeight <= 600;

            // To try Mariehønen, you must be at least 5 years old.
            // To try Veteranbilerne, you must be at least 1 year old and at least 60 cm tall.
            // To try Ballongyngerne, you must be at least 80 cm tall and must not weigh more than 170 kg.
            // To try Rutsjebanen, you must not be more than 210 cm or weigh more than 190 kg.
            // To try Dæmonen, you must be at least 16 years old and less than 80 years old - but no matter what you cannot be taller than 210 or weigh more than 150
            // To try Kaoshuset, you cannot be exactly 100 years old, and you must either weigh between 40 and 60 or between 90 and 110.
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

        private static void RunExercises()
        {
            // EXERCISE: WORKING WITH VARIABLES
            // The actual values of the variables in these exercises are not important, although doing realistic estimates will
            // make the results easier to read. Focus on the types chosen, variable names, the relation 
            // between variables and how you output it.

            // PART 1
            // Declare a variable with the name of a movie you want to see at the cinema.

            string movieAtCinema = "Daddy's home 2";
            // Declare a variable containing whether the movie is a Danish movie.

            int danish = 1;
            int foreign = 2;

            bool isDanish = danish <2;
            bool isNotDanish = !isDanish;

           
            // Declare a variable containing the estimated price for the movie ticket.

            decimal priceOfCinemaTicket = 95.00m;
            // Declare a variable containing the estimated price for a beverage.

            decimal priceOfBeverage = 40.00m;
            // Declare a variable containing the estimated price for popcorn.

            decimal priceOfPopcorn = 35.00m;
            // Declare a variable containing the total cost of going to see the movie.


            decimal sumSpendInCinema = priceOfCinemaTicket + priceOfBeverage + priceOfPopcorn;
            // Write to the console: the name of the movie, whether it is Danish and the total estimated cost of your visit.

            String cinema = "The movie I want to see is " + movieAtCinema + ". Is it a danish movie " + danishMovie + ". The total cost at the cinema including ticket, beverage and popcorn is " + sumSpendInCinema + "kr.";

            Console.WriteLine(cinema);

            // PART 2
            // Let's pretend that your estimates above are an average for everyone in the audience.
            // Declare a variable containing the estimated number of seats in the movie theater showing the picture.
            // Declare a variable containing the expected average ratio of seats taken during a screening. (Example: 0.75 = 75% of seats sold on average)
            // Declare a variable containing the expected number of seats sold for this screening.
            // Declare a variable containing the expected cost for the cinema to do a single screening.
            // Declare a variable containing the total revenue of this screening for the cinema.
            // Present the calculation and results in the Console. Put some energy into formatting, so it is easy to read and understand.

            // PART 3
            // Update the value of the expected cost for the cinema (not by changing it above, but by re-assigning it below this line).
            // Output the value of the expected revenue again (below this line).
            // Is the behaviour / result what you expected?
        }
    }
}
