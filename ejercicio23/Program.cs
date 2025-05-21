using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio22;

namespace ejercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListTask listTask = new ListTask();
            listTask.AddTask("independizarme");
            listTask.AddTask("conseguir pareja");
            listTask.AddTask("masturbarme >:)");
            listTask.DisplayTask();
        }
    }
}