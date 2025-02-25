using System;
using System.Reflection;

//RoleAllowedAttribute
[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute{
    public string Role { get; }
    public RoleAllowedAttribute(string role){
        Role = role;
    }
    //method to check access permission
    public static bool HasAccess(object obj, string methodName, string userRole){
        MethodInfo method = obj.GetType().GetMethod(methodName);
        if (method != null){
            var attribute = method.GetCustomAttribute<RoleAllowedAttribute>();
            if (attribute != null && attribute.Role != userRole){
                Console.WriteLine("Access Denied!");
                return false;
            }
        }
        return true;
    }
}

class Profiles{
    [RoleAllowed("ADMIN")]
    public void PerformAdminTask(){
        Console.WriteLine("Admin task executed.");
    }
    [RoleAllowed("USER")]
    public void PerformUserTask(){
        Console.WriteLine("User task executed.");
    }
}

class Program{
    //Main method
    static void Main(){
        Profiles operations = new Profiles();
        //setting role as ADMIN
        string currentUserRole = "ADMIN"; 
        Console.WriteLine($"Current User Role: {currentUserRole}");
        if (RoleAllowedAttribute.HasAccess(operations, nameof(Profiles.PerformAdminTask), currentUserRole)){
            operations.PerformAdminTask();
        }
        if (RoleAllowedAttribute.HasAccess(operations, nameof(Profiles.PerformUserTask), currentUserRole)){
            operations.PerformUserTask();
        }
    }
}