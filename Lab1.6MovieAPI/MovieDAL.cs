using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1._6MovieAPI
{
    public class MovieDAL
    {
        public List<Movie> GetAllMovies()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = "select * from movies";
                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();
                connect.Close();

                return movies;
            }
        }
        public List<Movie> MoviesByGenre(string genre)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                
                
                string sql = $"select * from movies where genre='{genre}'";
                connect.Open();
                List<Movie> movies = connect.Query<Movie>(sql).ToList();
                connect.Close();

                return movies;

            }
        }
        public Movie GetMovieByIndex(int index)
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {
                string sql = $"select * from movies where id={index}";
                connect.Open();
                Movie movie = connect.Query<Movie>(sql).ToList().First();
                connect.Close();

                return movie;
            }
        }
    }
}
