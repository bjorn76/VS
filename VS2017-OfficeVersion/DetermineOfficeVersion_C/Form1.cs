using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
//- 4
using System.Windows.Forms;
//Add a reference to your desired Office App - 1 add reference com excel 12 obj lib
//MS [inset app name here] xx.0 Object Library - 1
//MS Word xx.0 Object Library -1
//Add the imports statement for the .Interop class (PIA) -1
using Microsoft.Office.Interop;
//Office stuff -1
using Microsoft.Win32;
//For registry functions - 2
using System.Reflection;


namespace DetermineOfficeVersion_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Determine_OfficeVersion_1()
        {
            
            //CreateObject Not Present In C#            
            dynamic objEApp = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application")); //Excel object
          

            string strEVersion = null; //To identify version

            //Switch doens't work on dynamic
            if (objEApp.Version == "7.0")
            {
                
                strEVersion = "95";
                
            }

            else if (objEApp.Version == "8.0")

            {
                strEVersion = "97";

            }

            else if (objEApp.Version == "9.0")

            {
                strEVersion = "2000";

            }

            else if (objEApp.Version == "10.0")

            {
                strEVersion = "2002";

            }

            else if (objEApp.Version == "11.0")

            {
                strEVersion = "2003";

            }

            else if (objEApp.Version == "12.0")

            {
                
                strEVersion = "2007";

            }

            else if (objEApp.Version == "14.0")

            {

                strEVersion = "2010";

            }

            MessageBox.Show("Excel Version: " + strEVersion);

            objEApp.Quit();//quit
            
            objEApp = null;

        }

        private void Determine_OfficeVersion_2()
        {
            
            string strEVersionSubKey = "\\Excel.Application\\CurVer"; //HKEY_CLASSES_ROOT/Excel.Application/Curver

            string strValue = null; //Value Present In Above Key
            string strVersion = null; //Determines Excel Version

            RegistryKey rkVersion = null; //Registry Key To Determine Excel Version

            rkVersion = Registry.ClassesRoot.OpenSubKey(strEVersionSubKey, false); //Open Registry Key

            if ((rkVersion != null)) //If Key Exists
            {
                strValue = (string)rkVersion.GetValue(string.Empty); //Get Value

                strValue = strValue.Substring(strValue.LastIndexOf(".") + 1); //Store Value

                switch (strValue) //Determine Version
                {
                    case "7":
                        strVersion = "95";
                        break;

                    case "8":
                        strVersion = "97";
                        break;

                    case "9":
                        strVersion = "2000";
                        break;

                    case "10":
                        strVersion = "2002";
                        break;

                    case "11":
                        strVersion = "2003";
                        break;

                    case "12":
                        strVersion = "2007";
                        break;

                    case "14":
                        strVersion = "2010";
                        break;

                }

                MessageBox.Show("Excel " + strVersion + " Installed!"); //Display Result
            }

        }

        private void Determine_OfficeVersion_3(string strVersion)
        {
            Type typOffice = Type.GetTypeFromProgID(strVersion); //Gets the type associated with the specified program identifier (ProgID). ProgID is a valid entry in the registry

            strVersion = strVersion.Substring(strVersion.LastIndexOf(".") + 1); //Get Last 2 Characters in String

            string strTemp = null; //Initialize

            if ((typOffice != null)) //Do We Have A Value?

            {
                
                switch (strVersion) //Determine Version
                {

                    case "7":

                        strTemp = "95";
                        break;

                    case "8":
                        strTemp = "97";
                        break;

                    case "9":
                        strTemp = "2000";
                        break;

                    case "10":
                        strTemp = "2002";
                        break;

                    case "11":
                        strTemp = "2003";
                        break;

                    case "12":
                        strTemp = "2007";
                        break;

                    case "14":
                        strTemp = "2010";
                        break;

                }

                MessageBox.Show("Excel " + strTemp + " Installed"); //Display Result
            }


        }

        private void Determine_OfficeVersion_4()
        {
            //Assembly we're looking for
            string strAssemblyOff2007 = "Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c";

            try // Use Try Instead of IF, Because On Error, Program Will Crash

            {

                Assembly xslExcelAssembly = Assembly.Load(strAssemblyOff2007); //Load Assembly

                if ((xslExcelAssembly != null)) //If Exists

                {

                    MessageBox.Show("Excel 2007 Installed"); //Success!

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Not Installed"); //Don't Exist

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            Determine_OfficeVersion_1();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            Determine_OfficeVersion_2();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            Determine_OfficeVersion_3("Excel.Application.12");

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            Determine_OfficeVersion_4();

        }
    }
}
