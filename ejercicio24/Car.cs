using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio24;

namespace ejercicio22
{
    public class Car
    {
        //atributo propio de la clase
        private List<Product> products;

        //constructor
        public Car()
        {
            products = new List<Product>();
        }

        //metodo para agregar productos 
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        //metodo para mostrar los productos
        public void DisplayProduct()
        {
            System.Console.WriteLine("productos: ");
            foreach (Product produc in products)
            {
                System.Console.WriteLine($"Nombre del producto->{produc.Name}");
                System.Console.WriteLine($"precio del producto{produc.Name}-> ${produc.Price.ToString()}COP");

            }



        }
    }
}