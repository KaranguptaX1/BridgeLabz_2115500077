using System;
using System.IO;
class Calculate{
    //Method to calculate the interest
    static double CalculateInterest(double amount,double rate,int years){
        //if rate and amount is negative throw exception
        if(amount<0 ||rate<0){
            throw new ArgumentException("Invalid Input: Amount and rate must be positive.");
        }
        return (amount*rate*years)/100;
    }
    static void Main(string[] args){
        //try catch block
        try{
            //Input from user
            Console.Write("Enter the amount: ");
            double amount= double.Parse(Console.ReadLine());
            Console.Write("Enter the rate of interest: ");
            double rate= double.Parse(Console.ReadLine());
            Console.Write("Enter the years: ");
            int years= int.Parse(Console.ReadLine());
            //call the method
            double interest=CalculateInterest(amount,rate,years);
            Console.WriteLine("Interest is: "+interest);
        }
        //Format exceptions
        catch(FormatException ){
            Console.WriteLine("Enter the input in numerical format only.");
        }
        //Argument exception
        catch(ArgumentException ex){
            Console.WriteLine(ex.Message);
        }
        //Other Exception
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}