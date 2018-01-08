using System;
using System.Collections.Generic;

namespace ShareTheBill
{
    public class BillSharingApplication
    {
        public void Run()
        {
            var people = new List<string>
            {
                "Abraham",
                "Theodore",
                "Ronald",
                "Ole",
                "Joe"
            };

            var username = AskUserForText("Hvad er dit navn?");

            people.Add(username);

            var eventPrice = AskUserForDecimal("Hvad kostede arrangementet?");
            var pricePerPerson = PricePerPerson(people, eventPrice);

            ShowPriceTable(people, eventPrice, pricePerPerson);
        }

        /// <summary>
        /// This method asks the user a question, and returns the answer.
        /// </summary>
        /// <param name="question">The question to ask</param>
        /// <returns>The user answer</returns>

        private string AskUserForText(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        /// <summary>
        /// This method asks the user a question, and returns the answer as a decimal.
        /// </summary>
        /// <param name="question">The question to ask</param>
        /// <returns>The user answer as a decimal</returns>

        private decimal AskUserForDecimal(string question)
        {
            return Decimal.Parse(AskUserForText(question));
        }

        /// <summary>
        /// Given a list of people and the total price,
        /// </summary>
        /// <param name="people">The list of people</param>
        /// <param name="total">The total price</param>
        /// <returns>The price per person</returns>
        private decimal PricePerPerson(List<string> people, decimal total)
        {
            return total / people.Count;
            //throw new NotImplementedException("Denne metode er ikke implementeret.");
        }

        /// <summary>
        /// Will show a line for each person, showing their name and what they owe.
        /// </summary>
        /// <param name="people">A list of people</param>
        /// <param name="dinnerPrice">The price </param>
        /// <param name="pricePerPerson"></param>
        private void ShowPriceTable(List<string> people, decimal dinnerPrice, decimal pricePerPerson)
        {
            Console.WriteLine("Måltidet kostede ialt " + dinnerPrice);
            foreach (string person in people)
            {
                Console.WriteLine("Sir/Madam " + person + " Skal betale " + pricePerPerson);
            }

            //throw new NotImplementedException("Denne metode er ikke implementeret.");
        }
    }
}