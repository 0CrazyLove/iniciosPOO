using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio33
{
    public interface IWorker
    {
        void Work(string task); //task significa tarea
        bool IsWorking();
        string GetStatus();
    }
}