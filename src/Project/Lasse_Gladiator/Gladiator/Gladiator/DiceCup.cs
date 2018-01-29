using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    class DiceCup
    {
        private List<Die> Dice { get; set; }


        //Constructor
        public DiceCup()
        {
            Dice = new List<Die>();
        }

        public void Add (Die die)
        {
            Dice.Add(die);
        }

        public void Add(int number, int sides)
        {
            int counter = 0;

            while (counter < number)
            {
                Add(new Die(sides));
                counter += 1;
            }
        }

        public void Roll()
        {
            foreach (var die in Dice)
            {
                die.Roll();
            }
        }


        public int Sum()
        {
            int result = 0;

            foreach (var die in Dice)
            {
                    result += die.SideUp;
            }

            return result;

            }
        }
    }

