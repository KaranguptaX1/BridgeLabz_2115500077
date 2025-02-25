using System;
using System.Reflection;
//define a repeatable attribute
[AttributeUsage(AttributeTargets.Method,AllowMultiple =true)]
class BugReportAttribute:Attribute{
    public string Description{get;}
    public BugReportAttribute(string Description){
        this.Description=Description;
    }
}

class BugTracker{
    [BugReport("Null Reference")]
    [BugReport("Performance issue")]
    public void ProcessData(){
        Console.WriteLine("Processing Data.....");
    }
}
class Program{
    static void Main(){
        Type type= typeof(BugTracker);
        MethodInfo method= type.GetMethod("ProcessData");
        //Retrieve all BugReport attributes
        object[] attributes = method.GetCustomAttributes(typeof(BugReportAttribute),false);
        //Loop through each attribute and print its details
        foreach(BugReportAttribute bug in attributes){
            Console.WriteLine($"Bug Report: {bug.Description}");
        }
    }
}