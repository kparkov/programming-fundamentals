using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gladiator
{
    public class CombatView
    {
        public void GladiatorPresentation(Gladiator gladiator)
        {

            var presentation = $"My name is {gladiator.Name}, I am a mighty warrior " +
                               $"with attack {gladiator.AttackScore} and defense {gladiator.DefenseScore}. " +
                               $"I have {gladiator.HitPoints()} hit points.";

            Console.WriteLine(presentation);
            C.Wait(600);
        }

        public void AttackResult(Gladiator attacker, Gladiator defender, bool hit, int damage = 0)
        {
            return;
            string result = $"{attacker.Name} attacks {defender.Name}";

            if (hit)
            {
                result += $" and scores a hit for {damage} damage. {defender.Name} now has {defender.HitPoints()} hit points left.";
            }
            else
            {
                result += $" but misses!";
            }

            Console.WriteLine(result);
            C.Wait(100);
        }
    }
}
