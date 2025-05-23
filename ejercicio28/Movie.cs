using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio28
{
    class Movie
    {
        //atributo privados de la clase Movie
        private string title = string.Empty;
        private string director = string.Empty;
        private int premiere;
        //construcor 
        public Movie(string title, string director, int premiere)
        {
            Title = title;
            Director = director;
            Premiere = premiere;
        }

        //propiedad publica de title
        public string Title
        {
            get { return title; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine("Error. titulo no valido.");
                }
                else
                {
                    this.title = value;
                }
            }
        }
        //propiedad publica de director
        public string Director
        {
            get { return director; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine("Error. nombre de director no valido.");
                }
                else
                {
                    this.director = value;
                }
            }
        }
        //propiedad publica de premiere
        public int Premiere
        {
            get { return premiere; }
            set
            {
                int current = DateTime.Now.Year;
                if (value > 1900 && value <= current )
                {
                    System.Console.WriteLine("Error. nombre de director no valido.");
                }
                else
                {
                    this.premiere = value;
                }
            }
        }


    }
}