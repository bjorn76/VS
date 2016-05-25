using System;
using Microsoft.Win32;

//https://msdn.microsoft.com/en-us/library/3dwk5axy%28v=vs.110%29.aspx


//
// This code will change your Office 14 / 2010 user name
//

namespace RegOffCon
{
    class RegOffCon
    {
        public static void Main (string[] args)
        {
            // The name of the key must include a valid root.
            const string userRoot = "HKEY_CURRENT_USER";
          

            // Software\Microsoft\Office\Common\UserInfo
            const string subkey01 = "Software";
            const string subkey02 = "Microsoft";
            const string subkey03 = "Office";
            const string subkey04 = "Common";
            const string subkey05 = "UserInfo";

            string keyname;
            keyname = userRoot + "\\" + subkey01;
            keyname += "\\" + subkey02;
            keyname += "\\" + subkey03;
            keyname += "\\" + subkey04;
            keyname += "\\" + subkey05;


            string ChangeValue = "n";
            string ValueName1= "Default";
            string WinUserName, ComputerName, newname;

            //Console.WriteLine("\r\n{0}", keyname);
            ValueName1 = (string)Registry.GetValue(keyname,"UserName", "No value found value in registry.");
            WinUserName= Environment.UserName;
            ComputerName = Environment.MachineName;
            newname = WinUserName + "_" + ComputerName;

            Console.WriteLine("\r\n Welcome {0} to Björn J.'s MS Office User re-namer.", WinUserName);
            Console.WriteLine("\r\n Your MS Office User Name is: {0}", ValueName1 );
            //Console.WriteLine("\r\n Your Win User name: {0}", WinUserName);
            //Console.WriteLine("\r\n Your Computer name: {0}", ComputerName);

            Console.WriteLine("\r\n Press \"y\" (and enter) to change Office User Name to {0}.",newname);


            ChangeValue = Console.ReadLine();
            if (ChangeValue== "y")
            {
                
                Console.WriteLine("\r\n You have changed your MS Office User Name to: {0}", newname);
                Registry.SetValue(keyname, "UserName", newname);
            }


            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();



        }
    }
}

