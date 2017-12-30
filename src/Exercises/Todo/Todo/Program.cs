using System;
using System.Collections.Generic;

namespace Todo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userTodo = new List<string>()
            {

            };

            Console.WriteLine("Tillykke! Du har ingen opgaver");
            Console.WriteLine("Tilføj ny opgave:");
            string userAssignment = Console.ReadLine();

            userTodo.Add(userAssignment);
        

            Console.WriteLine("Du har " + userTodo.Count + " opgaver på din liste.");

            Console.WriteLine("- " + userTodo[0]);



            Console.ReadKey();



        }
    }
}
