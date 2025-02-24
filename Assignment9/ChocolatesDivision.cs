using System;
class ChocolateDivision{
    // Method to calculate the number of chocolates each child gets and the remainder
    public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
    {
        // Calculate chocolates per child and remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        return new int[]{chocolatesPerChild, remainingChocolates};
    }
    static void Main(string[] args){
        // Input number of chocolates 
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
        // Input number of children
        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());
        // Validate input to avoid division by zero
        if (numberOfChildren == 0)
        {
            Console.WriteLine("Number of children cannot be zero it gives divide by zero error.");
            return;
        }
        // Call the method to calculate the results
        int[] results= FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);
        // Display the results
        Console.WriteLine($"Each child will get {results[0]} chocolates.");
        Console.WriteLine($"Remaining chocolates: {results[1]}");
    }
}
