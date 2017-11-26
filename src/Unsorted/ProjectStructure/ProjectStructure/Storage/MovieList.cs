using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ProjectStructure.Model;

namespace ProjectStructure.Storage
{
    public class MovieList
    {
        private List<Movie> Movies { get; } = new List<Movie>();

        public void Add(Movie movie)
        {
            Movies.Add(movie);
        }

        public int Count()
        {
            return Movies.Count;
        }

        public void PrintList()
        {
            foreach (var movie in Movies)
            {
                Console.WriteLine(movie.Summary());
            }
        }
    }
}
