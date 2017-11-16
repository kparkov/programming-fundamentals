using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectStructure.Model
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Person Director { get; set; }
        public List<Person> CentralCast { get; set; } = new List<Person>();
        public PgRating PgRating { get; set; } = PgRating.General;
        public int Runtime { get; set; }
        public decimal TicketPrice { get; set; }

        public string Summary()
        {
            string actors;

            if (CentralCast.Count > 1)
            {
                actors = $"{CentralCast.First().Name} and more!";
            }
            else if (CentralCast.Count == 1)
            {
                actors = $"{CentralCast.First().Name}";
            }
            else
            {
                actors = $"no one!";
            }

            return $"{Title} ({Year}) (directed by {Director.Name}) (starring {actors})";
        }
    }
}
