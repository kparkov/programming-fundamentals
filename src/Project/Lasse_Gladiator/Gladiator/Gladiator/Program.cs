using System;

namespace Gladiator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstwarrior = new Gladiator("Ibbermand");
            var secondwarrior = new Gladiator("Jørgen");
            firstwarrior.PresentYourself();
            secondwarrior.PresentYourself();

            firstwarrior.Attack(secondwarrior);

            secondwarrior.PresentYourself();


            Console.ReadKey();
        }
    }
}
