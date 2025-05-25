using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio35
{
    class EmailLogin : ILoginMethod
    {
        private string email = "admin@gmail.com";
        private string password = "1234%";



        public bool Authenticate(string userEmail, string password)
        {
            bool autenticacion =false;
            if (userEmail.Equals(email) && password.Equals(this.password))
            {
                System.Console.WriteLine("la auntenticacion ha sido correcta.");
                autenticacion = true;
            }
            if (!autenticacion)
            {
                System.Console.WriteLine("la auntenticacion ha fallado...");
            }
            return autenticacion;
        }
        public string GetLoginType()
        {
            return "Login con correo.";
        }

    }
}
