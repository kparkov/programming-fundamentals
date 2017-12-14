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

            int counter = 0;

            while (counter < hoCount)
            {
                Console.Write(laugh + " ");
                counter += 1;
            }

            Console.WriteLine(greeting);

            counter = 0;

            while (counter < hoCount)
            {
                Console.Write(laugh.ToUpper() + " ");
                counter += 1;
            }

            Console.WriteLine(greeting.ToUpper() + exclamation);

            counter = 0;

            while (counter < hoCount)
            {
                if (counter != 0)
                {
                    Console.Write(hyphen);
                }

                Console.Write(laugh.ToUpper());

                counter += 1;
            }

            Console.WriteLine((" " + greeting + exclamation).ToUpper());


            Console.ReadKey();
        }
    }
}
