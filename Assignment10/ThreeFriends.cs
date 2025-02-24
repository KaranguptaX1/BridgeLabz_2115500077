using System;
class FriendsComparison{
    // method finds the youngest friend
    public static string FindYoungest(int[] ages, string[] names){
        int minAge = ages[0];
        int youngestIndex = 0;
        for (int i = 1; i < ages.Length; i++){
            if (ages[i] < minAge){
                minAge = ages[i];
                youngestIndex = i;
            }
        }
        return names[youngestIndex];
    }

    // method  finds the tallest friend
    public static string FindTallest(double[] heights, string[] names){
        double maxHeight = heights[0];
        int tallestIndex = 0;
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > maxHeight){
                maxHeight = heights[i];
                tallestIndex = i;
            }
        }
        return names[tallestIndex];
    }

    static void Main(string[] args){
        // Names of the friends
        string[] names = { "Amar", "Akbar", "Anthony" };
        // Arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];
        // Input ages and heights from user
        Console.WriteLine("Enter the ages and heights of Amar, Akbar, and Anthony:");
        for (int i = 0; i < 3; i++){
            Console.Write($"{names[i]}'s age: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{names[i]}'s height (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }
        // call the methods
        string youngest = FindYoungest(ages, names);
        string tallest = FindTallest(heights, names);

        // Display output
        Console.WriteLine($"\nThe youngest friend is {youngest}.");
        Console.WriteLine($"The tallest friend is {tallest}.");
    }
}
