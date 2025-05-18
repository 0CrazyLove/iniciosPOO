using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio18
{
    class Book
    {
        private string title;
        private string author;


        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.title = value;
                }
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.author = value;
                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Nombre del autor: {Author} \n titulo de la obra: {Title}");
        }








    }
}