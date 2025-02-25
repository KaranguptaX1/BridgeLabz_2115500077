using System;
using System.Reflection;
//ToDoAttribute custom
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute{
    //Properties
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }
    //Constructor
    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM"){
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}
//Project class
class Project{
    [Todo("Implement authentication", "Rahul Kumar", "HIGH")]
    [Todo("Improve performance", "Alice", "MEDIUM")]
    public void LoginFeature(){
        Console.WriteLine("Login feature in progress...");
    }

    [Todo("Add payment integration", "John Doe", "HIGH")]
    public void PaymentFeature(){
        Console.WriteLine("Payment feature in progress...");
    }
}
class Program{
    //Main Method
    static void Main(){
        Type type = typeof(Project);
        foreach (MethodInfo method in type.GetMethods()){
            var attributes = method.GetCustomAttributes<TodoAttribute>();
            foreach (var attr in attributes){
                Console.WriteLine($"Method: {method.Name}, Task: {attr.Task},Assigned To: {attr.AssignedTo},Priority: {attr.Priority}\n");
                
            }
        }
    }
}