using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1._6MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        MovieDAL movieDB = new MovieDAL();

        [HttpGet]
        public List<Movie> GetMovies()
        {
            return movieDB.GetAllMovies();
        }
        [HttpGet ("genre/{genre}")]
        public List<Movie> MoviesByGenre(string genre)
        {
            List<Movie> genreList = movieDB.MoviesByGenre(genre);
            return genreList;
        }
        [HttpGet("random")]
        public Movie RandomSingleMovie()
        {
            List<Movie> newList = new List<Movie>();
            var rng = new Random();

            int randInt = rng.Next(0, (newList.Count() + 1));
            Movie randomMovie = movieDB.GetMovieByIndex(randInt);
            return randomMovie;
        }

        [HttpGet("random/{numOfMovies}")]
        public List<Movie> RandomListOfMovies(int numOfMovies)
        {
            List<Movie> newList = new List<Movie>();
            var rng = new Random();
            
            int randInt = rng.Next(0, (newList.Count()+1));

            for (int i = 0; i <= numOfMovies; i++)
            {
                newList.Add(movieDB.GetMovieByIndex(randInt));
            }
            return newList;
        }

    }
}
