﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    class CombatView
    {
        public void GladiatorPresentation(Gladiator gladiator)
        {
            var presentation = $"My name is {gladiator.Name}, I am a mighty warrior " +
                              $"with attack {gladiator.AttackScore} and defence {gladiator.DefenceScore}. " +
                              $"I have {gladiator.HitPoints} hitpoints.";
            Console.WriteLine(presentation);
        }

        public void AttackResult(Gladiator attacker, Gladiator defender, bool hit, int damage = 0)
        {
            string result = $"{attacker.Name} attacks {defender.Name}";

            if (hit)
            {
                result += $" and scores a hit for {damage} damage.  {defender.Name} now has {defender.HitPoints} hitpoints.";
            }
            else
            {
                result += $" but misses!";
            }
            Console.WriteLine(result);
        }

        public void CombatResult(Gladiator winner, Gladiator loser)
        {
            string result = $"{winner.Name} has won the fight over {loser.Name}.";

            if(!loser.IsAlive())
            {
                result += $"{loser.Name} has succumbed to his wounds.";
            }
            Console.WriteLine(result);
        }
    }
}