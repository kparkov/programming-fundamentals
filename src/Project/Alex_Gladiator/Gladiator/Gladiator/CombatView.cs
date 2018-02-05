using System;
namespace Gladiator
{
    public class CombatView
    {
        public CombatView()
        {
        }

        public void GladiatorPresentation(Gladiator gladiator)
        {

            var presentation = $"My name is {gladiator.Name}, I am a mighty warrior " +
                $"with attack {gladiator.AttackScore} and defense {gladiator.DefenseScore}. " +
                $"I have {gladiator.HitPoints} hit points.";

            Console.WriteLine(presentation);
        }

        public void attackResult(Gladiator attacker, Gladiator defender, bool hit, int damage = 0)
        {
            string result = $"{attacker.Name} attacks {defender.Name}";

            if (hit)
            {
                result += $" and scores a hit for {damage} damage. {defender.Name} now has {defender.HitPoints}";
            }

            else 
            {
                result += $" but misses!";
            }

            Console.WriteLine(result);
        }

        public void CombatResult(Gladiator winner, Gladiator loser)
        {
            string result = $"{winner.Name} has won the fight over {loser.Name}";
        

            if (!loser.IsAlive())
            {
                result += $" {loser.Name} has died from his wounds";
            }
            Console.WriteLine(result);
        } 
    }
}
