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
            if (exito)
            {


                if (option.Equals(1))
                {
                    System.Console.WriteLine(@" 
                    1) Servicio de Diseño
                    2) Servicio de Programación
                    3) Servicio de Fotografía");

                    int optionService;
                    bool exitoOption = int.TryParse(Console.ReadLine(), out optionService);
                    if (exitoOption)
                    {
                        if (option.Equals(1))
                        {
                            System.Console.WriteLine("Has elegido: Servicio de Diseño.");
                            System.Console.WriteLine("Ingrese el nombre del servicio: \n>");
                            string? nameService = Console.ReadLine();
                            System.Console.WriteLine("Ingrese la descripción: \n>");
                            string? descriptionService = Console.ReadLine();
                            System.Console.WriteLine("Ingrese el precio basae: \n>");
                            decimal priceBaseService;
                            bool exitoPriceBaseService = decimal.TryParse(Console.ReadLine(), out priceBaseService);
                            if (!exitoPriceBaseService)
                            {
                                throw new Exception("Escriba un precio valido.");
                            }
                            ServiceDesigner serviceDesigner = new ServiceDesigner(nameService! , descriptionService!, priceBaseService);
                            serviceDesigner.DisplayInfo();
                        


                        }

                    }


                }


            }

        }
    }
}
