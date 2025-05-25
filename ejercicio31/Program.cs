using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicle = new List<IVehicle>();
            vehicle.Add(new Car());
            vehicle.Add(new Motorcycle());
            foreach (IVehicle vehicles in vehicle)
            {
                vehicles.drive();
            }
        

        }
    }
}
