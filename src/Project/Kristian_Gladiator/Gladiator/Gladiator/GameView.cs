using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Gladiator
{
    public class GameView
    {
        public void AnnounceFight(Gladiator a, Gladiator b)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"{a.Name} ({a.Victories}) WILL FIGHT {b.Name} ({b.Victories})");
            Console.WriteLine("------------------------------------------------------------");
            C.Wait(500);
        }

        public void CombatResult(Gladiator winner, Gladiator loser, int combatantCount, int graveyardCount)
        {
            var s = new StringBuilder();

            s.Append($"{winner.Name} wins the fight over {loser.Name}");

            if (!loser.IsAlive())
            {
                s.Append($", who has died. He joins {graveyardCount} other poor souls.");
            }
            else
            {
                s.Append(", who conceded.");
            }

            s.Append($" There are still {combatantCount} combatants left.");


            Console.WriteLine(s.ToString());
            C.Wait(1000);
        }

        public void AnnounceWinner(Gladiator winner)
        {
            Console.WriteLine($"THE TOURNAMENT WAS WON BY {winner.Name}.");
        }

        public void AnnounceProgress(Gladiator winner, List<string> result)
        {
            Console.WriteLine($"{winner.Name} got a +1 to the following: {string.Join(", ", result)}");
            C.Wait(300);
        }

        public void Roster(List<Gladiator> combatants, int fights, int graveyard)
        {
            Console.Clear();

            var s = new StringBuilder();

            s.AppendLine($"{combatants.Count} combatants, {fights} fights in, {graveyard} in graveyard.");
            s.AppendLine();

            const int pname = 35;
            const int pvictories = 11;
            const int pstrength = 9;
            const int pattack = 12;
            const int pdefense = 13;
            const int pconstitution = 13;
            const int pmorale = 7;

            s.Append("Name".PadRight(pname));
            s.Append("Victories".PadRight(pvictories));
            s.Append("Strength".PadRight(pstrength));
            s.Append("Attack".PadRight(pattack));
            s.Append("Defense".PadRight(pdefense));
            s.Append("Constitution".PadRight(pconstitution));
            s.Append("Morale".PadRight(pmorale));

            s.AppendLine();

            foreach (var fighter in combatants.OrderByDescending(c => c.Victories).Take(50))
            {
                s.Append(fighter.Name.PadRight(pname));
                s.Append(fighter.Victories.ToString().PadRight(pvictories));
                s.Append(fighter.Strength.ToString().PadRight(pstrength));
                s.Append(fighter.AttackScore.ToString().PadRight(pattack));
                s.Append(fighter.DefenseScore.ToString().PadRight(pdefense));
                s.Append(fighter.Constitution.ToString().PadRight(pconstitution));
                s.Append(fighter.Morale.ToString().PadRight(pmorale));
                s.AppendLine();
            }

            s.AppendLine();
            s.AppendLine();
            s.AppendLine();

            Console.WriteLine(s.ToString());
            //Console.ReadKey();
            C.Wait(300);
        }
    }
}
