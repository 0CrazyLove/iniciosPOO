using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyble flyble = new SuperRobot();
            IRunnable runnable = new SuperRobot();
            flyble.Fly();
            runnable.Run();

        }


    }
}