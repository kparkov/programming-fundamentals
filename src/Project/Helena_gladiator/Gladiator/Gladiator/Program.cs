using System;

namespace Gladiator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstwarrior = new Gladiator("Spartacus");
            var secondwarrior = new Gladiator("Maximus");

            firstwarrior.PresentYourself();
            secondwarrior.PresentYourself();

            while (secondwarrior.IsAlive())
            {
                firstwarrior.Attack(secondwarrior);
                secondwarrior.PresentYourself();
            }

            firstwarrior.Attack(secondwarrior);

            firstwarrior.PresentYourself();
            secondwarrior.PresentYourself();




            Console.ReadKey();
        }
    }
}
