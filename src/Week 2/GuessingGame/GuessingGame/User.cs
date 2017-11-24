using System;

namespace GuessingGame
{
    public static class User
    {
        public static int GetGuess()
        {
            bool validGuess = false;

            while (!validGuess)
            {
                Console.Write("Skriv dit gæt: ");
                var s = Console.ReadLine();

                try
                {
                    return int.Parse(s);
                }
                catch
                {
                    Console.WriteLine("Det var ikke et tal. Prøv igen.");
                }
            }

            return 0;
        }
    }
}