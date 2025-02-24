using System;
class BMI{
    static void Main(string[] args){
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());
        // Create arrays to store weight, height, BMI, and weight status
        double[] weight = new double[numPersons];
        double[] height = new double[numPersons];
        double[] bmi = new double[numPersons];
        string[] status = new string[numPersons];
        // Input weight and height for each person and calculate BMI
        for (int i = 0; i < numPersons; i++){
            Console.WriteLine($"\nEnter details for Person {i + 1}:");  
            // Input weight and height
            Console.Write("Enter weight (kg): ");
            weight[i] = double.Parse(Console.ReadLine());
            Console.Write("Enter height (m): ");
            height[i] = double.Parse(Console.ReadLine());
            // Calculate BMI
            bmi[i] = weight[i] / (height[i] * height[i]);
            // check weight status based on BMI
            if (bmi[i] < 18.5){
                status[i] = "Underweight";
            }
            else if (bmi[i] < 24.9){
                status[i] = "Normal weight";
            }
            else if (bmi[i] < 39.9){
                status[i] = "Overweight";
            }
            else{
                status[i] = "Obese";
            }
        }
        // Display height, weight, BMI, and weight status for each person
        for (int i = 0; i < numPersons; i++){
            Console.WriteLine($"\nPerson {i + 1}:");
            Console.WriteLine($"  Height: {height[i]} m");
            Console.WriteLine($"  Weight: {weight[i]} kg");
            Console.WriteLine($"  BMI: {bmi[i]:0.00}");
            Console.WriteLine($"  Weight Status: {status[i]}");
        }
    }
}
