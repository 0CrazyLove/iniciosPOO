using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieManager movieManager = new MovieManager();

            Movie movie1 = new Movie("Miguel", "fulanito", 1995);
            Movie movie2 = new Movie("Zombies", "juanito", 2000);
            Movie movie3 = new Movie("titanic", "poveda", 2000);
            Movie movie4 = new Movie("Dogs", "CrazyLOve", 2021);
            Movie movie5 = new Movie("Cry", "Maikol", 2019);

            movieManager.AddMovie(movie1);
            movieManager.AddMovie(movie2);
            movieManager.AddMovie(movie3);
            movieManager.AddMovie(movie4);
            movieManager.AddMovie(movie5);
            bool active = false;

            while (!active)
            {

                Console.WriteLine(@"MENÚ DE PRODUCTOS
            1. Mostrar todas las peliculas
            2. Buscar pelicula mediante su titulo
            3. Eliminar pelicula mediante su titulo
            4. Mostrar películas por año
            5. Salir");
                System.Console.Write("Por favor, escoja una opcion-> ");
                int option;
                bool exito = int.TryParse(Console.ReadLine(), out option);
                if (exito)
                {
                    if (option.Equals(1))
                    {
                        movieManager.DisplayListMovie();
                    }
                    else if (option.Equals(2))
                    {
                        System.Console.Write("Por favor, escriba el titulo de la pelicula deseada->");
                        string? title = Console.ReadLine();
                        Console.Clear();
                        if (title != null)
                        {
                            movieManager.SearchMovie(title);

                        }


                    }
                    else if (option.Equals(3))
                    {
                        System.Console.Write("Por favor, escriba el titulo de la pelicula que sera eliminada->");
                        string? title = Console.ReadLine();
                        Console.Clear();
                        if (title != null)
                        {

                            movieManager.removeMovie(title);
                        }

                    }
                    else if (option.Equals(4))
                    {
                        System.Console.Write("Por favor, escriba el año de estreno de la pelicula->");
                        int year;
                        bool exitParse = int.TryParse(Console.ReadLine(), out year);
                        Console.Clear();
                        if (exitParse)
                        {
                            movieManager.DisplayMoviesByYear(year);
                        }
                        else
                        {
                            System.Console.WriteLine("no se ha esctrito nada...");
                        }

                    }
                    else if (option.Equals(5))
                    {
                        System.Console.WriteLine("VUELVA PRONTO!!!");
                        active = true;
                    }
                }
                else
                {

                    System.Console.WriteLine("Por favor, elija una opcion valida del menu.");
                }
            }

        }
    }
}