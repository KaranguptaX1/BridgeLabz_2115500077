using System;
class RotationPoint{
    //Method to find the point of rotation
    static int FindRotationPoint(int[] arr){
        int left = 0, right = arr.Length - 1;
        while (left < right){
            int mid = left + (right - left) / 2;
            //if mid element is greater than rightmost, rotation point is on the right side
            if (arr[mid] > arr[right])
                left = mid + 1;
            else
                right = mid;
        }
        //point of rotation
        return left; 
    }
    //Main Method
    static void Main(){
        int[] rotatedArray = { 6, 7, 8, 1, 2, 3, 4, 5 };
        int index = FindRotationPoint(rotatedArray);
        Console.WriteLine("Rotation Point Index: " + index);
        Console.WriteLine("Smallest Element: " + rotatedArray[index]);
    }
}
