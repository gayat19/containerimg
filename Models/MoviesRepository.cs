using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildPipeEditDockerProject.Models
{
    public class MoviesRepository : IRepository<Movie>
    {
        public List<Movie> movies;

        public MoviesRepository()
        {
            movies = new List<Movie>();
            movies.Add(new Movie
            {
                Id = 101,
                Name = "X-Men",
                Duration = 123.2f
            });
        }

        public void AddItem(Movie movie)
        {
            this.movies.Add(movie);
        }

        public IEnumerable<Movie> GetItems()
        {
            return this.movies;
        }

        public Movie GetItemById(int id)
        {
            return this.movies.FirstOrDefault(m => m.Id == id);
        }

         
    }
}
