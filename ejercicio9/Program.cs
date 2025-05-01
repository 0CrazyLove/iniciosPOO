using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduce tu nombre: ");
            string nameUsario = Console.ReadLine();
            Console.Write("Introduce tu contraseña: ");
            int passwordUsuario = 0;
            try
            {
                passwordUsuario = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                
                Console.WriteLine("Error: solo se permite numeros");
                Main(args);

            }
                Usuarios usuario = new Usuarios(nameUsario, passwordUsuario);
            Console.WriteLine("--------------------------------------------------------------------------------- ");
            usuario.DisplayInformation();
            Console.WriteLine("¿Quieres cambiar tu contraseña? (si/no)");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "si")
            {
                Console.Write("Introduce tu nueva contraseña: ");
                int passwordNew = 0;
                try
                {
                    passwordNew = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Error: solo se permite numeros");

                }

                Usuarios usuario2 = new Usuarios(nameUsario, passwordNew);
                Console.WriteLine("--------------------------------------------------------------------------------- ");
                usuario2.DisplayInformation();



            }
            else if (answer.ToLower() == "no")
            {
                Console.WriteLine("No se ha cambiado la contraseña");
            }
            else
            {
                Console.WriteLine("Error: respuesta no valida");
            }





        }
    }
}
