using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gerente o desarrolador?");
            string employee = Console.ReadLine();
            if (employee.ToLower() == "gerente")
            {
                //isntancia del objeto Manager
                Console.Write("Nombre del gerente: ");
                string nameManager = Console.ReadLine();
                string inputSalary;
                double salaryManager = 0;
                do
                {
                    Console.Write("Salario: ");
                    inputSalary = Console.ReadLine();
                } while (!double.TryParse(inputSalary, out salaryManager));
                Console.Write("Departamento que gestiona: ");
                string department = Console.ReadLine();
                Manager manager = new Manager(nameManager, salaryManager, department);
                manager.DisplayInformationEmployee();
                manager.DisplayDepartment();
            }
            else if (employee.ToLower() == "desarrolador")
            {


                //istancia del objeto developer
                Console.Write("Nombre del desarrolador: ");
                string nameDeveloper = Console.ReadLine();
                string inputSalaryDeveloper;
                double salaryDeveloper = 0;
                do
                {
                    Console.Write("Salario: ");
                    inputSalaryDeveloper = Console.ReadLine();
                } while (!double.TryParse(inputSalaryDeveloper, out salaryDeveloper));

                Console.Write("lenguaje especializado: ");
                string lenguageDeveloper = Console.ReadLine();
                Developer developer = new Developer(nameDeveloper, salaryDeveloper, lenguageDeveloper);
                developer.DisplayInformationEmployee();
                developer.DisplayLenguage();
            }
            else
            {
                Console.WriteLine("Error. trabajo incorrecto \n Intente de nuevo: ");
                Main(args);

            }




        }
    }
}
