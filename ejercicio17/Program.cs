using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lista de estudiantes
            List<Student> listasEstudiantes = new List<Student>();
            //agregando estudiantes a la lista
            
            listasEstudiantes.Add(new Student("crazy", 16));
            listasEstudiantes.Add(new Student("miguel", 20));
            listasEstudiantes.Add(new Student("maikol", 16));

            //mostrando lista de estudiantes usando foreach

            Console.WriteLine("Listas de estudiantes: ");
            foreach (Student est in listasEstudiantes)
            {
                est.DisplayInfo();
            }
            Console.WriteLine($"total de estudiantes: {listasEstudiantes.Count}");





        }
    }
}