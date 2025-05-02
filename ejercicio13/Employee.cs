using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Employee
    {
        //atributos protegidos
        protected string name;
        protected double salary;
        //constructor
        public Employee(string name, double salary)
        {
            this.name = name;

            if (salary <= 0)
            {
                Console.WriteLine("No se permite numeros negativos");
            }
            else
            {
                this.salary = salary;

            }


        }
        //metodo para mostrar informacion
        public void DisplayInformationEmployee()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Nombre del empleado: {name}");
            Console.WriteLine($"Salario del empleado: {salary.ToString("f3")}");
            



        }

    }
    //clase derivada de la clase base Employee
    class Manager : Employee
    {
        //atributo adiicional
        protected string department;
        public Manager(string name, double salary, string department) : base(name, salary)
        {

            this.department = department;

        }
        //metodo para mostrar que departamento gestiona
        public void DisplayDepartment()
        {
            Console.WriteLine($"Departamento que gestiona {name}: {department}");
            Console.WriteLine("---------------------------------------------------");
        }

    }

    class Developer : Employee
    {
        //atributo adicional
        protected string lenguageFavorite;
        //constructor
        public Developer(string name , double salary , string lenguageFavorite) : base(name , salary)
        {
            this.lenguageFavorite = lenguageFavorite;


        }
        //metodo para obtener la informacion de que lenguaje utiliza
        public void DisplayLenguage()
        {
            Console.WriteLine($"lengueje favorito de{name}: {lenguageFavorite}");
            Console.WriteLine("---------------------------------------------------");
        }
        

        

    }

}
