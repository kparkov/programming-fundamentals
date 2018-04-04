namespace Gladiator
{
    public class NameGenerator
    {
        private static readonly RandomItemList Names;
        private static readonly RandomItemList Titles;
        private static readonly RandomItemList Adjectives;

        static NameGenerator()
        {
            Names = new RandomItemList(new Resource("Gladiator.Resources.names.txt").ToString());
            Titles = new RandomItemList(new Resource("Gladiator.Resources.titles.txt").ToString());
            Adjectives = new RandomItemList(new Resource("Gladiator.Resources.adjectives.txt").ToString());
        }

        public string GetTitle() => Titles.GetRandomItem();
        public string GetName() => Names.GetRandomItem();
        public string GetAdjective() => Adjectives.GetRandomItem();
    }
}