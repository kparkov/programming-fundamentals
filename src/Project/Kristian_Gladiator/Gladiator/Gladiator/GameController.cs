using System;
using System.Collections.Generic;
using System.Linq;
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
            PopulateGladiatorList(1000);
            View.Roster(Combatants, 0, 0);
            var counter = 0;

            while (Combatants.Count > 1)
            {
                View.Roster(Combatants, counter, Graveyard.Count);
                if (EligibleToFight(Combatants).Count() > 1)
                {
                    var (a, b) = PickPair();
                    //View.AnnounceFight(a, b);
                    var combatController = new CombatController();
                    var result = combatController.Fight(a, b);

                    //View.CombatResult(result.Winner, result.Loser, Combatants.Count, Graveyard.Count);

                    result.Winner.Victories += 1;

                    FateOf(result.Winner);
                    FateOf(result.Loser);

                    Progress(result.Winner);

                    counter++;
                }

                Maintenance(counter);
            }

            View.AnnounceWinner(Combatants[0]);
        }

        private void PopulateGladiatorList(int numberToBuild)
        {
            var factory = new GladiatorFactory();

            for (var i = 0; i < numberToBuild; i++)
            {
                Combatants.Add(factory.BuildGladiator());
            }
        }

        private void Maintenance(int fights)
        {
            var wounded = Combatants.Where(g => g.IsWounded());

            foreach (var g in wounded) g.Heal(3);

            //var victoryMax = Combatants.Max(c => c.Victories);
            
            //if ((new Random()).NextDouble() < 0.05 || Combatants.Count < 10)
            //{
            //    var numberToAdd = (new Random()).Next(0, 30);
            //    numberToAdd = Math.Min(numberToAdd, 1000 - Graveyard.Count - Combatants.Count);
            //    numberToAdd = Math.Max(0, numberToAdd);
            //    //View.Roster(Combatants, fights, Graveyard.Count);
            //    PopulateGladiatorList(numberToAdd);
            //    //View.Roster(Combatants, fights, Graveyard.Count);
            //}
        }

        private (Gladiator, Gladiator) PickPair()
        {
            var r = new Random();

            var eligible = EligibleToFight(Combatants);

            var first = eligible
                .OrderBy(x => r.NextDouble())
                .First();

            var second = eligible
                .Where(g => g != first)
                //.OrderBy(g => Math.Abs(g.Victories - first.Victories))
                .OrderBy(x => r.NextDouble())
                .First();
            
            Combatants.Remove(first);
            Combatants.Remove(second);

            return (first, second);
        }

        private IEnumerable<Gladiator> EligibleToFight(IEnumerable<Gladiator> gladiators)
        {
            return gladiators.Where(g => !g.IsWounded());
        }

        private void FateOf(Gladiator gladiator)
        {
            if (gladiator.IsAlive())
            {
                Combatants.Add(gladiator);
            }
            else
            {
                Graveyard.Add(gladiator);
            }
        }

        private void Progress(Gladiator winner)
        {
            var generator = new ProgressGenerator();
            var result = generator.Progress(winner);
            //View.AnnounceProgress(winner, result);
        }
    }
}
