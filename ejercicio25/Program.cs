using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando la clase Inventory
            Inventory inventory = new Inventory();
            //instanciando la clase Product y agreando algunos productos exoticos
            Product product1 = new Product("dildo", 60.000m, "grande y largo para la gente atrevida ;)");
            Product product2 = new Product("chatGptPro4kFull", 1.000m, "chat gpt chipeado y tuneado 100% real no fake");
            Product product3 = new Product("plug anal", 93.000m, "Para tu amigo que no sale del closet todavia jeje");
            //agregando los productos a la lista
            inventory.AddProduct(product1);
            inventory.AddProduct(product2);
            inventory.AddProduct(product3);
            //mostrando lista de producto
            inventory.DisplayProduct();

        }
    }
}