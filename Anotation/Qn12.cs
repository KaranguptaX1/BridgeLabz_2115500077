using System;
using System.Collections.Generic;
using System.Reflection;

// Define the CacheResult attribute
[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class Operations{
    private static readonly Dictionary<string, object> cache = new Dictionary<string, object>();
    [CacheResult]
    public int ComputeFactorial(int n){
        string cacheKey = $"{nameof(ComputeFactorial)}({n})";
        if (cache.ContainsKey(cacheKey)){
            Console.WriteLine($"Returning cached result for {n}!");
            return (int)cache[cacheKey];
        }
        Console.WriteLine($"Computing factorial for {n}...");
        int result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        // Store result in cache
        cache[cacheKey] = result;
        return result;
    }
}
class Program{
    //Main method
    static void Main(string[] args){
        Operations operations = new Operations();
        Console.WriteLine(operations.ComputeFactorial(5));
        Console.WriteLine(operations.ComputeFactorial(5)); 
        Console.WriteLine(operations.ComputeFactorial(6));
        Console.WriteLine(operations.ComputeFactorial(6)); 
    }
}