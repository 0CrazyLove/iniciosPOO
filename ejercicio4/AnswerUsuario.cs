using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{

    public class AnswerUsuario
    {

        public string Answer;
        




        public AnswerUsuario(string answer)
        {
            Answer = answer;
        }




        public void Thank()
        {
            Console.WriteLine("gracias por tu opion :)");


        }

        public void answerCuestion()
        {
            if (Answer.Equals("si"))
            {

                Console.WriteLine("Ya lo sabia miguel.");

            }
            else if (Answer.Equals("no"))
            {
                Console.WriteLine("Mentiroso");
                Environment.Exit(0);//este metodo termina el programa
                

            }
            else
            {
                Console.WriteLine("No valido.");
                Environment.Exit(0);//este metodo termina el programa

            }

        }

    }

    


}


