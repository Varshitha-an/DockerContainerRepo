using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildPipeEditDockerProject.Models
{
    public class MovieRepository:IRepository<Movie>
    {
        public List<Movie> movies;
        //private static readonly object forLock = new object();
        //private static MovieRepository repository = null;
        public  MovieRepository()
        {
            movies = new List<Movie>();
            movies.Add(new Movie
            {
                Id = 100,
                Name = "Avengers",
                Duration = 120.50f
            });
        }
        //public static MovieRepository GetInstance
        //{
        //    get
        //    {
        //        lock(forLock)
        //        {
        //            if (repository == null)
        //                repository = new MovieRepository();
        //            return repository;
        //        }
        //    }
        //}
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
