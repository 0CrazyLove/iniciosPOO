using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando objeto de la clase padre Employee
            Employee employee = new Employee("miguel", 20, 53.2882m);
            employee.DisplayInfo();

            //instanciando objeto de la clase derivada Developer
            Developer developer = new Developer("axel", 18, 800.000m, "c#");
            developer.DisplayInfo();

            //instanciando objeto de la clase derivada Designer
            Designer designer = new Designer("maikol", 18, 100.000m, 5);
            designer.DisplayInfo();
        }
    }
}
