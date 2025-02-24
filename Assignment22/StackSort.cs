using System;
using System.Collections.Generic;
public class SortStackRecursively{
    //method to sort using recursion
    public static void SortStack(Stack<int> stack){
        if (stack.Count > 0){
            int top = stack.Pop();
            SortStack(stack);
            InsertInSortedOrder(stack, top);
        }
    }
    //function to insert the element in sorted stack
    private static void InsertInSortedOrder(Stack<int> stack, int value){
        //Enter element if stack is empty or top element value is lower
        if (stack.Count == 0 || stack.Peek() <= value){
            stack.Push(value);
        }
        //if top element value is larger
        else{
            int temp = stack.Pop();
            InsertInSortedOrder(stack, value);
            stack.Push(temp);
        }
    }
    //Main method to call stack and SortStack method
    public static void Main(){
        Stack<int> stack = new Stack<int>();
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);
        
        SortStack(stack);
        
        while (stack.Count > 0){
            Console.WriteLine(stack.Pop());
        }
    }
}
