using System;
class FootballTeam {
    // method to generate random heights (between 150 and 250 cm) for the players
    public static int[] GenerateRandomHeights(int size) {
    	//Initialize random class
        Random random = new Random();
        int[] heights = new int[size];
        //for loop to generate heights
        for (int i = 0; i < size; i++) {
            heights[i] = random.Next(150, 251); 
        }
        return heights;
    }

    // method to calculate the sum of heights in  array
    public static int CalculateSum(int[] heights) {
        int sum = 0;
        //for loop to sum the heights
        foreach (int height in heights) {
            sum += height;
        }
        return sum;
    }

    // method to calculate the mean height of players
    public static double CalculateMean(int[] heights) {
        int sum = CalculateSum(heights);
        return (double)sum / heights.Length;
    }

    // method to find the shortest height among players
    public static int FindShortestHeight(int[] heights) {
        int shortest = heights[0];//initialize with first height
        //loop to find the shortest height
        foreach (int height in heights) {
            if (height < shortest) {
                shortest = height;
            }
        }
        return shortest;
    }

    // method to find the tallest height among the players
    public static int FindTallestHeight(int[] heights) {
        int tallest = heights[0];//initialize with first height
        //loop to find the tallest height
        foreach (int height in heights) {
            if (height > tallest) {
                tallest = height;
            }
        }
        return tallest;
    }

    static void Main(string[] args) {
        // Initialize the team with 11 players
        int[] heights = GenerateRandomHeights(11);
        // Display the heights
        Console.WriteLine("Heights of the players:");
        foreach (int height in heights) {
            Console.WriteLine(height + " cm");
        }
        // Calculate and display the results
        double meanHeight = CalculateMean(heights);
        int shortestHeight = FindShortestHeight(heights);
        int tallestHeight = FindTallestHeight(heights);
        Console.WriteLine("\nResults:");
        Console.WriteLine($"Mean height: {meanHeight:F2} cm");
        Console.WriteLine($"Shortest height: {shortestHeight} cm");
        Console.WriteLine($"Tallest height: {tallestHeight} cm");
    }
}
