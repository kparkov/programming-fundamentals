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

            var eventPrice = AskUserForDecimal("Hvad kostede arrangementet");
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
<<<<<<< HEAD
            string answer = Console.ReadLine();
            return answer;
=======
            Blankline();
            string answer = Console.ReadLine();
            return char.ToUpper(answer[0]) + answer.Substring(1);
>>>>>>> 733759023d46e775431aa0560152ed087521ecad
        }

        /// <summary>
        /// This method asks the user a question, and returns the answer as a decimal.
        /// </summary>
        /// <param name="question">The question to ask</param>
        /// <returns>The user answer as a decimal</returns>
        private decimal AskUserForDecimal(string question)
        {
<<<<<<< HEAD
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            decimal newAnswer = decimal.Parse(answer);
            return newAnswer;         

=======
            Blankline();
            Console.Write(question + "? ");
            string newAnswer = Console.ReadLine();
            decimal answer = decimal.Parse(newAnswer);
            return answer;
>>>>>>> 733759023d46e775431aa0560152ed087521ecad
        }

        /// <summary>
        /// Given a list of people and the total price,
        /// </summary>
        /// <param name="people">The list of people</param>
        /// <param name="total">The total price</param>
        /// <returns>The price per person</returns>
        private decimal PricePerPerson(List<string> people, decimal total)
        {
<<<<<<< HEAD
            return (total / people.Count);   
=======
            return (total / people.Count);
>>>>>>> 733759023d46e775431aa0560152ed087521ecad
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
<<<<<<< HEAD
                Console.WriteLine(person + " should pay " + pricePerPerson);
            }
=======
                Blankline();
                Console.WriteLine(person + " skal betale " + pricePerPerson + " kr.");
            }
            return;
        }
        private void Blankline()
        {
            Console.WriteLine("");
>>>>>>> 733759023d46e775431aa0560152ed087521ecad
        }
    }
}