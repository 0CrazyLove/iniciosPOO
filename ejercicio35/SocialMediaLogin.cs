using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio35
{
    class SocialMediaLogin : ILoginMethod
    {
        private string userName = "user_social";
        private string password = "abcd%";

        public bool Authenticate(string UserName, string Password)
        {
            bool autenticacion = false;
            if (UserName.Equals(userName) && Password.Equals(password))
            {
                System.Console.WriteLine("la autenticacion ha sido correcta");
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
            return "Login con redes sociales";
        }
    }
}