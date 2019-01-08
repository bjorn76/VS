using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;


namespace Console_GetEmail
{
    class GetEmail
    {



        static void Main(string[] args)
        {
            string usr;
            string ADemail;
            ConsoleKeyInfo rk;


            //do {
              //Todo add repeat
            //} while (true);




            Console.WriteLine("Enter user name:");
            usr = Console.ReadLine();

            Console.WriteLine("Look up email...({0})", usr);

            ADemail = GetUserEmail(usr);


            if (ADemail.Length > 3)
                Console.WriteLine("Email found in AD: {0}", ADemail);
            else
                //Console.WriteLine("An email was not found in AD ({0})", usr);
                Console.WriteLine("An email was not found in AD");



            Console.WriteLine("\r\nPress Escape to exit");
            rk = Console.ReadKey();
            //if (rk.Key != ConsoleKey.Escape) { 
            //  Console.WriteLine("\r\n ({0})", rk.KeyChar);
            //}

            //Console.ReadKey();


        }

   


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


    }
}