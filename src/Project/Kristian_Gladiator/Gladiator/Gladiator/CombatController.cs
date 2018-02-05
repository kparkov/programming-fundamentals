using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gladiator
{
    public class CombatController
    {
        private CombatView View { get; set; }
        private int SuspenseLevel { get; }

        public CombatController()
        {
            View = new CombatView();
            SuspenseLevel = 2000;
        }

        public void Fight(Gladiator a, Gladiator b)
        {
            View.GladiatorPresentation(a);
            View.GladiatorPresentation(b);

            var attacker = a;
            var defender = b;

            while (DoContinueFight(a, b))
            {
                Thread.Sleep(SuspenseLevel);

                var temp = attacker;
                attacker = defender;
                defender = temp;

                PerformAttack(attacker, defender);
            }

            View.CombatResult(attacker, defender);
        }

        private bool DoContinueFight(Gladiator a, Gladiator b)
        {
            return a.IsAlive() && b.IsAlive();
        }

        private void PerformAttack(Gladiator attacker, Gladiator defender)
        {
            var attackRoll = CombatRoll(attacker.AttackScore);
            var enemysDefenseRoll = CombatRoll(defender.DefenseScore);
            var isHit = attackRoll > enemysDefenseRoll;
            var damage = 0;

            if (isHit)
            {
                damage = attackRoll - enemysDefenseRoll;
                defender.HitPoints -= damage;
            }

            View.AttackResult(attacker, defender, isHit, damage);
        }

        private int CombatRoll(int score)
        {
            var cup = new DiceCup();
            cup.Add(1, 10);
            cup.Roll();
            return cup.Sum() + score;
        }
    }
}
