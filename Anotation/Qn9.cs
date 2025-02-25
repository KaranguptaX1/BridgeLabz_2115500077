using System;
using System.Reflection;
//Attribute MaxLength

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
class MaxLengthAttribute : Attribute{
    public int Length { get; }
    public MaxLengthAttribute(int length){
        Length = length;
    }
}
//User class
class User{
    [MaxLength(10)]
    public string Username { get; }
    private void Validate(string username){
        Type type = typeof(User);
        PropertyInfo property = type.GetProperty("Username");
        if (property != null){
            var attribute = property.GetCustomAttribute<MaxLengthAttribute>();
            if (attribute != null && username.Length > attribute.Length){
                throw new ArgumentException($"Username exceeds maximum length of {attribute.Length} characters.");
            }
        }
    }
    //Constructor
    public User(string username){
        Validate(username);
        Username = username;
    }
}
class Program{
    //Main method
    static void Main(){
        try{
            User user1 = new User("Rambo"); 
            Console.WriteLine($"User created: {user1.Username}");
            User user2 = new User("PacificRimTitan"); 
            Console.WriteLine($"User created: {user2.Username}");
        }
        catch (Exception ex){
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}