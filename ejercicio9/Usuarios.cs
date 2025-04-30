using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    public class Usuarios
    {
        private string name;
        private int password;

        //constructor
        public Usuarios(string Name, int Password)
        {
            name = Name;
            password = Password;
        }

        //metodo de cambiar el name

        public string Name
        {

            get { return name; }
            set
            {

                if (string.IsNullOrEmpty(value))
                {


                    Console.WriteLine("Error: nombre no valido");

                }
                else
                {
                    name = value;
                }

            }
        }

        //metodo para cambiar la comtraseña
        public int Password
        {

            get { return password; }
            set
            {
                if (value == password)
                {
                    password = value;

                }
                else
                {

                    Console.WriteLine("Contraseña incorrecta");
                }

            }

        }


        //metodo para mostrar la informacion
        public void DisplayInformation()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Contraseña: {Password}");
        }


    }
}
