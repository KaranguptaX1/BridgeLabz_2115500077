using System;
using System.Collections.Generic;
class Sequence{
    public static int FindLongestSequence(int[] nums){
        if (nums.Length == 0) return 0;
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;
        foreach (int num in numSet){
            // Check if it's the start of a sequence
            if (!numSet.Contains(num - 1)){
                int currentNum = num;
                int currentLongest = 0;
                // Expand the sequence
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentLongest++;
                }

                longest = Math.Max(longest, currentLongest);
            }
        }

        return longest;
    }

    public static void Main()
    {
        int[] nums = { 10, 20, 30, 40, 50, 3, 10, 5, 6, 7, 8, 9 };
        Console.WriteLine("Longest Consecutive Sequence: " + FindLongestSequence(nums));
    }
}
