using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio22
{
    class Car
    {
        private List<string> product;
        //constructor

        public Car()
        {
            product = new List<string>();
        }

        //metodo para agregar producto
        public void AddProduct(string productName)
        {
            product.Add(productName);
        }
        //metodo para mostrar producto 
        public void DisplayProduct()
        {
            System.Console.WriteLine("productos en el carrito: ");
            foreach (string producto in product)
            {
                System.Console.WriteLine($"->{producto}");

            }
        }

    }
}

