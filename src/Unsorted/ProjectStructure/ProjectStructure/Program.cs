using System;
using System.Collections.Generic;
using ProjectStructure.Model;
using ProjectStructure.Storage;

namespace ProjectStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cinemaProgram = new MovieList();

            var director = new Person()
            {
                Name = "Denis Villeneuve"
            };

            var leadRole = new Person()
            {
                Name = "Ryan Gosling"
            };

            var movie = new Movie()
            {
                Title = "Blade Runner 2049",
                Director = director,
                CentralCast = new List<Person>() { leadRole },
                Year = 2017,
                PgRating = PgRating.R,
                Runtime = 164,
                TicketPrice = 120
            };

            cinemaProgram.Add(movie);

            cinemaProgram.Add(new Movie()
            {
                Title = "As good as it gets",
                Director = new Person()
                {
                    Name = "James L. Brooks"
                },
                CentralCast = new List<Person>()
                {
                    new Person() { Name = "Jack Nicholson" },
                    new Person() { Name = "Helen Hunt" },
                },
                Year = 1997,
                PgRating = PgRating.PG13,
                Runtime = 139,
                TicketPrice = 90
            });

            Console.WriteLine($"The movie list contains {cinemaProgram.Count()} movies: ");
            Console.WriteLine($"-------------------------------------------------------");
            Console.WriteLine("");

            cinemaProgram.PrintList();

            Console.ReadKey();
        }
    }
}
