using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> listBook = new List<Book>();
            listBook.Add(new Book("El viejo y el mar", "miguel gonzales"));
            listBook.Add(new Book("principito", "Maikol tonto"));
            listBook.Add(new Book("abitos atomico", "CrazyLove"));

            Console.WriteLine("lista de libros: ");

            foreach (Book est in listBook)
            {
                est.DisplayInfo();
            }


        }
    }
}