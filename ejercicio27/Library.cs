using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio27
{
    class Library
    {
        //atributo privado de la clase
        private List<Book> books;
        //constructor para inicializar la lista
        public Library()
        {
            books = new List<Book>();
        }
        //metodo para añadir objetos de la clase Book a la lista
        public void AddBook(Book bookAdd)
        {
            books.Add(bookAdd);
        }
        //metodo para mostrar la lista
        public void DisplayList()
        {
                Console.Clear();
            System.Console.WriteLine("lista de libros:");
            foreach (Book book in books)
            {
                System.Console.WriteLine($"nombre del libro: {book.Title}");
                System.Console.WriteLine($"autor del libro{book.Title}: {book.Author}");
                System.Console.WriteLine($"año de lanzamiento del libro{book.Title}: {book.Year}");
                System.Console.WriteLine("--------------------------------------------------------");
            }
        }
        


    }
}