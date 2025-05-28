using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
    class ServiceManager
    {
        //atributo lista privada
        private List<IService> services = new List<IService>();

        //metodo para agregar un servicio
        public void AddService(Service service)
        {
            services.Add(service);
        }

        public List<IService> ObtenerServicios()
        {
            return services;
        }


        //metodo para buscar el servicio por nombre
        public void ServiceSearch(string name)
        {
            bool found = false;
            foreach (Service sv in services)
            {

                if (sv.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    System.Console.WriteLine("El servicio se ha encontrado!!");
                    System.Console.WriteLine($"ID del servicio: {sv._ID}");
                    System.Console.WriteLine($"nombre del servicio : {sv.Name}");
                    System.Console.WriteLine($"descripcion del servicio : {sv.Description}");
                    System.Console.WriteLine($"Precio base del servicio : {sv.PriceBase}");
                    System.Console.WriteLine("----------------------------------");
                    found = true;
                    break;

                }
            }
            if (!found)
            {
                System.Console.WriteLine("el servicio no existe..,");
            }

        }


      


    }
}