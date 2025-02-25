using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
[AttributeUsage(AttributeTargets.Method)]
public class MeasureTimeAttribute : Attribute { }
public class MethodTimer{
    public static void ExecuteWithTiming<T>(T instance){
        Type type = typeof(T);
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
        foreach (var method in methods){
            if (method.GetCustomAttribute<MeasureTimeAttribute>() != null){
                Stopwatch stopwatch = Stopwatch.StartNew();
                method.Invoke(instance, null);                
                stopwatch.Stop();
                Console.WriteLine($"Execution time of {method.Name}: {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
public class DemoClass{
    [MeasureTime]
    public void QuickMethod(){
        Console.WriteLine("Quick Method Executing...");
    }
    [MeasureTime]
    public void SlowMethod(){
        Console.WriteLine("Slow Method Executing...");
        System.Threading.Thread.Sleep(1000);
    }
    public void NormalMethod(){
        Console.WriteLine("Normal Method Executing...");
    }
}
class Program{
    static void Main(string[] args){
        DemoClass demo = new DemoClass();
        MethodTimer.ExecuteWithTiming(demo);
    }
}