using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker dev = new Developer();
            dev.Work("Corrigiendo bugs");
            System.Console.WriteLine(dev.IsWorking());
            System.Console.WriteLine(dev.GetStatus());

        }
    }
}
