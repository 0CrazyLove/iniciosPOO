using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio25
{
    public class Product
    {
        //atributos privado de la clase 
        private string name;
        private decimal price;
        private string description;
        //propiedad de name
        //constructor 
        public Product(string name, decimal price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    System.Console.WriteLine("Error. nombre no valido");
                }
            }
        }
        //propiedad de Price
        public decimal Price
        {
            get { return price; }
            set
            {
                if (!(value <= 0))
                {
                    this.price = value;
                }
                else
                {
                    System.Console.WriteLine("Error. no se permite valores negativos o nulos");
                }
            }
        }
        //propiedad de Description
        public string Description
        {
            get { return description; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.description = value;
                }
                else
                {
                    System.Console.WriteLine("Error. descripcion no valida");
                }
            }
        }

    }
}