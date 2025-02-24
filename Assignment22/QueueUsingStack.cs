using System;
using System.Collections.Generic;
//class to implement queue using stack
public class QueueUsingStacks{
    // Two stacks for enqueue and dequeue operation
    private Stack<int> stack1;
    private Stack<int> stack2;
    //Constructor
    public QueueUsingStacks(){
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    //method to add element
    public void Enqueue(int item){
        stack1.Push(item);
    }
    //method to pop element from stack
    public int Dequeue(){
        if (stack2.Count == 0){
            while (stack1.Count > 0){
                stack2.Push(stack1.Pop());
            }
        }
        return stack2.Count == 0 ? -1 : stack2.Pop();
    }
    //Main method
    public static void Main(){
        QueueUsingStacks queue = new QueueUsingStacks();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine(queue.Dequeue());
        queue.Enqueue(4);
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Dequeue()); 
    }
}
