using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Gladiator
{
    public class ProgressGenerator
    {
        private class AttributeSelection
        {
            public string Name { get; set; }
            public Expression<Func<Gladiator, int>> Property { get; set; }
            public PropertyInfo GetProperty() => (PropertyInfo) ((MemberExpression) Property.Body).Member;
        }

        private List<AttributeSelection> AttributeSelections { get; set; } = new List<AttributeSelection>()
        {
            new AttributeSelection() { Name = "Strength", Property = g => g.Strength },
            new AttributeSelection() { Name = "Constitution", Property = g => g.Constitution },
            new AttributeSelection() { Name = "AttackScore", Property = g => g.AttackScore },
            new AttributeSelection() { Name = "DefenseScore", Property = g => g.DefenseScore },
            new AttributeSelection() { Name = "Morale", Property = g => g.Morale },
        };

        public List<string> Progress(Gladiator gladiator)
        {
            var attribs = AttributeSelections.ToList();
            var increase = new List<AttributeSelection>();
            var random = new Random();
            var result = new List<string>();

            var nameGenerator = new NameGenerator();

            if (gladiator.Victories == 7) gladiator.Name = gladiator.Name + " the " + nameGenerator.GetAdjective();
            if (gladiator.Victories == 14) gladiator.Name = nameGenerator.GetTitle() + " " + gladiator.Name;

            for (var i = 0; i < 2; i++)
            {
                var a = attribs[random.Next(0, attribs.Count)];
                attribs.Remove(a);
                increase.Add(a);
            }

            foreach (var attribute in increase)
            {
                attribute.GetProperty().SetValue(gladiator, ((int) attribute.GetProperty().GetValue(gladiator)) + 1);
                result.Add(attribute.Name);
            }

            return result;
        }
    }
}