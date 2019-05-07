using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Movie
    {
        private string title;
        private string category;

        public string Title
        { set { title = value; }
            get { return title; }
        }
        public string Category
        { set { category = value; }
            get { return category; }
        }
        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }
        public static void GetMovie(List<Movie> movies, string Category)
        {
            foreach(Movie movie in movies)
            {
                if(movie.Category==Category)
                {
                    Console.WriteLine($"{movie.Category} is {movie.Title}");
                }
            }
        }
    }
}
