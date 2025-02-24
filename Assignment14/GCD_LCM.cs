using System;
class GCD_LCM_Calculator{
    // Method to get input 
    static int GetInput(string message){
        Console.Write(message);
        int number;
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0){
            Console.Write("Invalid input! Please enter a positive integer: ");
        }
        return number;
    }
    // Method to calculate GCD 
    public static int CalculateGCD(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Method to calculate LCM using the relation: LCM(a, b) = (a * b) / GCD(a, b)
    public static int CalculateLCM(int a, int b){
        return (a / CalculateGCD(a, b)) * b; 
    }

    // Method to display results
    static void DisplayResult(int gcd, int lcm){
        Console.WriteLine($"Greatest Common Divisor (GCD): {gcd}");
        Console.WriteLine($"Least Common Multiple (LCM): {lcm}");
    }

    static void Main(){
        // take user inputs
        int num1 = GetInput("Enter the first positive integer: ");
        int num2 = GetInput("Enter the second positive integer: ");

        // Calculate GCD and LCM
        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2);

        // Display results
        DisplayResult(gcd, lcm);
    }
}
