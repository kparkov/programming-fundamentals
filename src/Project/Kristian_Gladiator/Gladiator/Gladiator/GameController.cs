using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator
{
    public class GameController
    {
        // PROPERTIES
        public List<Gladiator> Combatants { get; } = new List<Gladiator>();
        public List<Gladiator> Graveyard { get; } = new List<Gladiator>();
        public GameView View { get; } = new GameView();

        // METHODS
        public void RunGame()
        {
            PopulateGladiatorList();

            while (DoContinueGame())
            {
                var a = Combatants[0];
                Combatants.Remove(a);

                var b = Combatants[0];
                Combatants.Remove(b);

                View.AnnounceFight(a, b);

                var combatController = new CombatController();
                var result = combatController.Fight(a, b);

                View.SomeoneDied(result.Loser, Graveyard.Count);

                result.Winner.AttackScore += 1;
                result.Winner.HitPoints = 10;

                Combatants.Add(result.Winner);
                Graveyard.Add(result.Loser);
            }

            View.AnnounceWinner(Combatants[0]);
        }

        private bool DoContinueGame()
        {
            return Combatants.Count > 1;
        }

        private void PopulateGladiatorList()
        {
            Combatants.Add(new Gladiator("Spartacus"));
            Combatants.Add(new Gladiator("Maximus"));
            Combatants.Add(new Gladiator("Brutus"));
            Combatants.Add(new Gladiator("Jørgen"));
            Combatants.Add(new Gladiator("Atticus"));
            Combatants.Add(new Gladiator("Aurelius"));
            Combatants.Add(new Gladiator("Cassius"));
            Combatants.Add(new Gladiator("Flavius"));
            Combatants.Add(new Gladiator("Augustus"));
            Combatants.Add(new Gladiator("Julius"));
        }
    }
}
