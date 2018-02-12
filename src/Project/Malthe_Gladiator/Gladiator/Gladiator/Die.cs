﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class Die
    {
        public int Sides { get; private set; }
        public int SideUp { get; set; }

        public Die(int sides)
        {
            Sides = sides;
            Roll();
        }

        public void Roll()
        {
            var Random = new Random();
            SideUp = Random.Next(1, Sides + 1);
        }
    }
}
