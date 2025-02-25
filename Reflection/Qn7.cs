using System;
using System.Reflection;
public class Configuration{
    private static string API_KEY = "NewSecretKey123";
    public static string GetApiKey(){
        return API_KEY;
    }
}
class Program{
    static void Main(string[] args){
        Type configType = typeof(Configuration);
        FieldInfo fieldInfo = configType.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);    
        if (fieldInfo != null){
            fieldInfo.SetValue(null, "NewSecretKey456");
        }
        Console.WriteLine("Modified API_KEY: " + Configuration.GetApiKey());
    }
}