using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio27
{
    class Book
    {
        //atributos privados de la clase
        private string title;
        private string author;
        private int year;
        //constructor
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        //propieadad publica de title
        public string Title
        {
            get { return title; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.title = value;
                }
                else
                {
                    System.Console.WriteLine("Error. titulo no valido");
                }
            }
        }
        //propieadad publica de author
        public string Author
        {
            get { return author; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.author = value;
                }
                else
                {
                    System.Console.WriteLine("Error. nombre del autor no es valido");
                }
            }
        }
        //propieadad publica de year
        public int Year
        {
            get { return year; }
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value >0 && value <= currentYear)
                {
                    this.year = value;
                }
                else
                {
                    System.Console.WriteLine($"Error. El año debe estar entre 1 y {currentYear}");
                }
            }
        }


    }
}
