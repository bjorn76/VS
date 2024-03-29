﻿using System;
using System.IO;
using System.Web.Script.Serialization;



class MySettings : AppSettings<MySettings>
{
    public string myString = "Hello World";
    public int myInteger = 1;
}
    

    public class AppSettings<T> where T : new()
{
    private const string DEFAULT_FILENAME = "settings.json";

    public void Save(string fileName = DEFAULT_FILENAME)
    {
        File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(this));
    }

    public static void Save(T pSettings, string fileName = DEFAULT_FILENAME)
    {
        File.WriteAllText(fileName, (new JavaScriptSerializer()).Serialize(pSettings));
    }

    public static T Load(string fileName = DEFAULT_FILENAME)
    {
        T t = new T();
        if (File.Exists(fileName))
            t = (new JavaScriptSerializer()).Deserialize<T>(File.ReadAllText(fileName));
        return t;
    }
}
