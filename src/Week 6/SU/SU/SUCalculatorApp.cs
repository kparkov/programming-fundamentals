using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SU
{
    public class SuCalculatorApp
    {
        public void Run()
        {
            var education = AskUserForOptionList("Hvilken type uddannelse skal du starte på?", new List<string>() {"Ungdomsuddannelse", "Videregående uddannelse"});
            var residence = AskUserForOptionList("Er du hjemmeboende eller udeboende?", new List<string>() {"Hjemmeboende", "Udeboende"});
            var age = 0;
            var dispensation = false;

            if (education != 2)
            {
                age = AskUserForRestrictedInt("Hvad er din alder?", 1, 200);
            }

            if (education == 1 && residence == 2 && age < 20)
            {
                dispensation = AskUserForBool("Har du fået dispensation til at få sats som udeboende?");
            }

            var startedBeforeJuly14 = false;

            if (residence == 1)
            {
                startedBeforeJuly14 = AskUserForBool("Startede du før 1. juli 2014?");
            }

            var income = 0;

            if (education == 1)
            {
                income = AskUserForInt("Hvad er dine forældres husstands indkomst?");
            }

            var baseValue = CalculateBase(education, residence, age, startedBeforeJuly14, dispensation);
            var additionalValue = CalculateAddition(residence, income);

            ShowResult(baseValue, additionalValue);

            Console.ReadKey();
        }

        private decimal CalculateBase(int education, int residence, int age, bool start, bool dispensation)
        {
            if (education == 1)
            {
                if (residence == 1)
                {
                    if (start)
                    {
                        if (age < 20) return 1348;
                        return 3028;
                    }

                    return 946;
                }

                if (age < 20)
                {
                    if (dispensation) return 3907;
                    if (start) return 1348;
                    return 3028;
                }
            }

            if (residence == 1)
            {
                if (start) return 3028;
                return 946;
            }

            return 6090;
        }

        private decimal CalculateAddition(int residence, int income)
        {
            if (residence == 2 || income < 100000) return 3000;
            if (income < 300000) return 2000;
            if (income < 500000) return 1000;
            return 0;
        }

        private string AskUserForString(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        private int AskUserForInt(string question)
        {
            int result = 0;

            bool success = false;

            while (!success)
            {
                success = int.TryParse(AskUserForString(question), out result);
                if (!success) Console.WriteLine("Det var ikke et tal! Prøv igen.");
            }

            return result;
        }

        private int AskUserForRestrictedInt(string question, int min, int max)
        {
            int result = min - 1;

            while (result < min || result > max)
            {
                result = AskUserForInt(question);
            }

            return result;
        }

        private bool AskUserForBool(string question)
        {
            while (true)
            {
                string response = AskUserForString(question + " (j/n) ");

                if (!string.IsNullOrEmpty(response))
                {
                    string firstLetterLower = response.ToLower().Substring(0, 1);

                    if (firstLetterLower == "j")
                    {
                        return true;
                    }

                    if (firstLetterLower == "n")
                    {
                        return false;
                    }
                }
                
            }
        }

        private int AskUserForOptionList(string question, List<string> options)
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine(question);
            Console.WriteLine(string.Empty);

            int counter = 0;

            while (counter < options.Count)
            {
                Console.WriteLine(((counter + 1) + ".").PadRight(3) + options[counter]);
                counter += 1;
            }

            Console.WriteLine(string.Empty);
            return AskUserForRestrictedInt("Dit valg: ", 1, options.Count);
        }

        private void ShowResult(decimal baseValue, decimal additionalValue)
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("Grundsats:          " + baseValue.ToString("C").PadLeft(10));
            Console.WriteLine("Tillægsydelse:      " + additionalValue.ToString("C").PadLeft(10));
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Total:              " + (baseValue + additionalValue).ToString("C").PadLeft(10));
        }
    }
}
