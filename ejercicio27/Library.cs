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
        //metodo para buscar un libro:
        public void SearchBook(string searchTitle)
        {
            bool found = false;
            foreach (Book book in books)
            {
                if (book.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nLibro encontrado!!");
                    Console.WriteLine($"Título: {book.Title}");
                    Console.WriteLine($"Autor: {book.Author}");
                    Console.WriteLine($"Año: {book.Year}");
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                System.Console.WriteLine("libro no encontrado...");
            }
        }
        //metodo para eliminar un libro mediante su titulo
        public void RemoveBook(string bookRemove)
        {
            bool removed = false;
            foreach (Book book in books)
            {
                if (book.Title.Equals(bookRemove, StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine($"el libro {book.Title} ha sido eliminado correctamente!");
                    books.Remove(book);
                    removed = true;
                    break;
                }

            }

                if (!removed)
                {
                    System.Console.WriteLine("Libro no encontrado. No se puedo eliminar...");

                }
        }



    }
}