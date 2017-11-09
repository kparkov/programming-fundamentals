using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            


            // Boolean expressions: tests that will resolve to either true or false
            int age = 20;
            bool isTwenty = age == 20; // Equality comparison
            bool isChild = age < 18; // Exclusive less than
            bool isAdult = age >= 18; // Inclusive greater than
            bool isNotHundred = age != 100; // Does not equal

            decimal money = 60.00m;
            decimal beerPrice = 40.00m;
            decimal cocktailPrice = 120.00m;

            bool isAllowedToDrinkAlcohol = age >= 18;
            bool canAffordBeer = money >= beerPrice;

            bool canBuyCocktail = isAllowedToDrinkAlcohol && canAffordBeer;
        }
    }
}
