﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    class Gladiator
    {
        public int AttackScore { get; private set; }
        public int DefenceScore { get; private set; }
        public int HitPoints { get; private set; }

        public string Name { get; private set; }

        public Gladiator(string name)
        {
            Name = name;

            var cup = new DiceCup();
            cup.Add(2, 6);
            cup.Roll();
            AttackScore = cup.Sum();
            cup.Roll();
            DefenceScore = cup.Sum();

            HitPoints = 10;
        }

        public void PresentYourself()
        {
            if (!IsAlive())
            {
                Console.WriteLine($"{Name} is coughing up blood. ");
                return;
            }
            var presentation = $"My name is {Name}, I am a mighty warrior " +
                               $"with attack {AttackScore} and defence {DefenceScore}. " +
                               $"I have {HitPoints} hitpoints.";
            Console.WriteLine(presentation);
        }

        public bool IsAlive()
        {
            return HitPoints > 0;
        }

        public void Attack(Gladiator enemy)
        {
            var attackRoll = CombatRoll(AttackScore);
            var enemyDefenceRoll = enemy.CombatRoll(enemy.DefenceScore);

            if (attackRoll > enemyDefenceRoll)
            {
                var damage = attackRoll - enemyDefenceRoll;
                enemy.HitPoints -= damage;

                Console.WriteLine(
                    $"I rolled {attackRoll} against enemys {enemyDefenceRoll}, resulting in {damage} damage."
                    );
            }
            else
            {
                Console.WriteLine($"I missed with {attackRoll} against enemys {enemyDefenceRoll}");
            }
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
