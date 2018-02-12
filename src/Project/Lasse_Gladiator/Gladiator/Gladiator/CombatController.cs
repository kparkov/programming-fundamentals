using Gladiator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Gladiator
{
    class CombatController
    {
        private CombatView View { get; set; }

        public CombatController()
        {
            View = new CombatView();
        }

        public CombatResult Fight(Gladiator a, Gladiator b)
        {
            View.GladiatorPresentation(a);
            View.GladiatorPresentation(b);

            var attacker = a;
            var defender = b;

            while (DoContinueFight(a, b)) 
            {
                Thread.Sleep(500);

                var temp = attacker;
                attacker = defender;
                defender = temp;

                PerformAttack(attacker, defender);
            }

            View.CombatResult(attacker, defender);

            return new CombatResult()
            {
                Winner = attacker,
                Loser = defender

            };
        }


        private bool DoContinueFight(Gladiator a, Gladiator b)
        {
            return a.IsAlive() && b.IsAlive();
        }

     

        private void PerformAttack(Gladiator attacker, Gladiator defender)
         
        {
            var attackRoll = CombatRoll(attacker.AttackScore);
            var enemyDefenceRoll = CombatRoll(defender.DefenceScore);
            var isHit = attackRoll > enemyDefenceRoll;
            var damage = 0;

            if (isHit)
            {
                damage = attackRoll - enemyDefenceRoll;
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
