using System;
class Search{
    //method to find the first missing positive integer
    static int FindFirstMissingPositive(int[] nums){
        int n = nums.Length;
        // place each number at its correct position
        for (int i = 0; i < n; i++){
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]){
                // swap nums[i] with nums[nums[i] - 1]
                int temp = nums[i];
                nums[i] = nums[temp - 1];
                nums[temp - 1] = temp;
            }
        }
        // find the first missing positive number
        for (int i = 0; i < n; i++){
            if (nums[i] != i + 1)
                return i + 1;
        }
        return n + 1;
    }
    //method to find the index of the target number
    static int BinarySearch(int[] nums, int target){
        //Sort the array
        Array.Sort(nums); 
        int left = 0, right = nums.Length - 1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
    //Main method
    static void Main(){
        int[] nums = { 3, 4, -1, 1 };
        int target = 4;
        int missing = FindFirstMissingPositive(nums);
        Console.WriteLine($"First Missing Positive Integer: {missing}");
        int targetIndex = BinarySearch(nums, target);
        Console.WriteLine($"Index of {target} after sorting: {targetIndex}");
    }
}
