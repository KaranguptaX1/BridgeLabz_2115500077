using System;
class Program{
    //method to find the target element in matrix
    static bool SearchMatrix(int[,] matrix, int target){
        if (matrix == null || matrix.Length == 0)
            return false;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int left = 0, right = rows * cols - 1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            int row = mid / cols;
            int col = mid % cols;
            int midValue = matrix[row, col];
            if (midValue == target)
                return true;
            else if (midValue < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
    //Main method
    static void Main(){
        int[,] matrix = {
            {1, 3, 5, 7},
            {10, 11, 16, 20},
            {23, 30, 34, 60}
        };
        int target = 11;
        bool result = SearchMatrix(matrix, target);
        Console.WriteLine($"{target} Found? {result}"); 
    }
}
