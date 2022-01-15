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



        [STAThread]
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


            if (ADemail.Length > 3) { 
                Console.WriteLine("Email found in AD: {0}", ADemail);
                System.Windows.Clipboard.SetText(ADemail);
                Console.WriteLine("(Email is found in clipboard)");
                
            }
            else { 
                //Console.WriteLine("An email was not found in AD ({0})", usr);
                Console.WriteLine("An email was not found in AD");
            }





            Console.WriteLine("\r\nPress Escape to exit");
            rk = Console.ReadKey();
            //if (rk.Key != ConsoleKey.Escape) { 
            //  Console.WriteLine("\r\n ({0})", rk.KeyChar);
            //}

            //Console.ReadKey();


        }

   


            static public string GetUserEmail(string UserId)
        {

            //UserId = UserId.Replace(" ", ".");

            var searcher = new DirectorySearcher("LDAP://" + UserId.Split('\\').First().ToLower())
            {
                //Filter = "(&(ObjectClass=person)(sAMAccountName=" + UserId.Split('\\').Last().ToLower() + "))" //sAMAccountName is older windows
                Filter = "(&(objectCategory=User)(ObjectClass=person)(mail=" + UserId.Split('\\').Last().ToLower() + "*))"
                // not work Filter = "(&(objectCategory=User)(ObjectClass=person)(displayName=" + UserId.Split('\\').Last().ToLower() + "*))"

            };


            // specify which property values to return in the search
            //searcher.PropertiesToLoad.Add("givenName");   // first name
            //searcher.PropertiesToLoad.Add("sn");          // last name
            //searcher.PropertiesToLoad.Add("mail"); distinguishedName


            var result = searcher.FindOne();
            if (result == null)
                return string.Empty;

            return result.Properties["distinguishedName"][0].ToString();
            //return result.Properties["sn"][0].ToString();
            //return result.Properties["mail"][0].ToString();
            // userPrincipalName
            //

            //return result.ToString();

        }


    }
}