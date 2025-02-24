using System;
class Array{
    static void Main(string[] args){
        // Input rows and columns
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());
        // Initialize 2D array
        int[,] matrix = new int[rows, cols];
        // Take user input for the 2D array
        Console.WriteLine("Enter the elements of the 2D array:");
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                Console.Write($"Element at ({i + 1}, {j + 1}): ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        // Initialize 1D array
        int[] array = new int[rows * cols];
        int index = 0;
        // Copy elements from 2D array to 1D array
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                array[index++] = matrix[i, j];
            }
        }
        // Display the 2D array
        Console.WriteLine("\n2D Array:");
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        // Display the 1D array
        Console.WriteLine("\n1D Array:");
        foreach (int element in array){
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }}

