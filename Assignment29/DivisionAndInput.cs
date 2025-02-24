using System;
using System.IO;
class DivisionAndInput{
    //Method to find the division
    static void Division(){
        //if both inputs are numbers and num2!=0
        try{
            using (StreamReader sr= new StreamReader(Console.OpenStandardInput())){
                Console.Write("Enter the first number: ");
                int num1= int.Parse(sr.ReadLine());
                Console.Write("Enter the second number: ");
                int num2= int.Parse(sr.ReadLine());
                Console.WriteLine(num1/num2);
            }
        }
        //handle division by zero
        catch(DivideByZeroException){
            Console.WriteLine("You are dividing the number by Zero which is not possible.");
        }
        //handle Format exception
        catch(FormatException){
            Console.WriteLine("Enter the number in input.");
        }
        //handle other exceptions
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
    //Main Method
    static void Main(string[] args){
        //call the method
        Division();
        
    }
}