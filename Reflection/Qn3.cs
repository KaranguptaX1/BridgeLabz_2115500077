using System;
using System.Reflection;
class Calculator{
    private int Multiply(int a, int b){
        return a * b;
    }
}
class Program{
    static void Main(string[] args){
        Calculator calculator = new Calculator();
        Type calculatorType = typeof(Calculator);
        MethodInfo multiplyMethod = calculatorType.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
        if (multiplyMethod == null){
            Console.WriteLine("Multiply not found.");
            return;
        }
        object[] parameters = {5,6};
        int result = (int)multiplyMethod.Invoke(calculator, parameters);
        Console.WriteLine($"Result of Multiply(5, 6): {result}");
    }
}