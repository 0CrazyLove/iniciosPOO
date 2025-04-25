using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿eres gay? (si/no)");
            string answer = Console.ReadLine();
            AnswerUsuario usuario = new AnswerUsuario(answer);
            usuario.answerCuestion();
            Console.WriteLine("¿Quieres dejar una opion?");
            string answerOpinion = Console.ReadLine();
            OpinionUsuario opinion = new OpinionUsuario(answerOpinion);
            opinion.OpinionAnswer();
            string opinionUsuario = Console.ReadLine();
            usuario.Thank();

            







        }
    }
}
