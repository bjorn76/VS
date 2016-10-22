//using Shell32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SCEdt
{
    class Program
    {
        // References to read
        //https://social.msdn.microsoft.com/Forums/vstudio/en-US/b25e2b8f-141a-4a1c-a73c-1cb92f953b2b/instantiate-shell32shell-object-in-windows-8?forum=clr
        //http://stackoverflow.com/questions/26646068/getting-metadata-information-from-a-file-using-c-sharp
        //http://www.devsplanet.com/question/35957669
        //http://stackoverflow.com/questions/5708434/how-to-use-shell32-within-a-c-sharp-application


        /*
        The target in the lnk file (shortcut) "
        "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Administrative Tools\Data Sources (ODBC).lnk" is incorrect in the 64 bit verison of win 7.
        The ODBC Data Source Administrator NOT to use is: 
        "%windir%\system32\odbcad32.exe" 

        And should be replaced by:
        "C:\Windows\SysWOW64\odbcad32.exe"

        This program to this for you


        */



        [STAThread]
        static void Main(string[] args)
        {
            string sLnkFile, sOldTarget, sNewTarget, rl, nl;

            nl = Environment.NewLine; //new line = \r\n for windows

            Console.Write(
                           "The shortcut in: " + nl
                           + "\"C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Administrative Tools\\Data Sources (ODBC).lnk\" " + nl
                           + "is incorrect in the 64 bit verison of win 7." + nl + nl
                           + "The ODBC Data Source Administrator NOT to use is: " + nl
                           + "\"%windir%\\system32\\odbcad32.exe\"" + nl + nl
                           + "and should be replaced by: " + nl
                           + "C:\\Windows\\SysWOW64\\odbcad32.exe" + nl
                           + nl
                           + nl
                           + "This program to it for you!" + nl + nl
                         );
                
            sLnkFile = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Administrative Tools\\Data Sources (ODBC).lnk";
            //sLnkFile = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Administrative Tools\\C.lnk"; //debug
          

            sOldTarget = GetLnkTarget(sLnkFile);
            sNewTarget = "C:\\Windows\\SysWOW64\\odbcad32.exe";
            //sNewTarget = "%windir%\\system32\\calc.exe"; //Debug
            
            Console.WriteLine("Old lnk target in \"" + sLnkFile + "\" is:");
            Console.WriteLine("\""+ sOldTarget + "\"");
            Console.WriteLine();       
            Console.WriteLine("Change target to: \"" + sNewTarget + "\" ? (Press Y to confirm)");
            rl=Console.ReadLine();
            if (rl == "Y")
            {
                Console.WriteLine("Renaming...");
                SetLnkTarget(sLnkFile, sNewTarget);
                Console.WriteLine("...completed.");
            }
            else
            {
                Console.WriteLine("Nothing changed");
            }
            Console.WriteLine("Press Return to exit");
            rl = Console.ReadLine();


        }
        


 
        public static string GetLnkTarget(string shortcutFullPath)
        {
                
            try
            {
                Shell32.Shell shell = new Shell32.Shell();
                Shell32.Folder folder = shell.NameSpace(Path.GetDirectoryName(shortcutFullPath));
                Shell32.FolderItem folderItem = folder.Items().Item(Path.GetFileName(shortcutFullPath));
                Shell32.ShellLinkObject currentLink = (Shell32.ShellLinkObject)folderItem.GetLink;
                return currentLink.Path;


            }
            
            catch (NullReferenceException nrEx)
            {
                Console.WriteLine (nrEx.Message);
                return ("NullReferenceException");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return ("Exception");
            }



        }

        public static void SetLnkTarget(string shortcutFullPath, string newTarget)
        
        {
            try
            {
                // Load the shortcut.
                Shell32.Shell shell = new Shell32.Shell();

                Shell32.Folder folder = (Shell32.Folder)shell.NameSpace(Path.GetDirectoryName(shortcutFullPath));
                Shell32.FolderItem folderItem = folder.Items().Item(Path.GetFileName(shortcutFullPath));
                Shell32.ShellLinkObject currentLink = (Shell32.ShellLinkObject)folderItem.GetLink;

                //Assign the new path here. This value is not read-only.
                currentLink.Path = newTarget;


                // Save the link to commit the changes.
                currentLink.Save();

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }




        // Not in use below =======================================================================================
        /*

            public static string GetLnkTarget5(string file)
        {
            // Load the shortcut.
            string filename = Path.GetFileName(file);
            //Shell32.Shell shell = new Shell32.Shell();
            // Shell32.Folder folder = shell.NameSpace(Path.GetDirectoryName(shortcutFullPath));
            Shell32.Folder rFolder = GetShell32NameSpaceFolder(Path.GetDirectoryName(file));
            //Shell32.FolderItem folderItem = folder.Items().Item(Path.GetFileName(shortcutFullPath));
            Shell32.FolderItem rFiles = rFolder.ParseName(filename);
            // Shell32.ShellLinkObject currentLink = (Shell32.ShellLinkObject)folderItem.GetLink;
            //return currentLink.Path;
            return "hej";
        }
        


        private static Shell32.Folder GetShell32NameSpaceFolder(Object folder)
        {
            var shellAppType = Type.GetTypeFromProgID("Shell.Application");

            var shell = Activator.CreateInstance(shellAppType);
            return (Shell32.Folder)shellAppType.InvokeMember("NameSpace",
            System.Reflection.BindingFlags.InvokeMethod, null, shell, new[] { folder });
        }


     
        public static string GetLnkTarget2(string lnkPath)
        {
            var shl = new Shell32.Shell();
            lnkPath = System.IO.Path.GetFullPath(lnkPath);
            var dir = shl.NameSpace(System.IO.Path.GetDirectoryName(lnkPath));
            var itm = dir.Items().Item(System.IO.Path.GetFileName(lnkPath));
            var lnk = (Shell32.ShellLinkObject)itm.GetLink;
            return lnk.Target.Path;
        }
        */




    }
}
