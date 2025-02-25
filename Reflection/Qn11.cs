using System;
using System.Reflection;
using System.Reflection.Emit;
public interface IGreeting{
    void SayHello(string name);
}
public class Greeting : IGreeting{
    public void SayHello(string name){
        Console.WriteLine($"Hello, {name}!");
    }
}
public class LoggingProxy<T> : DispatchProxy where T : class{
    private T _instance;
    public static T Create(T instance){
        T proxy = Create<T, LoggingProxy<T>>();
        ((LoggingProxy<T>)proxy)._instance = instance;
        return proxy;
    }
    protected override object Invoke(MethodInfo targetMethod, object[] args){
        Console.WriteLine($"[LOG] Calling method: {targetMethod.Name}");
        return targetMethod.Invoke(_instance, args);
    }
}
class Program{
    static void Main(string[] args){
        IGreeting greeting = new Greeting();
        IGreeting proxyGreeting = LoggingProxy<IGreeting>.Create(greeting);
        proxyGreeting.SayHello("Karan");
    }
}