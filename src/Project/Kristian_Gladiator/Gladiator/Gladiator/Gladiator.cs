using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class Gladiator
    {
        public string Name { get; private set; }

        public int AttackScore { get; set; }
        public int DefenseScore { get; private set; }
        public int HitPoints { get; set; }

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

        public bool IsAlive()
        {
            return HitPoints > 0;
        }

        
    }
}
