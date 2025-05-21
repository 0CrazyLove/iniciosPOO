using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio24;
namespace ejercicio24
{
    public class Product
    {
        //atributos propios de la clase
        private string name;
        private decimal price;
        //constructor
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;

        }



        //propiedad de name
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    System.Console.WriteLine("Error. nombre no valido");

                }
            }
        }
        //propiedad de name
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


    }
}
