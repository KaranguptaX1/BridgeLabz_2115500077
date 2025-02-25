using System;
using System.Reflection;
//importantMethod attribute
[AttributeUsage(AttributeTargets.Method |AttributeTargets.Class)]
class ImportantMethodAttribute:Attribute{
    public string Level{get;}
    public ImportantMethodAttribute(string Level="High"){
        this.Level=Level;
    }
}
//task handler class
class TaskHandler{
    [ImportantMethod("High")]
    public void CriticalTask(){
        Console.WriteLine("Critical Method");
    }
    [ImportantMethod("Normal")]
    public void NormaTask(){
        Console.WriteLine("Normal Task");
    }
}
class Program{
    //Main method
    static void Main(){
        Type type= typeof(TaskHandler);
        foreach(MethodInfo method in type.GetMethods()){
            if(method.GetCustomAttribute(typeof(ImportantMethodAttribute)) is ImportantMethodAttribute attr){
                Console.WriteLine($"Method: {method.Name}, Importance Level:{attr.Level}");
            }
        }
    }
}