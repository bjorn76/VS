using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SetDefender
{
    class SetDefender
    {
        static string keypath;
        
        static void appendkeypath( string key)
        {
            if (keypath == "") 
                keypath = key;
            else
                keypath = keypath + "\\" + key;
            

        }



        static void Main(string[] args)
        {
            keypath = "";

            // Software\Microsoft\Office\Common\UserInfo
            appendkeypath("HKEY_CURRENT_USER");
            appendkeypath("Software");
            appendkeypath("Microsoft");
            appendkeypath("Office");
            appendkeypath("Common");
            appendkeypath("UserInfo");


            string keyvalue;
            keyvalue = (string)Registry.GetValue(keypath, "UserName", "No value found value in registry.");

            Console.WriteLine(keypath);
            Console.WriteLine(keyvalue);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();


        }
    }
}
