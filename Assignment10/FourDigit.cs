using System;
class RandomNumber{
    // method to generate  array of random 4 digit numbers
    public static int[] Generate4DigitRandomArray(int size) {
        Random random = new Random();
        int[] randomNumbers = new int[size];
        for (int i = 0; i < size; i++) {
            // generate a 4 digit random number 
            randomNumbers[i] = random.Next(1000, 10000);
        }
        return randomNumbers;
    }
    // method to find the average, minimum, and maximum values from the array
    public static double[] FindAverageMinMax(int[] numbers) {
        double sum = 0;
        int minValue = numbers[0];
        int maxValue = numbers[0];
        foreach (int num in numbers) {
            sum += num;
            minValue = Math.Min(minValue, num);
            maxValue = Math.Max(maxValue, num);
        }
        double average = sum / numbers.Length;
        // return average, min, and max as an array
        return new double[] { average, minValue, maxValue };
    }
    static void Main(string[] args) {
        // generate an array of 5 random 4-digit numbers
        int[] randomNumbers = Generate4DigitRandomArray(5);
        // Display the random numbers
        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (int num in randomNumbers) {
            Console.WriteLine(num);
        }
        // calculate the average, min, and max
        double[] stats = FindAverageMinMax(randomNumbers);
        // Display output
        Console.WriteLine("\nResults:");
        Console.WriteLine($"Average: {stats[0]:F2}");
        Console.WriteLine($"Minimum: {stats[1]}");
        Console.WriteLine($"Maximum: {stats[2]}");
    }
}
