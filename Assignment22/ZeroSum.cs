using System;
using System.Collections.Generic;
class ZeroSumSubarrays{
    public static void FindZeroSumSubarrays(int[] nums){
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        int cumulativeSum = 0;
        // Store zero-sum 
        sumMap[0] = new List<int> { -1 };
        for (int i = 0; i < nums.Length; i++){
            cumulativeSum += nums[i];
            // If the sum has been seen before, it means there exists a zero-sum subarray
            if (sumMap.ContainsKey(cumulativeSum)){
                foreach (int startIndex in sumMap[cumulativeSum]){
                    Console.WriteLine($"Subarray found: [{startIndex + 1}, {i}]");
                }
            }
            // Add the current sum to the dictionary
            if (!sumMap.ContainsKey(cumulativeSum))
                sumMap[cumulativeSum] = new List<int>();
            sumMap[cumulativeSum].Add(i);
        }
    }

    public static void Main(){
        int[] arr = { 2, -3, 1, 6, -4, 2, -2, 3, -3 };
        Console.WriteLine("Zero Sum Subarrays:");
        FindZeroSumSubarrays(arr);
    }
}
