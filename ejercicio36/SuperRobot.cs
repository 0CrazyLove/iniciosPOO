using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio36
{
    class SuperRobot : IFlyble, IRunnable
    {
        public void Fly()
        {
            System.Console.WriteLine("esta volando");
        }
        public void Run(){
            System.Console.WriteLine("esta corriendo");
        }

    }
}