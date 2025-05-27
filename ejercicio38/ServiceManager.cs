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
        private List<Service> services = new List<Service>();
        //metodo para agregar un servicio
        public void AddService(Service service)
        {
            services.Add(service);
        }

        //metodos para ver todo los servicios
        public void DisplayServices()
        {
            System.Console.WriteLine("Listas de servicios:");
            foreach (Service sv in services)
            {
                System.Console.WriteLine($"Nombres de los servicios: {sv.Name}");
            }
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
                    System.Console.WriteLine($"nombre del servicio : {sv.Name}");
                    System.Console.WriteLine($"descripcion del servicio : {sv.Description}");
                    System.Console.WriteLine($"Precio base del servicio : {sv.PriceBase}");
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