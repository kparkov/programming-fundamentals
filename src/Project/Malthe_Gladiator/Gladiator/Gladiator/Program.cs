using System;

namespace Gladiator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstwarrior = new Gladiator("Skvat");
            var secondwarrior = new Gladiator("Svækling");

            firstwarrior.PresentYourself();
            secondwarrior.PresentYourself();

            while (secondwarrior.IsAlive())
            {
                firstwarrior.Attack(secondwarrior);
                secondwarrior.PresentYourself();
            }
            firstwarrior.Attack(secondwarrior);

            

            Console.ReadKey();
        }
    }
}
