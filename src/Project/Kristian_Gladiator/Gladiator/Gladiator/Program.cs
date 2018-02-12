using System;

namespace Gladiator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstwarrior = new Gladiator("Spartacus");
            var secondwarrior = new Gladiator("Maximus");

            var combatController = new CombatController();
            combatController.Fight(firstwarrior, secondwarrior);
            
            Console.ReadKey();
        }
    }
}
