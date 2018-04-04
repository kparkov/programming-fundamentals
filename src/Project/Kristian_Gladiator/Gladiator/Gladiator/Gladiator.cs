using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class Gladiator
    {
        public string Name { get; set; }

        public int Strength { get; set; } = 0;
        public int AttackScore { get; set; } = 0;
        public int DefenseScore { get; set; } = 0;
        public int Morale { get; set; } = 0;
        public int Constitution { get; set; } = 0;
        public int Wounds { get; set; } = 0;

        public int Victories { get; set; } = 0;

        public Gladiator(string name)
        {
            Name = name;
        }

        public bool IsAlive()
        {
            return HitPoints() > -3;
        }

        public bool IsBeaten()
        {
            return !DareFight() || IsUnconscious();
        }

        public bool DareFight()
        {
            return Morale > Wounds;
        }

        public bool IsWounded()
        {
            return Wounds > 0;
        }

        public bool IsUnconscious()
        {
            return Wounds >= Constitution;
        }

        public void Heal(int hp)
        {
            Wounds = Math.Max(Wounds - hp, 0);
        }

        public int HitPoints() => Constitution - Wounds;
    }
}
