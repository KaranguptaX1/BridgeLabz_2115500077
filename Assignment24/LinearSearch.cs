using System;
class Search{
    //Method to find the first negative number through linear search
    static void LinearSearch(int[] arr){
        //No element condition
        if(arr.Length==0){
            Console.WriteLine("No element in array");
            return;
        }
        //search element
        for(int i=0;i<arr.Length;i++){
            if(arr[i]<0){
                Console.WriteLine($"First Negative Number {arr[i]}");
                return;
            }
        }
        //If element not found
        Console.WriteLine("No Negative number.");
    }
    //Main method
    static void Main(){
        //Input from user
        Console.Write("Enter the number of Inputs: ");
        int number=int.Parse(Console.ReadLine());
        int[] arr= new int[number];
        int index=0;
        while(index<number){
            Console.Write("Enter the number: ");
            arr[index]= int.Parse(Console.ReadLine());
            index++;
        }
        //call the method
        LinearSearch(arr);
    }
}