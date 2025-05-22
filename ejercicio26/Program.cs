using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task("hacerme la paja", 1);
            Task task2 = new Task("Metersela a maikol", 2);
            Task task3 = new Task("callar a poveda", 5);
            Task task4 = new Task("no hacer nada", 1);

            TaskList taskList = new TaskList();
            Console.Clear();
            taskList.AddTask(task1);
            taskList.AddTask(task2);
            taskList.AddTask(task3);
            taskList.AddTask(task4);
            taskList.DisplayList();

            
        }
    }
}