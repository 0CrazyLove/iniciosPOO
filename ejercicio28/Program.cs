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

            Console.WriteLine(@"MENÚ DE PRODUCTOS
            1. Mostrar todas las peliculas
            2. Buscar pelicula mediante su titulo
            3. Eliminar pelicula mediante su titulo
            4. Salir");
            System.Console.Write("Por favor, escoja una opcion-> ");
            int option = int.Parse(Console.ReadLine());
            if (option.Equals(1))
            {
                movieManager.DisplayListMovie();
                Console.Clear();
                Main(args);
            }
            else if (option.Equals(2))
            {
                System.Console.Write("Por favor, escriba el titulo de la pelicula deseada->");
                string title = Console.ReadLine();
                movieManager.SearchMovie(title);
                Console.Clear();
                Main(args);
            }
            else if (option.Equals(3))
            {
                System.Console.Write("Por favor, escriba el titulo de la pelicula que sera eliminada->");
                string title = Console.ReadLine();
                movieManager.removeMovie(title);
                Console.Clear();
                Main(args);
            }
            else if (option.Equals(4))
            {
                System.Console.WriteLine("VUELVA PRONTO!!!");
            }
            else
            {
                System.Console.WriteLine("Por favor, elija una opcion valida del menu.");
                Main(args);
            }
        }
    }
}