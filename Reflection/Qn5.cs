using System;
using System.Reflection;
class MathOperations{
    public int Add(int a, int b){
        return a + b;
    }
    public int Subtract(int a, int b){
        return a - b;
    }
    public int Multiply(int a, int b){
        return a * b;
    }
}
class Program{
    static void Main(string[] args){
        MathOperations mathOps = new MathOperations();
        Console.Write("Enter the method name: ");
        string methodName = Console.ReadLine();
        Console.Write("Enter a number: ");
        int arg1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a number: ");
        int arg2 = int.Parse(Console.ReadLine());
        Type mathOpsType = typeof(MathOperations);
        MethodInfo method = mathOpsType.GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);
        if (method == null){
            Console.WriteLine($"Method {methodName} not found.");
            return;
        }
        object[] parameters = { arg1, arg2 };
        int result = (int)method.Invoke(mathOps, parameters);
        Console.WriteLine($"Result of {methodName}({arg1}, {arg2}): {result}");
    }
}