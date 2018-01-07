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

        private string AskInputString(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

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

        private bool HasAnyTodoItems(List<string> todo)
        {
            return todo.Count > 0;
        }
    }
}