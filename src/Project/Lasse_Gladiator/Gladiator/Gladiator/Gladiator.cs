using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class Gladiator
    {
        public int AttackScore { get; private set; }
        public int DefenceScore { get; private set; }
        public int HitPoints { get;  set; }

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
           
        }

        public bool IsAlive()
        {
            return HitPoints > 0;
        }

        public void Attack(Gladiator enemy)
        {
            
            }
        }

        

      

    }

