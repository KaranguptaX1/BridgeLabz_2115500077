using System;
using System.Collections.Generic;
class Binary{
    //method to get a binary values queue
    static Queue<string> BinaryQueue(int number){
        Queue<string> queue= new Queue<string>();
        for(int i=1;i<=number;i++){
            //Convert int to binary form
            string bin= Convert.ToString(i,2);
            queue.Enqueue(bin);
        }
        return queue;
    }
    //Main method
    static void Main(string[] args){
        Console.Write("Enter the number: ");
        int number= int.Parse(Console.ReadLine());
        Queue<string> queue =BinaryQueue(number);
        Console.WriteLine("Queue: " + string.Join(", ", queue));
    }
}
