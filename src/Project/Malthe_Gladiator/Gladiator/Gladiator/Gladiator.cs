﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    class Gladiator
    {
        public string Name { get; private set; }

        public int AttackScore { get; private set; }
        public int DefenseScore { get; private set; }
        public int HitPoints { get; private set; }

        public Gladiator(string name)
        {
            Name = name;

            var cup = new DiceCup();
            cup.Add(2, 6);
            cup.Roll();
            AttackScore = cup.Sum();
            cup.Roll();
            DefenseScore = cup.Sum();

            HitPoints = 10;
        }
        public void PresentYourself()
        {
            if (!IsAlive())
            {
                Console.WriteLine($"*{Name} is coughing up blood*");
                return;
            }

            var presentation = $"My name is {Name}, I am a mighty warrior " +
                               $"with attack {AttackScore} and defense {DefenseScore}. " +
                               $"I have {HitPoints} hit points.";
            Console.WriteLine(presentation);
        }

        public bool IsAlive()
        {
            return HitPoints > 0;
        }

        public void Attack(Gladiator enemy)
        {
            var attackRoll = CombatRoll(AttackScore);
            var enemyDefenceRoll = enemy.CombatRoll(enemy.DefenseScore);

            if (attackRoll > enemyDefenceRoll)
            {
                var damage = attackRoll - enemyDefenceRoll;
                enemy.HitPoints -= damage;

                Console.WriteLine(
                   $"I rolled {attackRoll} against enemys {enemyDefenceRoll}, " + $"resulting in {damage}.");
            }
            else
            {
                Console.WriteLine($"I missed with {attackRoll} against enemys {enemyDefenceRoll}");
            }

        }

        public int CombatRoll(int Score)
        {
            var cup = new DiceCup();
            cup.Add(1, 10);
            cup.Roll();
            return cup.Sum() + Score;
        }

        
    }



    

}
