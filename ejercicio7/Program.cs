using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product producto = new Product("tomate", 5.000);
            Console.WriteLine($"Producto: {producto.GetName()}");
            Console.WriteLine($"Precio: {producto.GetPrice().ToString("f2")}COP");
            //modificando nombre

            Console.WriteLine("-----------------------------------------------------Productos cambiados-----------------------------------------------");
            producto.SetName("limon");
            producto.SetPrice(200);
            Console.WriteLine($"Producto: {producto.GetName()}");
            Console.WriteLine($"precio: {producto.GetPrice()}COP");

        }
    }
}
