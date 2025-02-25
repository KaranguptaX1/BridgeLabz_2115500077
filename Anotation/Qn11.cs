using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text.Json;
//JsonField Attribute
[AttributeUsage(AttributeTargets.Property)]
class JsonFieldAttribute : Attribute{
    public string Name { get; }
    public JsonFieldAttribute(string name){
        Name = name;
    }
}
//User class
class User{
    [JsonField("user_name")]
    public string Username { get; set; }
    [JsonField("user_email")]
    public string Email { get; set; }
    [JsonField("user_age")]
    public int Age { get; set; }
    //Constructor
    public User(string username, string email, int age){
        Username = username;
        Email = email;
        Age = age;
    }
}
//helper function to serialize to json
class JsonHelper{
    public static string SerializeToJson(object obj){
        Dictionary<string, object> jsonDict = new Dictionary<string, object>();
        Type type = obj.GetType();
        foreach (PropertyInfo property in type.GetProperties()){
            var attribute = property.GetCustomAttribute<JsonFieldAttribute>();
            string jsonKey = attribute != null ? attribute.Name : property.Name;
            object value = property.GetValue(obj);
            jsonDict[jsonKey] = value;
        }
        return JsonSerializer.Serialize(jsonDict, new JsonSerializerOptions { WriteIndented = true });
    }
}
class Program{
    //Main method
    static void Main(){
        User user = new User("Salman", "Salman@gmail.com", 52);
        string json = JsonHelper.SerializeToJson(user);
        Console.WriteLine(json);
    }
}