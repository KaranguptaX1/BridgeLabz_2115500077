using System;
using System.IO;
class Nested{
    static void Main(string []args){
        //try catch block
        try{
            //Input from user
            Console.WriteLine("Enter the size of array: ");
            int size= int.Parse(Console.ReadLine());
            int[] arr= new int[size];
            for(int i=0;i<size;i++){
                Console.WriteLine($"Enter the number{i+1}: ");
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the Divisor: ");
            int divisor=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Index(start from 0): ");
            int index= int.Parse(Console.ReadLine());
            try{
                //access the element
                int value= arr[index];
                    try{
                        Console.Write("Answer:");
                        Console.WriteLine(value/divisor);

                    }
                    //Divide by zero exception
                    catch(DivideByZeroException){
                        Console.WriteLine("Cannot Divide by zero!");
                    }
                
            }
            //Index out of Range exception
            catch(IndexOutOfRangeException){
                Console.WriteLine("Invalid Array Index!");
            }
        }
        //Format Exceptions
        catch(FormatException){
            Console.WriteLine("Invalid Input format!");
        }
        //Other Exceptions
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }

}