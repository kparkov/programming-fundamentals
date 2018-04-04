using System;
using System.Collections.Generic;
using System.Linq;

namespace Gladiator
{
    public class RandomItemList
    {
        private readonly List<string> _items;
        private static readonly Random _random = new Random();

        public RandomItemList(string s)
        {
            _items = s.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
        }

        public RandomItemList(IEnumerable<string> s)
        {
            _items = s.Distinct().ToList();
        }

        public string GetRandomItem()
        {
            return _items[_random.Next(0, _items.Count)];
        }
    }
}