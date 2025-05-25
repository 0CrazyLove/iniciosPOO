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


            foreach (ILoginMethod login in loginMethod)
            {
                if (login is EmailLogin)
                {
                    login.Authenticate("admin@gmail.com", "1234%");
                    System.Console.WriteLine(login.GetLoginType());
                }
                if (login is SocialMediaLogin)
                {
                    login.Authenticate("user_social", "abcd%");
                    System.Console.WriteLine(login.GetLoginType());
                    
                }
            
            }
        }
    }
}
