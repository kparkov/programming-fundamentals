using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class GameController
    {   //Kombineret property og initiering af propertien til en værdi
        public List<Gladiator> Combatants { get; } = new List<Gladiator>();
        public List<Gladiator> Graveyard { get; } = new List<Gladiator>();

        public void RunGame()
        {
            PopulateGladiatorList();
            while (DoContinueGame())
            {
                var a = Combatants[0];
                Combatants.Remove(a);

                var b = Combatants[0];
                Combatants.Remove(b);

                var combatController = new CombatController();
                var result = combatController.Fight(a, b);

                Combatants.Add(result.Winner);
                Graveyard.Add(result.Loser);
            }
        }

        private bool DoContinueGame()
        {
            return Combatants.Count > 1;
        }

        private void PopulateGladiatorList()
        {
            Combatants.Add(new Gladiator("Bent"));
            Combatants.Add(new Gladiator("Marcus"));
            Combatants.Add(new Gladiator("Spartacus"));
            Combatants.Add(new Gladiator("Julius"));
            Combatants.Add(new Gladiator("Brutus"));
            Combatants.Add(new Gladiator("Aurelius"));

        }

    }
}
