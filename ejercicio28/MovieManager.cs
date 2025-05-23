using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio28
{
    class MovieManager
    {
        //atributo privado de la clase
        private List<Movie> movies;
        //constructor para inicializar la lista
        public MovieManager()
        {
            movies = new List<Movie>();
        }
        //metodo para añadir objetos a la lista
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
        //metodo para mostrar la lista de peliculas
        public virtual void DisplayListMovie()
        {
            System.Console.WriteLine("Listas de peliculas:");
            foreach (Movie movie in movies)
            {
                System.Console.WriteLine($"Nombre de la pelicula: {movie.Title}");
                System.Console.WriteLine($"Nombre del director de la pelicula {movie.Title}: {movie.Director}");
                System.Console.WriteLine($"Estreno de la pelicula {movie.Title}: {movie.Premiere} ");
                System.Console.WriteLine("----------------------------------------------------");

            }

        }
        //metodo para buscar una pelicula especifica mediante su titulo
        public void SearchMovie(string searchMovie)
        {
            bool found = false;
            foreach (Movie movie in movies)
            {
                if (movie.Title.Equals(searchMovie, StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine("Pelicula encontrada!!!");
                    System.Console.WriteLine($"titulo original: {movie.Title}");
                    System.Console.WriteLine($"director: {movie.Director}");
                    System.Console.WriteLine($"estreno: {movie.Premiere}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                System.Console.WriteLine("pelicula no encontrada...");

            }

        }
        //metodo para remover pelicula
        public void removeMovie(string removeMovieTitle)
        {
            bool found = false;
            foreach (Movie movie in movies)
            {
                if (movie.Title.Equals(removeMovieTitle, StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine($"la pelicula {movie.Title} ha sido removida exitosamente");
                    movies.Remove(movie);
                    break;
                }
            }
            if (!found)
            {
                System.Console.WriteLine("la pelicula no ha sido removida...");
            }
        }
        //metodo para mostrar solo las listas lanzadas por un año especifico
        public void DisplayMoviesByYear(int year)
        {
            System.Console.WriteLine($"Lista de estreno de peliculas en el año {year}");
            foreach (Movie movie in movies)
            {
                if (movie.Premiere.Equals(year))
                {
                    DisplayListMovie();
                }
            }
        }
    }
}