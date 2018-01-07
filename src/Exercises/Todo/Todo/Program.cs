using System;
using System.Collections.Generic;

namespace Todo
{
    class Program
    {
        static void Main(string[] args)
        {
            //*** Øvelse 1 ***:
            //string userTask;
            //List<string> listOfUserTasks = new List<string>();

            //Console.WriteLine("Hurra, ingen opgaver!");
            //Console.WriteLine("");
            //Console.WriteLine("Den går naturligvis ikke, så tilføj en opgave herunder:");

            //while(true)
            //{
            //    userTask = Console.ReadLine();
            //    listOfUserTasks.Add(userTask);
            //    Console.WriteLine("Super. Du har nu: "+ listOfUserTasks.Count + " opgaver, som er:");

            //    foreach (string opgave in listOfUserTasks) 
            //    {
            //        Console.WriteLine(" - " + opgave);
            //    }
            //    Console.WriteLine("Ok, skriv en opgave mere:");
            //}

            //*** Øvelse 2+4 ***:
            string userTask;
            string userCommand;
            List<string> listOfUserTasks = new List<string>();

            Console.WriteLine("Velkommen til din ogaveliste. Tast 'N' for at oprette ny opgave, 'V' for at se din liste af opgaver eller 'F' for at fjerne en opgave");

            while (true)
            {
                userCommand = Console.ReadLine().ToUpper();
                if (userCommand.StartsWith("N"))
                {
                    Console.WriteLine("Ok, skriv din nye opgave her:");
                    userTask = Console.ReadLine();
                    listOfUserTasks.Add(userTask);
                    Console.WriteLine("Tjek. Opgaven er tilføjet.");
                    Console.WriteLine("");
                    Console.WriteLine("Tast 'N' for at oprette ny opgave, 'V' for at se din liste af opgaver eller 'F' for at fjerne en opgave");
                }
                else if (userCommand.StartsWith("V"))
                {
                    Console.WriteLine("Du har " + listOfUserTasks.Count + " opgave(r):");

                    foreach (string opgave in listOfUserTasks)
                    {
                        Console.WriteLine(" - " + opgave);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Tast 'N' for at oprette ny opgave, 'V' for at se din liste af opgaver eller 'F' for at fjerne en opgave");
                }
                else if (userCommand.StartsWith("F"))
                {
                    int opgaveNummer = 1;
                    Console.WriteLine("Her er opgaverne. Skriv nummeret på den opgave du ønsker at fjerne:");

                    foreach (string opgave in listOfUserTasks)
                    {
                        
                        Console.WriteLine("[" + opgaveNummer + "]" + " - " + opgave);
                        opgaveNummer++;
                    }
                    int userCommandEraseNumber = int.Parse(Console.ReadLine());
                    listOfUserTasks.RemoveAt(userCommandEraseNumber-1);
                    Console.WriteLine("Tjek. Opgaven er nu fjernet.");

                    Console.WriteLine("");
                    Console.WriteLine("Tast 'N' for at oprette ny opgave, 'V' for at se din liste af opgaver eller 'F' for at fjerne en opgave");
                }
            }


        }
    }
}
