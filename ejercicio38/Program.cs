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
            var serviceManager = new ServiceManager();
            

            bool active = false;
            while (!active)
            {


                Console.WriteLine(@"MENÚ DE PRODUCTOS
            1. Agregar nuevo servicio
            2. Ver todos los servicios
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
                                var serviceDesigner = new ServiceDesigner(nameServiceDesigner!, descriptionServiceDesigner!, priceBaseServiceDesigner);
                                serviceManager.AddService(serviceDesigner);


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
                                if (!exitoHours)
                                {
                                    throw new Exception("Ingrese una cantidad de hora valida.");
                                }
                                var serviceDeveloper = new ServiceDeveloper(nameServiceDeveloper!, descriptionServiceDeveloper!, priceBaseServiceDeveloper, hours);
                                serviceManager.AddService(serviceDeveloper);
                            }
                            else if (optionService.Equals(3))
                            {
                                System.Console.WriteLine("Has elegido: Servicio de Fotografia.");
                                System.Console.Write("Ingrese el nombre del servicio: \n>");
                                string? nameServicePhotograph = Console.ReadLine();
                                System.Console.Write("Ingrese la descripción: \n>");
                                string? descriptionServicePhotograph = Console.ReadLine();
                                System.Console.Write("Ingrese el precio basae: \n>");
                                decimal priceBaseServicePhotograph;
                                bool exitoPriceBaseServicePhotograph = decimal.TryParse(Console.ReadLine(), out priceBaseServicePhotograph);
                                if (!exitoPriceBaseServicePhotograph)
                                {
                                    throw new Exception("Escriba un precio valido.");
                                }
                                System.Console.Write("Ingrese la cantidad de fotos del servicio \n>");
                                int amountPhotos;
                                bool exitoAmountPhotos = int.TryParse(Console.ReadLine(), out amountPhotos);
                                if (!exitoAmountPhotos)
                                {
                                    throw new Exception("Ingrese una cantidad de fotos valida.");
                                }
                                var servicePhotograph = new ServicePhotograph(nameServicePhotograph!, descriptionServicePhotograph!, priceBaseServicePhotograph, amountPhotos);
                                serviceManager.AddService(servicePhotograph);

                            }

                        }
                        else
                        {
                            System.Console.WriteLine("Error. escoja una opcion valida");
                        }


                    }
                    else if (option.Equals(2))
                    {
                        if (serviceManager)
                        {
                            
                        }
                        serviceManager.DisplayServices();

                    }



                }
            }

        }
    }
}
