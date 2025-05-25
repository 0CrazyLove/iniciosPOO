using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio31
{
    class Motorcycle : IVehicle
    {
        public void drive()
        {
            System.Console.WriteLine("esta moto esta conduciendo en el aire!!!");
        }

    }
}