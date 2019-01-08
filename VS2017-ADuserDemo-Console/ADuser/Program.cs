using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;


namespace ConsoleApp1
{
    class Program
    {

        static public string GetUserEmail(string UserId)
        {

            var searcher = new DirectorySearcher("LDAP://" + UserId.Split('\\').First().ToLower())
            {
                Filter = "(&(ObjectClass=person)(sAMAccountName=" + UserId.Split('\\').Last().ToLower() + "))"
            };

            var result = searcher.FindOne();
            if (result == null)
                return string.Empty;

            return result.Properties["mail"][0].ToString();

        }
        


        static void Main(string[] args)
        {
            string usrEnv;
            string ADemail;

            

            usrEnv = Environment.UserName;
            usrEnv = usrEnv.ToLower();
            Console.WriteLine("\r\n Your AD User Name is: {0}", usrEnv);


            ADemail = GetUserEmail(usrEnv);
            
            Console.WriteLine("\r\n Your Email found in AD is: {0}", ADemail);
            Console.WriteLine("\r\n Press Enter to exit");
            Console.ReadKey();

        }


    }
}
