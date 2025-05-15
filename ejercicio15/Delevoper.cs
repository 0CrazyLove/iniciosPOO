using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio15
{ 

class Developer : Employee
{
    //atributo propio de la clase derivada
    private string lenguage;

    //constructor

    public Developer(string name, int age, decimal salaryBase, string lenguage) : base(name, age, salaryBase)
    {
        Lenguage = lenguage;

    }

    //propiedad de Lenguage 
    public string Lenguage
    {
        get { return lenguage; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {


                Console.WriteLine("Error. escriba su lenguaje de programacion");
            }
            else
            {

                this.lenguage = value;
            }

        }

    }
    //sobre escribriendo el metodo CalculateSalary

    public override decimal CalculateSalary()
    {
        return SalaryBase + 500;

    }

    //sobre escribiendo el metodo DisplayInfo

    public override void DisplayInfo()
    {
        Console.WriteLine("Desarrolador:");
        Console.WriteLine($"nombre del desarrolador: {Name}");
        Console.WriteLine($"edad de {Name}: {Age}");
        Console.WriteLine($"Salario base mas bono: {CalculateSalary()}COP");
        Console.WriteLine($"lenguaje favorito: {Lenguage}");
        Console.WriteLine("---------------------------------------------");


    }


}
}