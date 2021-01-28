using ExcelDna.Integration;
using System;
using System.DirectoryServices;
using System.Linq;

public static class ExcelFunctionCalls
{


    [ExcelFunction(Description = "Reverse string example UDF Function")]
    public static string B2_ReverseString([ExcelArgument(Name = "input_string",
                                                      Description = "String to reverse")]
                                        string input_string)

    {
        string reversestring = "";
        int ilength = input_string.Length - 1;
        while (ilength >= 0)
        {
            reversestring = reversestring + input_string[ilength];
            ilength--;
        }
        return reversestring;
    }


    /*
     https://docs.microsoft.com/en-us/previous-versions/windows/desktop/ldap/using-the-ldap-api-in-a-client-application

     
     Names and emails
     =========================
     name =
     cn = Administrator
     sn = Kwiatek (Last name)
     displayName = is abrivated Disp 
     givenName = Piotr (First name)
     title = .NET Developer
  
     
     IT ID's 
     ========================
     sAMAccountName =
     mail =
     distinguishedName = is abrivated DN
     c = PL (Country Code)
     
     description = 
     objectCategory = CN=Person,CN=Schema,CN=Configuration,DC=helpdesk,DC=wat,DC=edu
     countryCode = 616
    
     whenCreated = 2012-11-23 06:09:28
     whenChanged = 2013-02-23 13:24:41
     wWWHomePage = http://www.piotr.kwiatek.org



     Street, City and Country
     ========================
     not working - st = Mazowieckie (Voivodeship)
     l = Warszawa (City)
     postalCode = 00-000
     postOfficeBox = Warszawa Ursynów
     physicalDeliveryOfficeName = Wojskowa Akademia Techniczna
     co = Poland
     company = HELPDESK
     streetAddress = Kaliskiego 2
   

     ************************************************************** 
     B2_User2DN
     B2_User2Mail B2_mail2user


        Todo:
        Site
        First name
        Last name
        Display name
        
        Could do:
        User Principal Name
        Initials
        Business Unit Code
        Fully qualified domain name of the object
        


     */

    [ExcelFunction(Description = " x of user.  (C# UDF Function")]
    public static string B2_User2x([ExcelArgument(Name = "user_id", Description = "user id (eg johanb01)")] string user_id)
    {
     

        var searcher = new DirectorySearcher("LDAP://" + user_id.Split('\\').First().ToLower())
        {
            Filter = "(&(ObjectClass=person)(sAMAccountName=" + user_id.Split('\\').Last().ToLower() + "))"
        };

        var result = searcher.FindOne();
        if (result == null)
            return string.Empty;

        string str01 = ""; //Just to get a break point

        // Names and user
        str01 = result.Properties["sAMAccountName"][0].ToString(); ; //sAMAccountName
        string str02 = result.Properties["distinguishedName"][0].ToString(); // Long string...
        string str03 = result.Properties["mail"][0].ToString(); // se also userPrincipalName
        string str04 = result.Properties["userPrincipalName"][0].ToString();  //also mail

        string str05 =  result.Properties["CN"][0].ToString();        //Full name
        string str06 = result.Properties["givenName"][0].ToString();  //First name sn
        string str07 = result.Properties["sn"][0].ToString();         //Sir Name aka last name

        string str10 = result.Properties["title"][0].ToString();
        string str11 = result.Properties["description"][0].ToString();

        //Address and Contry and
        string str51 = result.Properties["c"][0].ToString();  //e.g. SE
        string str52 = result.Properties["co"][0].ToString();  //e.g.Sweden
        string str53 = result.Properties["l"][0].ToString();  //City e.g Gothenburg


        //str = result.Properties[""][0].ToString(); 

        //DONT WORK
        // = result.Properties["site"][0].ToString();  
        //= result.Properties["st"][0].ToString();  
        // = result.Properties["postOfficeBox "][0].ToString();

        //DONT WORK

        //Location
        //https://ldap.com/ldap-filters/


        return str53;
    }


    
    private static string User2(string user_id,
                                string dirParameter)

    {
        string ResultString;

        var searcher = new DirectorySearcher("LDAP://" + user_id.Split('\\').First().ToLower())
        {
            Filter = "(&(ObjectClass=person)(sAMAccountName=" + user_id.Split('\\').Last().ToLower() + "))"
        };

        var result = searcher.FindOne();
        if (result == null)
            return string.Empty;


        ResultString = result.Properties[dirParameter][0].ToString(); //to do loop all results


        return ResultString;
    }



    private static string CN2(string cn,
                                string dirParameter)

    {

        var searcher = new DirectorySearcher("LDAP://" + cn.Split('\\').First().ToLower())
        {

            Filter = "(&(objectCategory=User)(ObjectClass=person)(CN=" + cn.Split('\\').Last().ToLower() + "*))"
        };

        var result = searcher.FindOne();
        if (result == null)
            return string.Empty;


        return result.Properties[dirParameter][0].ToString();

    }






    [ExcelFunction(Description = "mail of user.  (C# UDF Function")]
    public static string B2_User2mail([ExcelArgument(Name = "user_id",  Description = "user id (eg johanb01)")]
                                     string user_id)
    {
        return User2(user_id, "mail").ToLower();
    }


    [ExcelFunction(Description = "sAMAccountName of user.  (C# UDF Function")]
    public static string B2_User2user([ExcelArgument(Name = "user_id",  Description = "user id (eg johanb01)")]
                                     string user_id)
    {
        return User2(user_id, "sAMAccountName").ToLower();
    }


    [ExcelFunction(Description = "distinguishedName of user.  (C# UDF Function")]
    public static string B2_User2dn([ExcelArgument(Name = "user_id",  Description = "user id (eg johanb01)")]
                                     string user_id)
    {
        return User2(user_id, "distinguishedName").ToLower();
    }


    [ExcelFunction(Description = "userPrincipalName of user.  (C# UDF Function")]
    public static string B2_User2upn([ExcelArgument(Name = "user_id",  Description = "user id (eg johanb01)")]
                                     string user_id)
    {
        return User2(user_id, "userPrincipalName");
    }


    [ExcelFunction(Description = "CN of user.  (C# UDF Function")]
    public static string B2_User2cn([ExcelArgument(Name = "user_id",  Description = "user id (eg johanb01)")]
                                     string user_id)
    {
        return User2(user_id, "CN");
    }


    [ExcelFunction(Description = "givenName of user.  (C# UDF Function")]
    public static string B2_User2gn([ExcelArgument(Name = "user_id",  Description = "user id (eg johanb01)")]
                                     string user_id)
    {
        return User2(user_id, "givenName");
    }

    [ExcelFunction(Description = "sn / lastname of user.  (C# UDF Function")]
    public static string B2_User2sn([ExcelArgument(Name = "user_id",  Description = "user id (eg johanb01)")]
                                     string user_id)
    {
        return User2(user_id, "sn");
    }

    [ExcelFunction(Description = "title of user.  (C# UDF Function")]
    public static string B2_User2title([ExcelArgument(Name = "user_id",  Description = "user id (eg johanb01)")]
                                     string user_id)
    {
        return User2(user_id, "title");
    }

    [ExcelFunction(Description = "description of user.  (C# UDF Function")]
    public static string B2_User2desc([ExcelArgument(Name = "user_id",  Description = "user id (eg johanb01)")]
                                     string user_id)
    {
        return User2(user_id, "description");
    }





   // of CN Excel UDFfunctions

                     



    //sAMAccountName
    [ExcelFunction(Description = "sAMAccountName of CN")]
    public static string B2_CN2sAMAccountName([ExcelArgument(Name = "CN", Description = "CN as String to look up")]
                                           string CN)
    {
        return CN2(CN, "sAMAccountName").ToLower();
    }

    //sAMAccountName
    [ExcelFunction(Description = "Email of CN")]
    public static string B2_CN2mail([ExcelArgument(Name = "CN", Description = "CN as String to look up")]
                                           string CN)
    {
        return CN2(CN, "mail").ToLower();
    }




}