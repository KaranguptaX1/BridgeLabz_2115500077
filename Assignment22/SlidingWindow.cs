using System;
using System.Collections.Generic;

public class SlidingWindowMax
{
    //Method to find the maximum value in each sliding window of size k
    public static int[] MaxSlidingWindow(int[] nums, int k){
        // if input is empty   
        if (nums.Length == 0) return new int[0]; 
        // List to store the maximums in each window
        List<int> result = new List<int>(); 
        LinkedList<int> deque = new LinkedList<int>();
        for (int i = 0; i < nums.Length; i++){
            // Remove elements that are out of the current window
            while (deque.Count > 0 && deque.First.Value < i - k + 1)
                deque.RemoveFirst();
            // Remove elements from the back that are smaller than the current element
            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                deque.RemoveLast();
            // Add the current element index 
            deque.AddLast(i);
            //first element is the max of the current window so add to result
            if (i >= k - 1)
                result.Add(nums[deque.First.Value]);
        }
        return result.ToArray();
    }

    public static void Main(){
        int[] nums = { 4, 2, 12, 11, -5, 7, 9, 3 };
        int k = 3;
        int[] result = MaxSlidingWindow(nums, k);
        //Display output
        Console.WriteLine(string.Join(" ", result));
    }
}
