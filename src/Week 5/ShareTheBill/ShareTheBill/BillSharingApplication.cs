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
                "Ronald"
            };

            var username = AskUserForText("Hvad er dit navn");

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
            Console.Write(question + "? ");
            string answer = Console.ReadLine();
            return answer;
        }

        /// <summary>
        /// This method asks the user a question, and returns the answer as a decimal.
        /// </summary>
        /// <param name="question">The question to ask</param>
        /// <returns>The user answer as a decimal</returns>
        private decimal AskUserForDecimal(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            decimal newAnswer = decimal.Parse(answer);
            return newAnswer;         

        }

        /// <summary>
        /// Given a list of people and the total price,
        /// </summary>
        /// <param name="people">The list of people</param>
        /// <param name="total">The total price</param>
        /// <returns>The price per person</returns>
        private decimal PricePerPerson(List<string> people, decimal total)
        {
            return (total / people.Count);   
        }

        /// <summary>
        /// Will show a line for each person, showing their name and what they owe.
        /// </summary>
        /// <param name="people">A list of people</param>
        /// <param name="dinnerPrice">The price </param>
        /// <param name="pricePerPerson"></param>
        private void ShowPriceTable(List<string> people, decimal dinnerPrice, decimal pricePerPerson)
        {
            foreach (string person in people)
            {
                Console.WriteLine(person + " should pay " + pricePerPerson);
            }
        }
    }
}