using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"MENÚ DE PRODUCTOS
            1. Mostrar todos los productos
            2. Mostrar productos con precio menor o igual a 50.000
            3. Buscar producto por nombre
            4. Salir");
            Console.Write("escoja una opcion por favor >");
            int option = int.Parse(Console.ReadLine());
            MenuProduct menu = new MenuProduct(option);
            List<Product> products = new List<Product>();
            products.Add(new Product("agua", 2.000m));
            products.Add(new Product("collar", 52.000m));
            products.Add(new Product("hamburguesa", 42.000m));
            products.Add(new Product("celular", 432.000m));
            products.Add(new Product("puerta", 98.000m));

            if (option == 1)
            {
                foreach (Product product in products)
                {
                    product.DisplayList();
                }
            }
            else if (option == 2)
            {
                foreach (Product product in products)
                {
                    if (product.Price <= 50.000m)
                    {
                        product.DisplayList();

                    }
                }

            }
            else if (option == 3)
            {
                Console.WriteLine("ingrese el nombre del producto deseado:");
                string productSearch = Console.ReadLine();
                foreach (Product product in products)
                {
                    if (product.Name.Equals(productSearch))
                    {
                        Console.WriteLine($"si existe el producto: {product.Name}\n y su precio es: {product.Price}");
                    
                    }else if(!product.Name.Equals(productSearch)){
                        Console.WriteLine("Error. producto no valido");
                    }


                }

            }





        }
    }
}