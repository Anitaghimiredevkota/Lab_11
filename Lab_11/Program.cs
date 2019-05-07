using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput,userInput1 ,userInput2;
            string success="y";
            List<Movie> movies = new List<Movie> {
                new Movie("Moana", "animated"),
                new Movie("Coco","animated"),
                new Movie("Sherk", "animated"),
                new Movie("Drakula", "horror"),
                new Movie("Sofia the first", "animated"),
                 new Movie("Arrival","scifi"),
                 new Movie("Star Wars","Scifi"),
                 new Movie("Avenger","Scifi"),
                 new Movie("The Help","drama"),
                 new Movie("First Man","drama"),
                 new Movie("Carol","drama")
            };
            //movies.Sort((a, b) => a.Title.CompareTo(b.Title));

            Console.WriteLine("Welcome to the Movie List Application!");
            userInput = Console.ReadLine();
            Console.WriteLine($"There are {movies.Count} movies in this list");
            userInput1 = Console.ReadLine();

            while (success == "y")
            {
                Console.WriteLine("What category are you interested in?");
                userInput2 = Console.ReadLine();


                switch (userInput2.ToLower())
                {
                    case "animated":
                        Movie.GetMovie(movies, "animated");
                        break;
                    case "scifi":
                        Movie.GetMovie(movies, "scifi");
                        break;
                    case "horror":
                        Movie.GetMovie(movies, "horror");
                        break;
                    case "drama":
                        Movie.GetMovie(movies, "drama");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Would you like to continue?(y/n)");
                string choice = Console.ReadLine();
                if(choice == "n")
                {
                    success = "n";
                    Console.WriteLine();
                }
         
            }
          


        }
    }
}
