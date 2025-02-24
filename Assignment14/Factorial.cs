using System;
class Factorial{
    //method to take input
    public static int GetInput(string message){
        Console.Write(message);
        int number= int.Parse(Console.ReadLine());
        if(number<0){
        	Console.Write("Invalid Input!Enter Again: ");
        	number= int.Parse(Console.ReadLine());
        }
        return number;
    }
    //method to calculate the factorial
    public static long CalculateFactorial(int num){
    	//method to check the break condition
        if(num==0 ||num==1){
            return 1;
        }
        return num* CalculateFactorial(num-1);
    }
    //Method to display the result
    public static void DisplayResult(long factorial){
        Console.Write($"The Factorial is: {factorial}");}
    
        static void Main(string[] args){
        //call the methods
        int input= GetInput("Enter :");
        long result= CalculateFactorial(input);
        DisplayResult(result);
    }
}