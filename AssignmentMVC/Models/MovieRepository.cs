using System.Collections.Generic;
using System.Linq;

namespace MovieProject.Models
{
    public class MovieRepository
    {
        private static readonly List<Movie> Movies = new List<Movie>()
        {
            new Movie() { MovieId = 1, Title = "RRR", Actor = "NTR", Lang = "Telugu", Director = "Rajamouli" },
            new Movie() { MovieId = 2, Title = "KGF", Actor = "Yash", Lang = "Kannada", Director = "Prasanth Neel" },
            new Movie() { MovieId = 3, Title = "Bahubali", Actor = "Prabhas", Lang = "Hindi", Director = "Rajamouli" },
            new Movie() { MovieId = 4, Title = "Kalki 2898AD", Actor = "Prabhas", Lang = "Hindi", Director = "Nag Ashwin" }
        };

        public List<Movie> GetAllMovies()
        {
            return Movies;
        }

        public Movie GetMovieByName(string name)
        {
            return Movies.SingleOrDefault(m => m.Title.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }
    }
}
