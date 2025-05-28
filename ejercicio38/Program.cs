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
            bool active = false;
            while (!active)
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
                        System.Console.Write("Por favor , seleccione una opcion valida->");

                        int optionService;
                        bool exitoOption = int.TryParse(Console.ReadLine(), out optionService);
                        if (exitoOption)
                        {
                            if (optionService.Equals(1))
                            {
                                System.Console.WriteLine("Has elegido: Servicio de Diseño.");
                                System.Console.Write("Ingrese el nombre del servicio: \n>");
                                string? nameServiceDesigner = Console.ReadLine();
                                System.Console.Write("Ingrese la descripción: \n>");
                                string? descriptionServiceDesigner = Console.ReadLine();
                                System.Console.Write("Ingrese el precio basae: \n>");
                                decimal priceBaseServiceDesigner;
                                bool exitoPriceBaseService = decimal.TryParse(Console.ReadLine(), out priceBaseServiceDesigner);
                                if (!exitoPriceBaseService)
                                {
                                    throw new Exception("Escriba un precio valido.");
                                }
                                ServiceDesigner serviceDesigner = new ServiceDesigner(nameServiceDesigner!, descriptionServiceDesigner!, priceBaseServiceDesigner);


                            }
                            else if (optionService.Equals(2))
                            {
                                System.Console.WriteLine("Has elegido: Servicio de Programacion.");
                                System.Console.Write("Ingrese el nombre del servicio: \n>");
                                string? nameServiceDeveloper = Console.ReadLine();
                                System.Console.Write("Ingrese la descripción: \n>");
                                string? descriptionServiceDeveloper = Console.ReadLine();
                                System.Console.Write("Ingrese el precio basae: \n>");
                                decimal priceBaseServiceDeveloper;
                                bool exitoPriceBaseServiceDeveloper = decimal.TryParse(Console.ReadLine(), out priceBaseServiceDeveloper);
                                if (!exitoPriceBaseServiceDeveloper)
                                {
                                    throw new Exception("Escriba un precio valido.");
                                }
                                System.Console.Write("Ingrese la cantidad de hora de servicio \n>");
                                int hours;
                                bool exitoHours = int.TryParse(Console.ReadLine(), out hours);
                                if(!exitoHours){
                                    throw new Exception("Ingrese una cantidad de hora valida.");
                                }
                                ServiceDeveloper serviceDeveloper = new ServiceDeveloper(nameServiceDeveloper!, descriptionServiceDeveloper! , priceBaseServiceDeveloper, hours);
                            }

                        }


                    }
                   


                }
            }

        }
    }
}
