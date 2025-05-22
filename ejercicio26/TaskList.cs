using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio26
{
    public class TaskList
    {
        //atributo privado de la clase TaskList
        private List<Task> tasks;
        //constructor para inicializar la lista de tipo Task en la clase TaskList
        public TaskList()
        {
            tasks = new List<Task>();
        }

        //metodo para añadir objetos en la lista de la clase TaskList
        public void AddTask(Task taskAdd)
        {
            tasks.Add(taskAdd);
        }
        //metodo para mostrar lista
        public void DisplayList()
        {
            System.Console.WriteLine("Lista de tareas y su prioriedad (mayor , menor prioridad \n menor numero, mayor prioridad ):");
            foreach (Task tk in tasks)
            {
                System.Console.WriteLine($"Nombre de la tarea: {tk.Name}");
                System.Console.WriteLine($"Prioridad de la tarea {tk.Name}: {tk.Priority}");
                System.Console.WriteLine("-----------------------------------------------------");
            }
        }

        
    }
}