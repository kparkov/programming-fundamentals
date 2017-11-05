using System;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.Model;

namespace ProjectStructure.Storage
{
    public class PeopleStore
    {
        private readonly List<Person> _people = new List<Person>();

        public void AddPerson(Person person)
        {
            _people.Add(person);
        }

        public void PrintAllAddresses()
        {
            foreach (var person in _people)
            {
                Console.WriteLine($"{person.Name} lives at {person.Address.Street} {person.Address.Number}, {person.Address.ZipCode}, {person.Address.Country}.");
            }
        }
    }
}
