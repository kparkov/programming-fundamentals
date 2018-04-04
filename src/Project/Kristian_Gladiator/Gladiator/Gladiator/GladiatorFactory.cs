using System.Reflection;

namespace Gladiator
{
    public class GladiatorFactory
    {
        private static readonly NameGenerator NameGenerator = new NameGenerator();

        public Gladiator BuildGladiator()
        {
            var gladiator = new Gladiator(NameGenerator.GetName());

            gladiator.Strength = RollAttribute();
            gladiator.AttackScore = RollAttribute();
            gladiator.DefenseScore = RollAttribute();
            gladiator.Morale = RollAttribute();
            gladiator.Constitution = RollAttribute();

            return gladiator;
        }

        private int RollAttribute()
        {
            var cup = new DiceCup();
            cup.Add(1, 6);

            return cup.Roll().Sum();
        }
    }
}