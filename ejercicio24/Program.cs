using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio22;
using ejercicio24;

namespace ejercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Product product1 = new Product("chatgptPro", 89.000m);
            Product product2 = new Product("noviaLinda", 10.000m);
            Product product3 = new Product("pcGamer", 2.000m);

            car.AddProduct(product1);
            car.AddProduct(product2);
            car.AddProduct(product3);
            car.DisplayProduct();
            

        }
    }
}