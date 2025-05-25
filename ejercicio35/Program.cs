using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ILoginMethod> loginMethod = new List<ILoginMethod>();
            loginMethod.Add(new EmailLogin());
            loginMethod.Add(new SocialMediaLogin());

            if(loginMe)
            foreach (ILoginMethod login in loginMethod)
            {
                login.Authenticate("admin@gmail.com", "1234%");
                login.Authenticate("user_social", "abcd%");
                System.Console.WriteLine(login.GetType());
                System.Console.WriteLine("-------------");
            }
        }
    }
}
