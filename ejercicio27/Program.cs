using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book1 = new Book("fulanito123", "chatGpt", 2008);
            Book book2 = new Book("la venganza de c# contra c++", "Microsoft", 2000);
            Book book3 = new Book("java Vs javaScript", "Pepito", 2017);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.DisplayList();



        }
    }
}