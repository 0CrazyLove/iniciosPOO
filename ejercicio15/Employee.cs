using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio15
{
    class Employee
    {

        private string name;
        private int age;
        private decimal salaryBase;


        //Constructor
        public Employee(string name, int age, decimal salaryBase)
        {

            Name = name;
            Age = age;
            SalaryBase = salaryBase;

        }

        //propiedad publica de name
        public string Name
        {

            get { return name; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {

                    Console.WriteLine("Introduzca su nombre por favor.");


                }
                else
                {
                    this.name = value;
                }

            }



        }

        //propiedad publica de age
        public int Age
        {


            get { return age; }
            set
            {
                if (value <= 17)
                {

                    Console.WriteLine("Debes de tener minimo 18 años.");


                }
                else
                {
                    this.age = value;


                }


            }

        }
        //propiedad publica de salaryBase

        public decimal SalaryBase
        {
            get { return salaryBase; }
            set
            {

                if (value <= 0)
                {

                    Console.WriteLine("Error. no se permite valor negativo");
                }
                else
                {

                    this.salaryBase = value;
                }



            }


        }
        //metodo vituarl de salayBase
        public virtual decimal CalculateSalary()
        {
            return SalaryBase;

        }
        //metodo DisplayInfo
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Emoleado:");
            Console.WriteLine($"nombre: {Name}");
            Console.WriteLine($"edad dd {Name}: {Age}");
            Console.WriteLine($"Salario base: {SalaryBase.ToString("C")}COP");
            Console.WriteLine("---------------------------------------------");

        }


    }














}