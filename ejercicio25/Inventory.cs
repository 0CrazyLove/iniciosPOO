using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio25
{
    public class Inventory
    {
        //atributo pivado de la clase
        private List<Product> products;

        //constructor 
        public Inventory()
        {
            products = new List<Product>();
        }

        //metodo para añadir productos
        public void AddProduct(Product productAdd)
        {
            products.Add(productAdd);
        }
        //metodo para mostrar productos
        public void DisplayProduct()
        {
            System.Console.WriteLine("Lista de productos del inventario: ");
            foreach (Product produc in products)
            {
                System.Console.WriteLine($"Nombre del producto: {produc.Name}");
                System.Console.WriteLine($"Precio del producto {produc.Name}: ${produc.Price.ToString()}COP ");
                System.Console.WriteLine($"Descripcion del producto {produc.Name}: {produc.Description}");
                System.Console.WriteLine("--------------------------------------------------------------------");
            }
        }

    }
}
