using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration + assignment (initialization)
            // datatype variabelnavn = udtryk (værdi);
            string name = "Kristian";
            
            // int: heltal med fortegn (-4, 3, 10, 100)
            int numberOfBirdsOnTheRoof = 10;

            // bool: true or false
            bool isBetterThanOneInTheHand = false;

            // double: decimaltal med flydende decimaler
            double pi = 3.1415;

            // decimal: decimaltal med fast antal decimaler
            decimal cost = 299.75m;

            int fingersOnOneHand = 1 + 1 + 1 + 1 + 1;
            int fingersOnBothHands = 2 * fingersOnOneHand;

            // declaration (no assignment) -> initialiseres med datatypens "default".
            int peopleInParliament;

            int danishMembersOfParliament = 175;
            int greenlandMembersOfParliament = 2;
            int faeroeMembersOfParliament = 2;
            
            // assignment after declaration
            peopleInParliament = danishMembersOfParliament + greenlandMembersOfParliament + faeroeMembersOfParliament;

            string summary = "Der er " + peopleInParliament + " medlemmer i folketinget.";

            Console.WriteLine(summary);
            Console.ReadKey();

            // type inference
            var age = 37;
            var president = "Trump";
            var doAndroidsDreamOfElectricSheep = true;

        }
    }
}
