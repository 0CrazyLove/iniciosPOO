using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio26
{

    public class Task
    {
        
        //atributos propios de Task
        private string name;
        private int priority;
        //constructor 
        public Task(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }

        //propiedad de name
        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    System.Console.WriteLine("Error. Nombre no valido");
                }
            }
        }
        public int Priority
        {
            get { return priority; }
            set
            {
                if (!(value <=0) )
                {
                    this.priority = value;
                }
                else
                {
                    System.Console.WriteLine("Error. no se puede asignar valores nulos o negativos");
                }
            }
        }
        
    }

}