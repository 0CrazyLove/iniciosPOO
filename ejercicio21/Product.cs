using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio21
{
    class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
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
                    Console.WriteLine("Error. nombre no valido");
                }
            }

        }
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
                    Console.WriteLine("Error. no se permite valores negativos");
                }
            }

        }
        public void DisplayList()
        {
            Console.WriteLine($"nombre del producto: {Name} \n Precio:{Price} \n");
        }
      
        



    }
}