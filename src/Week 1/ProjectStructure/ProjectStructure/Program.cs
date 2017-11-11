using System;
using ProjectStructure.Model;
using ProjectStructure.Storage;

namespace ProjectStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person me = new Person()
            {
                Name = "Kristian Videmark Parkov",
                Birthday = new DateTime(1980, 8, 9),
                Address = new Address()
                {
                    Street = "Tranevej",
                    Number = 15,
                    ZipCode = "2400",
                    Country = "Denmark"
                }
            };

            Person president = new Person()
            {
                Name = "Donald Trump",
                Birthday = new DateTime(1946, 6, 14),
                Address = new Address()
                {
                    Street = "Pennsylvania Ave NW",
                    Number = 1600,
                    ZipCode = "DC 20500",
                    Country = "USA"
                }
            };

            var storage = new PeopleStore();

            storage.AddPerson(me);
            storage.AddPerson(president);

            storage.PrintSummary();
            Console.ReadKey();
        }
    }
}
