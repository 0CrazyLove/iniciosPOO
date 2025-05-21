using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio22
{
    class ListTask
    {
        //atributo privado de la clase 
        private List<string> task;
        //constructor
        public ListTask()
        {
            task = new List<string>();
        }
        //metodo para agregar taraa
        public void AddTask(string taskAdd)
        {
            task.Add(taskAdd);

        }
        //metodo para monstrar tarea
        public void DisplayTask()
        {
            System.Console.WriteLine("listas de tareas: ");
            foreach (string taks in task)
            {
                System.Console.WriteLine($"->{taks}");
            }
        }



    }
}