using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio33
{
    class Developer : IWorker
    {
        private string state = String.Empty;
        private bool working;

        public void Work(string task)
        {
            state = task;
            working = true;
        }

        public bool IsWorking()
        {
            System.Console.Write($"esta trabajando? ");
            return working;

        }
        public string GetStatus()
        {
            System.Console.Write($"Estado actual: ");
            return state;
        }
    }
}
