using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Property | AttributeTargets.Field)]
public class InjectAttribute : Attribute { }
public class SimpleDIContainer{
    private readonly Dictionary<Type, Type> _registrations = new();
    public void Register<TInterface, TImplementation>() where TImplementation : TInterface{
        _registrations[typeof(TInterface)] = typeof(TImplementation);
    }
    public T Resolve<T>(){
        return (T)Resolve(typeof(T));
    }
    private object Resolve(Type type){
        if (!_registrations.ContainsKey(type))
            throw new InvalidOperationException($"Type {type.Name} is not registered");
        Type implementationType = _registrations[type];
        ConstructorInfo[] constructors = implementationType.GetConstructors();
        foreach (var constructor in constructors){
            if (constructor.GetCustomAttribute<InjectAttribute>() != null){
                ParameterInfo[] parameters = constructor.GetParameters();
                object[] parameterInstances = parameters.Select(p => Resolve(p.ParameterType)).ToArray();
                return Activator.CreateInstance(implementationType, parameterInstances);
            }
        }

        return Activator.CreateInstance(implementationType);
    }
}
public interface IService{
    void Execute();
}
public class Service : IService{
    public void Execute(){
        Console.WriteLine("Service Executed!");
    }
}
public class Consumer{
    private readonly IService _service;
    [Inject]
    public Consumer(IService service){
        _service = service;
    }
    public void Run(){
        _service.Execute();
    }
}
class Program{
    static void Main(string[] args){
        var container = new SimpleDIContainer();
        container.Register<IService, Service>();
        container.Register<Consumer, Consumer>();
        Consumer consumer = container.Resolve<Consumer>();
        consumer.Run();
    }
}