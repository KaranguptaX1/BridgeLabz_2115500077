using System;
using System.IO;
class Operation{
    //Method to divide numbers
    static double Division(int num1,int num2){
        if(num2==0){
            throw new DivideByZeroException("Cannot divide by Zero.");
        }
        return num1/num2;
    }
    static void Main(string[] args){
        //try catch block
        try{
            //
            Console.Write("Enter the number1 :");
            int num1= int.Parse(Console.ReadLine());
            Console.Write("Enter the number2: ");
            int num2= int.Parse(Console.ReadLine());
            double result= Division(num1,num2);
            Console.WriteLine("Result: "+result);
        }
        //Format Exception
        catch(FormatException){
            Console.WriteLine("Enter in valid Format.");
        }
        //Divide by zero Exception
        catch(DivideByZeroException ex){
            Console.WriteLine(ex.Message);
        }
        //Other exception
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        //Finally block
        finally{
            Console.WriteLine("Operation Completed.");
        }
    }
}