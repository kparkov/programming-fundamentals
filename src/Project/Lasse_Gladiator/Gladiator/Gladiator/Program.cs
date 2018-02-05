using System;

namespace Gladiator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstwarrior = new Gladiator("Ibbermand");
            var secondwarrior = new Gladiator("Jørgen");
            var combatController = new CombatController();

            combatController.Fight(firstwarrior, secondwarrior);

      

            Console.ReadKey();
        }
    }
}
