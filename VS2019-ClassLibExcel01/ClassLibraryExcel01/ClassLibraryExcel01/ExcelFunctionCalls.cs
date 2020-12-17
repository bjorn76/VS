using ExcelDna.Integration;
using System;
using System.DirectoryServices;
using System.Linq;

public static class ExcelFunctionCalls
{
    [ExcelFunction(Description = "Last week example UDF Function")]
    public static DateTime GetLastWeek()
    {
        return DateTime.Today - TimeSpan.FromDays(7);
    }

    [ExcelFunction(Description = "Reverse string example UDF Function")]
    public static string ReverseString([ExcelArgument(Name = "input_string",
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

    [ExcelFunction(Description = "Distinguished Name string of user in a UDF Function")]
    public static string B2_UserDN([ExcelArgument(Name = "user_id",
                                                      Description = "user id as String to look up")]
                                        string user_id)

    {
        string DNstring = "";

        var searcher = new DirectorySearcher("LDAP://" + user_id.Split('\\').First().ToLower())
        {
            Filter = "(&(ObjectClass=person)(sAMAccountName=" + user_id.Split('\\').Last().ToLower() + "))"
        };

        var result = searcher.FindOne();
            if (result == null)
                return string.Empty;


            DNstring= result.Properties["distinguishedName"][0].ToString();
        return DNstring;
    }


    [ExcelFunction(Description = "email of user in a UDF Function")]
    public static string B2_User2Mail([ExcelArgument(Name = "user_id",
                                                      Description = "user id as String to look up")]
                                        string user_id)

    {

        var searcher = new DirectorySearcher("LDAP://" + user_id.Split('\\').First().ToLower())
        {
            Filter = "(&(ObjectClass=person)(sAMAccountName=" + user_id.Split('\\').Last().ToLower() + "))"
        };

        var result = searcher.FindOne();
        if (result == null)
            return string.Empty;


        return result.Properties["mail"][0].ToString();

    }

    //userPrincipalName
    [ExcelFunction(Description = "email of user in a UDF Function")]
    public static string B2_mail2user([ExcelArgument(Name = "user_mail",
                                                      Description = "user mail as String to look up")]
                                        string user_mail)

    {

        var searcher = new DirectorySearcher("LDAP://" + user_mail.Split('\\').First().ToLower())
        {
            
            Filter = "(&(objectCategory=User)(ObjectClass=person)(mail=" + user_mail.Split('\\').Last().ToLower() + "*))"
        };

        var result = searcher.FindOne();
        if (result == null)
            return string.Empty;


        //return result.Properties["CN"][0].ToString();
        //return result.Properties["userPrincipalName"][0].ToString();  //also email
        return result.Properties["sAMAccountName"][0].ToString();
        



    }

    //userPrincipalName
    [ExcelFunction(Description = "email of user in a UDF Function")]
    public static string B2_mail2mail([ExcelArgument(Name = "user_mail",
                                                      Description = "start of user mail as String to look up")]
                                        string user_mail)

    {

        var searcher = new DirectorySearcher("LDAP://" + user_mail.Split('\\').First().ToLower())
        {

            Filter = "(&(objectCategory=User)(ObjectClass=person)(mail=" + user_mail.Split('\\').Last().ToLower() + "*))"
        };

        var result = searcher.FindOne();
        if (result == null)
            return string.Empty;


        return result.Properties["mail"][0].ToString();

    }

    [ExcelFunction(Description = "email of user in a UDF Function")]
    public static string B2_CN2mail([ExcelArgument(Name = "CN",
                                                      Description = "CN as String to look up")]
                                        string CN)

    {

        var searcher = new DirectorySearcher("LDAP://" + CN.Split('\\').First().ToLower())
        {

            Filter = "(&(objectCategory=User)(ObjectClass=person)(CN=" + CN.Split('\\').Last().ToLower() + "*))"
        };

        var result = searcher.FindOne();
        if (result == null)
            return string.Empty;


        return result.Properties["mail"][0].ToString();

    }

    //sAMAccountName
    [ExcelFunction(Description = "email of user in a UDF Function")]
    public static string B2_CN2sAMAccountName([ExcelArgument(Name = "CN",
                                                      Description = "CN as String to look up")]
                                        string CN)

    {

        var searcher = new DirectorySearcher("LDAP://" + CN.Split('\\').First().ToLower())
        {

            Filter = "(&(objectCategory=User)(ObjectClass=person)(CN=" + CN.Split('\\').Last().ToLower() + "*))"
        };

        var result = searcher.FindOne();
        if (result == null)
            return string.Empty;


        return result.Properties["sAMAccountName"][0].ToString();

    }

}