using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;

namespace CheckCredential
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop indefinitely
            {
                Console.WriteLine("User Name : ");
                string UName = Console.ReadLine();
                Console.WriteLine("Password : ");
                string Pwd = Console.ReadLine();
                Console.WriteLine(Credential.ValidCredantial(UName, Pwd).ToString());
            }
        }
    }

    public static class Credential
    {

        public static bool ValidCredantial(string UName, string Pwd, string Dmn = null)
        {

            if (Dmn != null)
            {

                //bool valid = false;
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
                {
                    return context.ValidateCredentials(UName, Pwd);
                }
            }
            else
                using (PrincipalContext context = new PrincipalContext(ContextType.Machine))
                {
                    return context.ValidateCredentials(UName, Pwd);
                }
           // return false;

        }

    }
}
