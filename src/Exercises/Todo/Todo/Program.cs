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


            Console.WriteLine("Skriv 'V' for vis liste, eller'T' for ny Todo:");

            string visListe = Console.ReadLine();

            if (Console.ReadLine() == visListe);
            {
                //foreach assignment in userTodo
                Console.WriteLine();

            }

            while (true)
            {
               
               

                if(userTodo.Count > 0)
                {
                    Console.WriteLine("Du har " + userTodo.Count + " opgaver på din liste.");
                    Console.WriteLine(string.Empty);
                }

                else
                {
                    Console.WriteLine("Tillykke! Du har ingen opgaver");
                }

                foreach ( string assignment in userTodo)
                {
                    Console.WriteLine("-" + assignment);
                    Console.WriteLine(string.Empty);
                }
                Console.Write("Tilføj ny opgave:");
                userTodo.Add(Console.ReadLine());
            };



            Console.ReadKey();



        }
    }
}
