using System;
using System.IO;
class Propagation{
    //Method1 return the division
    static double Method1(double num1,double num2){
        if(num2==0){
            throw new ArithmeticException("Cannot divide by Zero.");
        }
        return num1/num2;
    }
    //Method2 
    static void Method2(double num1,double num2){
        Method1(num1,num2);
    }
    //Main Method
    static void Main(){
        //try catch block
        try{
            Console.Write("Enter the number1: ");
            int num1= int.Parse(Console.ReadLine());
            Console.Write("Enter the number2: ");
            int num2= int.Parse(Console.ReadLine());
            //call the method2
            Method2(num1,num2);
        }
        //Format exception
        catch(FormatException){
            Console.WriteLine("Enter in Numerical format.");
        }
        //Arithmetic Exception
        catch(ArithmeticException ex){
            Console.WriteLine("Exception Handled in Main()");
            Console.WriteLine(ex.Message);
        }
        //Other Exception
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}