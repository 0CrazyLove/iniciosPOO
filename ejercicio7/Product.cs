using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    public class Product
    {
        //atributos privados
        private string name;
        private double price;
        //constructor
        public Product(string name, double price)
        {
            if(price <= 0)
            {
                Console.WriteLine("El precio no es valido");
                Environment.Exit(0);
            }
            
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("El nombre no es valido");
                Environment.Exit(0);
            }

            this.name = name;
            this.price = price;

        }

        //metodo para obtener el nombre(Getter)

        public string GetName()
        {
            return name;
        }

        //metodo para obtener el precio(Getter)
        public double GetPrice()
        {
            
            return price;
        }

        //metodo set para cambiar el nombre(Setter)
        public void SetName(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                Console.WriteLine("El nombre no es valido");
            }
            else
            {
                name = newName;

            }

        }
        //metodo set para cambiar el precio(Setter)
        public void SetPrice(double newPrice)
        {
            if (newPrice >= 0)
            {
                price = newPrice;
            }
            else
            {
                Console.WriteLine("El precio no es valido");
            }
            


        }



    }
}
