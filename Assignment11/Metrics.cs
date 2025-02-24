using System;
class MatrixOperations{
    //method to create a random matrix
    public static double[,] CreateRandomMatrix(int rows, int cols){
        Random random = new Random();
        double[,] matrix = new double[rows, cols];
        //loops to create matrix
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                matrix[i, j] = random.Next(1, 10); 
            }
        }
        return matrix;
    }
    //method to add two matrices
    public static double[,] AddMatrices(double[,] A, double[,] B){
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                result[i, j] = A[i, j] + B[i, j];
            }
        }
        return result;
    }
    //method to subtract two matrices
    public static double[,] SubtractMatrices(double[,] A, double[,] B){
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                result[i, j] = A[i, j] - B[i, j];
            }
        }
        return result;
    }

    //method to multiply two matrices
    public static double[,] MultiplyMatrices(double[,] A, double[,] B){
        int rowsA = A.GetLength(0);
        int colsA = A.GetLength(1);
        int colsB = B.GetLength(1);
        double[,] result = new double[rowsA, colsB];
        for (int i = 0; i < rowsA; i++){
            for (int j = 0; j < colsB; j++){
                for (int k = 0; k < colsA; k++){
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return result;
    }

    //method to find transpose of a matrix
    public static double[,] TransposeMatrix(double[,] A){
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[cols, rows];
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                result[j, i] = A[i, j];
            }
        }
        return result;
    }

    //method to find determinant of a 2x2 matrix
    public static double Determinant2x2(double[,] A){
        return A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
    }

    // method to find the determinant of a 3x3 matrix
    public static double Determinant3x3(double[,] A){
        return A[0, 0] * (A[1, 1] * A[2, 2] - A[1, 2] * A[2, 1])
             - A[0, 1] * (A[1, 0] * A[2, 2] - A[1, 2] * A[2, 0])
             + A[0, 2] * (A[1, 0] * A[2, 1] - A[1, 1] * A[2, 0]);
    }

    // method to find the inverse of a 2x2 matrix
    public static double[,] Inverse2x2(double[,] A){
        double det = Determinant2x2(A);
        if (det == 0) throw new InvalidOperationException("Matrix is not invertible.");
        double[,] result = new double[2, 2];
        result[0, 0] = A[1, 1] / det;
        result[0, 1] = -A[0, 1] / det;
        result[1, 0] = -A[1, 0] / det;
        result[1, 1] = A[0, 0] / det;

        return result;
    }
    //method to display a matrix
    public static void DisplayMatrix(double[,] matrix){
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < cols; j++){
                Console.Write($"{matrix[i, j],6:F2} ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args){
    	//Input from user
        Console.Write("Enter the number of rows for the matrix: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of columns for the matrix: ");
        int cols = Convert.ToInt32(Console.ReadLine());
        double[,] matrixA = CreateRandomMatrix(rows, cols);
        double[,] matrixB = CreateRandomMatrix(rows, cols);
		//call and display methods
        Console.WriteLine("\nMatrix A:");
        DisplayMatrix(matrixA);
        Console.WriteLine("\nMatrix B:");
        DisplayMatrix(matrixB);
        Console.WriteLine("\nMatrix A + Matrix B:");
        DisplayMatrix(AddMatrices(matrixA, matrixB));
        Console.WriteLine("\nMatrix A - Matrix B:");
        DisplayMatrix(SubtractMatrices(matrixA, matrixB));
        if (rows == cols){
            Console.WriteLine("\nTranspose of Matrix A:");
            DisplayMatrix(TransposeMatrix(matrixA));
            if (rows == 2){
                Console.WriteLine("\nDeterminant of Matrix A:");
                Console.WriteLine(Determinant2x2(matrixA));
                Console.WriteLine("\nInverse of Matrix A:");
                DisplayMatrix(Inverse2x2(matrixA));
            }
            else if (rows == 3){
                Console.WriteLine("\nDeterminant of Matrix A:");
                Console.WriteLine(Determinant3x3(matrixA));
            }
        }
        else{
            Console.WriteLine("\nDeterminant and Inverse operations are only available for square matrices.");
        }
    }
}
