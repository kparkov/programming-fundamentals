﻿using System;
namespace Gladiator
{
    public class CombatController
    {
        private CombatView View { get; set; }

        public CombatController()
        {
            View = new CombatView();
        }

        public void Fight(Gladiator a, Gladiator b)
        {
            View.GladiatorPresentation(a);
            View.GladiatorPresentation(b);

            var attacker = a;
            var defender = b;

            while (DoContinueFight(a, b))
            {
                System.Threading.Thread.Sleep(500);
                var temp = attacker;
                attacker = defender;
                defender = temp;

                performAttack(attacker, defender);

            }

            View.CombatResult(attacker, defender);

        }

        private bool DoContinueFight(Gladiator a, Gladiator b)
        {
            return a.IsAlive() && b.IsAlive();
        }

        private void performAttack(Gladiator attacker, Gladiator defender)
        {
            var attackRoll = CombatRoll(attacker.AttackScore);
            var enemyDefenceRoll = CombatRoll(defender.DefenseScore);
            var isHit = attackRoll > enemyDefenceRoll;
            var damage = 0;

            if (isHit)
            {
                damage = attackRoll - enemyDefenceRoll;
                defender.HitPoints -= damage;
            }

            View.attackResult(attacker, defender, isHit, damage);

        }

        public int CombatRoll(int score)
        {
            var cup = new DiceCup();
            cup.Add(1, 10);
            cup.Roll();
            return cup.Sum() + score;
        }
    }
}
