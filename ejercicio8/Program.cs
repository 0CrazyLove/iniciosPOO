using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employe1 = new Employee("Miguel", 5.000, "inactivo");
            employe1.DisplayInformation();
            Console.WriteLine("------------------------valores cambiados-------------------------");


            employe1.Name = "Axel";
            employe1.Salary = 20.000;
            employe1.EmployeeStatus = "activo";
            employe1.DisplayInformation();

            Console.WriteLine(employe1.Name);





        }
    }
}
