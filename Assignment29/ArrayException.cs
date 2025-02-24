using System;
using System.IO;
class ArrayException{
    static void Main(){
        //Array
        int[]arr=new int[]{1,2,4,5,6,7};
        // int [] arr2= null;
        //try catch block
        try{
            //Input from user
            Console.Write("Enter the index: ");
            int index= int.Parse(Console.ReadLine());
            Console.WriteLine($"Value at index {index}: {arr[index]}");
        }
        //Handle Format exceptions
        catch(FormatException){
            Console.WriteLine("Enter the index in correct format.");
        }
        //Handle outofRange exception
        catch(IndexOutOfRangeException){
            Console.WriteLine("Invalid Index!");
        }
        //handle null reference exceptions
        catch(NullReferenceException){
            Console.WriteLine("Array is not Initialized!");
        }
        //handle other exception
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
}