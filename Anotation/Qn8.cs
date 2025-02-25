using System;
using System.Reflection;
using System.Diagnostics;
//LogExecutionAttribute 
[AttributeUsage(AttributeTargets.Method|AttributeTargets.Class)]
class LogExecutionTimeAttribute:Attribute{
    //Method to calculate the execution time
    public void ExecutionTime(object instance, MethodInfo method){
        Stopwatch sw1= Stopwatch.StartNew();
        method.Invoke(new Tasks(),null);
        sw1.Stop();
        Console.WriteLine($"Method: {method.Name} has taken {sw1.ElapsedMilliseconds} ms\n");

    }

}
//Tasks class
class Tasks{
    [LogExecutionTime]
    public void Task1(){
        Console.WriteLine("Task1 is executing....");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Task1 complete....");

    }
    [LogExecutionTime]
    public void Task2(){
        Console.WriteLine("Task2 is executing....");
        System.Threading.Thread.Sleep(1500);
        Console.WriteLine("Task2 complete....");

    }
}
class Program{
    //Main methods
    static void Main(string[] args){
        //get the type of class
        Type type= typeof(Tasks);
        foreach(MethodInfo method in type.GetMethods()){
            var attribute= method.GetCustomAttribute<LogExecutionTimeAttribute>();
            if(attribute!=null){
            attribute.ExecutionTime(new Tasks(),method);}

        }
    }
}