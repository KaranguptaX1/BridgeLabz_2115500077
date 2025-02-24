using System;
using System.Collections.Generic;
public class TwoSum{
    //method to find the two numbers whose sum is equal to target
    public static int[] FindTwoSum(int[] nums, int target){
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            int left = target - nums[i];
            if (map.ContainsKey(left))
                return new int[] { map[left], i };
            map[nums[i]] = i;
        }
        return new int[0];
    }
    public static void Main(){
        int[] nums = {2,9,8,15,2,7,1,0 };
        int target = 9;
        int[] result = FindTwoSum(nums, target);
        Console.WriteLine(string.Join(", ", result));
    }
}
