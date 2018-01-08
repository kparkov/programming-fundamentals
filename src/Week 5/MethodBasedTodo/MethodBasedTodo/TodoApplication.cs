using System;
using System.Collections.Generic;

namespace MethodBasedTodo
{
    public class TodoApplication
    {
        // This starts the todo application
        public void Run()
        {
            bool continueProgram = true;
            List<string> todo = new List<string>();

            while (continueProgram)
            {
                Console.Clear();

                ShowTodoList(todo, false);
                ShowMainMenu(todo);

                string inputCharacter = AskInputCharacter("Valg: ");

                if (inputCharacter == "Q")
                {
                    continueProgram = false;
                }

                if (inputCharacter == "T")
                {
                    AskForNewTodoItem(todo);
                }

                if (inputCharacter == "S" && HasAnyTodoItems(todo))
                {
                    AskDeleteTodoItem(todo);
                }
            }
        }
        /// <summary>
        /// Viser menuen
        /// </summary>
        /// <param name="todo">Tager en liste</param>
        private void ShowMainMenu(List<string> todo)
        {
            BlankLine();
            Console.WriteLine("(T)ilføj opgave");

            if (HasAnyTodoItems(todo))
            {
                Console.WriteLine("(S)let opgave");
            }

            Console.WriteLine("(Q)uit");
            BlankLine();
        }
        /// <summary>
        /// Asks for new todo item.
        /// </summary>
        /// <param name="todo">Todo.</param>
        private void AskForNewTodoItem(List<string> todo)
        {
            Console.Clear();
            string item = AskInputString("Ny opgave:");

            if (!string.IsNullOrWhiteSpace(item))
            {
                todo.Add(item.Trim());
            }
        }

        private void ShowTodoList(List<string> todo, bool showIndexes)
        {
            Console.Clear();

            Console.WriteLine(GetTodoListHeader(todo));

            if (showIndexes)
            {
                int counter = 0;

                while (counter < todo.Count)
                {
                    Console.WriteLine(counter.ToString().PadLeft(4) + ": " + todo[counter]);
                    counter += 1;
                }
            }
            else
            {
                foreach (string item in todo)
                {
                    Console.WriteLine("- " + item);
                }
            }
        }

        private string GetTodoListHeader(List<string> todo)
        {
            if (HasAnyTodoItems(todo))
            {
                string result = "Du har " + todo.Count + " opgave";

                if (todo.Count > 1)
                {
                    result += "r";
                }

                result += ".";

                return result;
            }
            else
            {
                return "Du har ingen opgaver i øjeblikket.";
            }
        }

        private void AskDeleteTodoItem(List<string> todo)
        {
            Console.Clear();

            ShowTodoList(todo, true);
            
            BlankLine();

            var index = AskInputNumber("Fjern opgave:");

            if (index >= 0 && index < todo.Count)
            {
                todo.RemoveAt(index);
            }
        }

        private void BlankLine()
        {
            Console.WriteLine(string.Empty);
        }
        /// <summary>
        /// Printer strengen 'question' og returnere et input
        /// </summary>
        /// <returns>The input string.</returns>
        /// <param name="question">Question.</param>
        private string AskInputString(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Anvender metoden AskInputString() til at spørge efter et tal i
        /// strengen 'question', der returneres ved at parse resultatet som int
        /// </summary>
        /// <returns>Input nummer som int</returns>
        /// <param name="question">Holder et spørgsmål som streng</param>
        private int AskInputNumber(string question)
        {
            var input = AskInputString(question);
            return int.Parse(input);
        }

        private string AskInputCharacter(string question)
        {
            Console.Write(question + " ");
            var input = Console.ReadKey();
            return GetSelectionCharacter(input.KeyChar.ToString());
        }

        private string GetSelectionCharacter(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            return input.Substring(0, 1).ToUpper();
        }
        /// <summary>
        /// Tjekker for hvorvidt todo-listen indeholder noget
        /// </summary>
        /// <returns>True hvis todo indeholder noget, ellers false</returns>
        /// <param name="todo">todo-listen</param>
        private bool HasAnyTodoItems(List<string> todo)
        {
            return todo.Count > 0;
        }
    }
}