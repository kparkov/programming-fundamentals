using System;
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
            var enemyDefenseRoll = enemy.CombatRoll(enemy.DefenseScore);

            if (attackRoll > enemyDefenseRoll)
            {
                var damage = attackRoll - enemyDefenseRoll;
                enemy.HitPoints -= damage;

                Console.WriteLine(
                    $"I rolled {attackRoll} against enemys {enemyDefenseRoll}, " +
                    $"resulting in {damage} damage. "
                    );
            }
            else
            {
                Console.WriteLine(
                    $"I missed with {attackRoll} against enemys {enemyDefenseRoll}."
                    );
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
