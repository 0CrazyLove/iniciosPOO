using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Shampo", 200.000m));
            products.Add(new Product("pc", 200.000m));
            products.Add(new Product("cargador", 39.000m));
            products.Add(new Product("dildo", 23.000m));
            products.Add(new Product("mouse", 123.000m));

            foreach (Product product in products)
            {
                if (product.Price >= 50.000m)
                {
                    product.DisplayInfo();
                }

            }

        }


    }
}