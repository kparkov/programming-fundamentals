using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            RunPublicTransportExample();
            // RunAgeComparisonExample();
            // RunBuyingAlcoholRequirementsExample();

            Console.ReadKey();
        }

        /// <summary>
        /// This example demonstrates conjunctions (AND) and disjunctions (OR) in
        /// boolean expressions.
        /// </summary>
        private static void RunPublicTransportExample()
        {
            bool isRetired = true;
            Console.WriteLine($"Is retired: {isRetired}");

            bool isAtLeast65YearsOld = false;
            Console.WriteLine($"Is over 65: {isAtLeast65YearsOld}");

            bool isVeryRich = true;
            Console.WriteLine($"Is very rich: {isVeryRich}");

            Console.WriteLine($"--- ALL VALUES BELOW THIS LINE ARE DERIVED FROM THE ABOVE --->");

            // Negation
            bool isUnder65 = !isAtLeast65YearsOld;
            Console.WriteLine($"Is under 65: {isUnder65}");

            // AND operator: to get a discount in Denmark, you need to be BOTH retired and over 65
            bool getsDiscountOnPublicTransportInDenmark = isRetired && isAtLeast65YearsOld;
            Console.WriteLine($"Can get a discount in Denmark: {getsDiscountOnPublicTransportInDenmark}");

            // OR operator: to get a discount in Germany, you need to be EITHER retired or over 65
            bool getsDiscountOnPublicTransportInGermany = isRetired || isAtLeast65YearsOld;
            Console.WriteLine($"Can get a discount in Germany: {getsDiscountOnPublicTransportInGermany}");

            // the disjunction of the negations is the negation of the conjunction
            bool getsNoDiscountInDenmark = !isRetired || !isAtLeast65YearsOld;
            bool getsDiscountInDenmark = !getsNoDiscountInDenmark;

            Console.WriteLine($"Does NOT get a discount in Denmark: {getsNoDiscountInDenmark}");

            // EXERCISE: SANITY CHECKING
            // With the above rules, is it possible to get a discount in Denmark 
            // if you are not getting a discount in Germany? 
            // The reasoning behind your answer is what counts.

            bool getsDiscountInEither = getsDiscountOnPublicTransportInDenmark || getsDiscountOnPublicTransportInGermany;
            bool getsNoDiscountsInEither = !getsDiscountOnPublicTransportInDenmark && !getsDiscountOnPublicTransportInGermany;
            bool getsDiscountInJustOneCountry = getsDiscountOnPublicTransportInDenmark != getsDiscountOnPublicTransportInGermany;

            bool willThisBeTrue = !!!!getsDiscountOnPublicTransportInDenmark;

            // EXERCISE: FOLLOW THE WHITE RABBIT
            // Without actually testing the line above, what would you say the value should resolve to, given the unmodified
            // result of getsDiscountOnPublicTransportInDenmark?
            // Argue your case.

            // in Spain, you must be either retired or over 65, but no matter what you cannot be rich if you want the discount
            bool getsDiscountInSpain = isAtLeast65YearsOld || isRetired && !isVeryRich;
            Console.WriteLine($"Gets a discount in Spain: {getsDiscountInSpain}");

            // EXERCISE: TESTING AND REPRODUCTION DESCRIPTION
            // The above expression about Spain is very subtly broken. It does not actually
            // conform to the specification. What is a good strategy for testing the line?
            // The solution to the exercise should be the description of the way you found the problem, 
            // and a description of how the rest of the group can reproduce and confirm the problem. 
            // You are not required to speculate on the causes of the problem.
        }

        private static void RunAgeComparisonExample()
        {
            // Boolean expressions: tests that will resolve to either true or false
            int age = 20;

            // Equality comparisons
            bool isTwenty = age == 20;
            Console.WriteLine($"Is twenty years old: {isTwenty}");

            bool isThirty = age == 30;
            Console.WriteLine($"Is thirty years old: {isThirty}");

            // Exclusive less than
            bool isChild = age < 18; // Exclusive less than
            Console.WriteLine($"Is a child: {isChild}");

            bool isAdult = age >= 18; // Inclusive greater than
            Console.WriteLine($"Is an adult: {isAdult}");

            bool isNotHundred = age != 100; // Does not equal
            Console.WriteLine($"Is not hundred years old: {isNotHundred}");

            // Compound boolean expressions are put together using AND / OR operators
            bool isWorkingAge = age >= 18 && age < 65;
        }

        private static void RunBuyingAlcoholRequirementsExample()
        {
            int age = 20;

            decimal money = 60.00m;
            decimal beerPrice = 40.00m;
            decimal cocktailPrice = 120.00m;

            bool isAllowedToDrinkAlcohol = age >= 18;
            bool canAffordBeer = money >= beerPrice;

            bool canBuyBeerInBar = isAllowedToDrinkAlcohol && canAffordBeer;
            bool canBuyBeerInBar2 = money >= beerPrice && age >= 18;
            bool theTwoExpressionsAgree = canBuyBeerInBar == canBuyBeerInBar2;

            Console.WriteLine($"Can buy beer in the bar: {canBuyBeerInBar}");
            Console.WriteLine($"The two expressions agree: {theTwoExpressionsAgree}");
        }
    }
}
