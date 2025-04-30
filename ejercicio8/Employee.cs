using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Employee
    {
        //atributos privados


        private string name;
        private double salary;
        private string employeeStatus;
        
        //constructor 
        public Employee(string name, double salary, string employeeStatus)
        {
            Name = name;
            Salary = salary;
            EmployeeStatus = employeeStatus;
        }

        //propiedad para el nombre 
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("EL nombre no es valido");

                }
                else
                {
                    name = value;
                }

            }

        }

        //propiedad para el salario

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("El salario debe ser mayor a 0");

                }
                else
                {
                    salary = value;
                }
            }

        }
        //propiedad para el estado del empleado
        public string EmployeeStatus
        {
           get { return employeeStatus; }
            set
            {
                if (value == "activo" || value == "inactivo")
                {
                    employeeStatus = value;
                }
                else
                {
                    Console.WriteLine("El estado del empleado solo debe ser activo o inactivo");
                }
                


            }
        }



        //metodo para mostrar los datos del empleado 
        public void DisplayInformation()
        {

            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Salario: {Salary.ToString("f3")}COP");
            Console.WriteLine($"Estado de empleo: {EmployeeStatus}");



        }


    }
}
