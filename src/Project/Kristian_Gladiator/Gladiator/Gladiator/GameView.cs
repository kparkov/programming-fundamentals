using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class GameView
    {
        public void AnnounceFight(Gladiator a, Gladiator b)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"A FIGHT COMMENCES! {a.Name} WILL FIGHT {b.Name}");
            Console.WriteLine("-----------------------------------------------------");
        }

        public void SomeoneDied(Gladiator deceased, int numberInGraveyard)
        {
            Console.WriteLine($"{deceased.Name} has died. He joins {numberInGraveyard} other poor souls.");
        }

        public void AnnounceWinner(Gladiator winner)
        {
            Console.WriteLine($"THE TOURNAMENT WAS WON BY {winner.Name}.");
        }
    }
}
