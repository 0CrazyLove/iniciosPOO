using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{

    public class Person
    {
        //atributos privados
        private string name;
        private int age;
        //mi constructor
        public Person(string name, int age)
        {
            this.name = name; 
            this.age = age;
        }
        //metodo para obtener el nombre(Getter)
        public string GetName()
        {
            return name;
        }
        //metodo set para cambiar el name(Setter)
        public void SetName(string newName)
        {
            name = newName;
        }
        //metodo para obtener la edad(Getter)
        public int GetAge()
        {
            return age;
        }
        //metodo set para cambiar la edad (Setter)
        public void SetAge(int NewAge)
        {
            if (NewAge >= 0) //validar que la edad no sea negativa
            {
                age = NewAge;
            }
            else
            {
                Console.WriteLine("la edad no puede ser negativa");
            }
            
        }


    }
}
