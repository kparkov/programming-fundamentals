using System;

namespace MerryChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            string laugh = "ho";
            string hyphen = "-";
            string greeting = "Merry christmas";
            string exclamation = "!";
            int hoCount = 3;


            //### Opgave 1:
            while (hoCount > 0)
            {
                Console.Write(laugh + " ");
                hoCount--;
            }
            Console.WriteLine(greeting);
            hoCount = 3;


            //### Opgave 2
            while (hoCount > 0)
            {
                Console.Write(laugh.ToUpper() + " ");
                hoCount--;
            }
            Console.WriteLine(greeting.ToUpper() + exclamation);
            hoCount = 3;


            //### Opgave 3
            while (hoCount > 0)
            {
                Console.Write(laugh.ToUpper());
                hoCount--;
                if (hoCount >= 1)
                {
                    Console.Write(hyphen);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine(greeting.ToUpper() + exclamation);
            hoCount = 3;
        }
    }
}
