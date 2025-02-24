using System;
using System.Collections.Generic;
class ReverseQueue{
    //Method to Reverse the Queue   
    static void Reverse(Queue<int> queue){
        Stack<int> stack = new Stack<int>();
        //Dequeue all elements and push them onto a stack
        while (queue.Count > 0){
            stack.Push(queue.Dequeue());
        }
        //Pop elements from stack and enqueue back into queue
        while (stack.Count > 0){
            queue.Enqueue(stack.Pop());
        }
    }
    //Main method
    static void Main(string[] args){
        Queue<int> queue = new Queue<int>(new int[] { 10, 20, 30 });
        Console.WriteLine("Original Queue: " + string.Join(", ", queue));
        Reverse(queue);
        Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));
    }
}
