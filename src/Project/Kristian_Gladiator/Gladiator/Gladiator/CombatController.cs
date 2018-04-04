using System.Threading;

namespace Gladiator
{
    public class CombatController
    {
        private CombatView View { get; set; }

        public CombatController()
        {
            //View = new CombatView();
        }

        public CombatResult Fight(Gladiator a, Gladiator b)
        {
            View?.GladiatorPresentation(a);
            View?.GladiatorPresentation(b);

            var attacker = a;
            var defender = b;

            while (DoContinueFight(a, b))
            {
                var temp = attacker;
                attacker = defender;
                defender = temp;

                PerformAttack(attacker, defender);
            }

            return new CombatResult()
            {
                Winner = attacker,
                Loser = defender
            };
        }

        private bool DoContinueFight(Gladiator a, Gladiator b)
        {
            return !a.IsBeaten() && !b.IsBeaten();
        }

        private void PerformAttack(Gladiator attacker, Gladiator defender)
        {
            var attackRoll = CombatRoll(attacker.AttackScore);
            var enemysDefenseRoll = CombatRoll(defender.DefenseScore);
            var isHit = attackRoll > enemysDefenseRoll;
            var damage = 0;

            if (isHit)
            {
                damage = DamageRoll(attacker.Strength);
                defender.Wounds += damage;
            }

            View?.AttackResult(attacker, defender, isHit, damage);
        }

        private int CombatRoll(int score)
        {
            var cup = new DiceCup();
            cup.Add(1, 20);
            cup.Roll();
            return cup.Sum() + score;
        }

        private int DamageRoll(int score)
        {
            var cup = new DiceCup();
            cup.Add(1, 6);
            return score + cup.Roll().Sum();
        }
    }
}
