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
            int hoCount = 5;
            
            // Vi ønsker at udskrive en julehilsen til konsollen, således at den indledende latter 
            //tilsvarer den værdi, vi har sat i hoCount.Hvis vi sætter hoCount til 3, skal beskeden være:

            int counter = 0;

            //Til afslutning vil vi gerne have det til at stå helt rigtigt, for der skal jo bindestreg mellem de enkelte "ho", men ikke før eller efter:
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


            //while (counter < hoCount)
            //{
            //    counter = counter + 1;

            //    Console.Write(laugh.ToUpper() + hyphen) ;

            //    //if (laugh.EndsWith("O") || laugh.StartsWith("H"));
            //    {
            //        //Console.Write("-");

            //    }



            //}
            //Console.Write(greeting.ToUpper() + exclamation);
            //Console.ReadKey();
        }
    }
}
