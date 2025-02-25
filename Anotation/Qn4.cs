using System;
using System.Reflection;

//Define the custom attribute
[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute :Attribute{
    public string Priority{get;}
    public string AssignedTo{get;}
    public TaskInfoAttribute(string Priority,string AssignedTo){
        this.Priority= Priority;
        this.AssignedTo=AssignedTo;
    }
}
//Apply the attribute method
class TaskManger{
    [TaskInfo("High","Rahul")]
    public void CompleteTask(){
        Console.WriteLine("Task Completed!");
    }
}
class Program{
    //Main Method
    static void Main(){
        //use reflection to retrieve attribute details
        Type type= typeof(TaskManger);
        MethodInfo method= type.GetMethod("CompleteTask");
        if(method.GetCustomAttribute(typeof(TaskInfoAttribute)) is TaskInfoAttribute attribute){
            Console.WriteLine($"Task Priority: {attribute.Priority}");
            Console.WriteLine($"Assigned To: {attribute.AssignedTo}");

        }
    }
}