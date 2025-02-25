using System;
using System.Reflection;
class Program{
    static void Main(string[] args){
        Console.Write("Enter the class name: ");
        string className = Console.ReadLine();
        Type type = Type.GetType(className);
        if (type == null){
            Console.WriteLine($"Class '{className}' not found.");
            return;
        }
        Console.WriteLine($"\nClass: {type.FullName}");
        Console.WriteLine("\nMethods:");
        DisplayMethods(type);
        Console.WriteLine("\nFields:");
        DisplayFields(type);
        Console.WriteLine("\nConstructors:");
        DisplayConstructors(type);
    }
    static void DisplayMethods(Type type){
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        foreach (MethodInfo method in methods){
            Console.WriteLine($"- {method.ReturnType.Name} {method.Name}({GetParameterList(method.GetParameters())})");
        }
    }
    static void DisplayFields(Type type){
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        foreach (FieldInfo field in fields){
            Console.WriteLine($"- {field.FieldType.Name} {field.Name}");
        }
    }
    static void DisplayConstructors(Type type){
        ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (ConstructorInfo constructor in constructors){
            Console.WriteLine($"- {type.Name}({GetParameterList(constructor.GetParameters())})");
        }
    }
    static string GetParameterList(ParameterInfo[] parameters){
        string[] parameterTypes = new string[parameters.Length];
        for (int i = 0; i < parameters.Length; i++){
            parameterTypes[i] = $"{parameters[i].ParameterType.Name} {parameters[i].Name}";
        }
        return string.Join(", ", parameterTypes);
    }
}