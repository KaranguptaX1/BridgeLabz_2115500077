using System;
class PeakElement{
    //Method to find the peak element
    static int FindPeak(int[] arr){
        int left = 0, right = arr.Length - 1;
        while (left < right){
            int mid = left + (right - left) / 2;
            //if mid element is greater than rightmost, peak element is on the right side
            if (arr[mid] > arr[right])
                left = mid + 1;
            else
                right = mid;
        }
        //peak point index
        return left-1; 
    }
    //Main Method
    static void Main(){
        int[] rotatedArray = {6,7,8,9,1,2,3,4,5};
        int index = FindPeak(rotatedArray);
        Console.WriteLine("Peak Index: " + index);
        Console.WriteLine("Peak Element: " + rotatedArray[index]);
    }
}
