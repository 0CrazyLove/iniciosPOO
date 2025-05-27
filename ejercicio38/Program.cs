using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"MENÚ DE PRODUCTOS
            1. Agregar nuevo servicio
            2. Buscar pelicula mediante su titulo
            3. Eliminar pelicula mediante su titulo
            4. Mostrar películas por año
            5. Salir");

            System.Console.Write("Por favor , seleccione una opcion valida->");
            int option;
            bool exito = int.TryParse(Console.ReadLine(), out option);
            if (option.Equals(1))
            {
                
            }
            

            
        }
    }
}
