using System;
using System.Linq;

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



            Console.Write(string.Join("", Enumerable.Repeat((laugh.ToUpper() + hyphen.ToUpper()), (hoCount - 1))) + laugh.ToUpper() + " " + greeting.ToUpper() + exclamation);
            Console.ReadKey();
        }


    }
}
