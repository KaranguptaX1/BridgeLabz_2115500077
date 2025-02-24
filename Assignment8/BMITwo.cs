using System;
class BMITwo{
    static void Main(string[] args){
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());
        // Create a 2D array to store weight, height, and BMI
        double[,] personData = new double[numPersons, 3]; // [i, 0] = weight, [i, 1] = height, [i, 2] = BMI
        string[] weightStatus = new string[numPersons]; // Array to store weight status

        // Input weight and height for each person and calculate BMI
        for (int i = 0; i < numPersons; i++){
            double weight = -1;
            double height = -1;

            // Ensure that weight and height are positive values
            while (weight <= 0){
                Console.WriteLine($"\nEnter details for Person {i + 1}:");
                Console.Write("Enter weight (kg): ");
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.WriteLine("Please enter a valid positive weight.");
                }
            }
            while (height <= 0){
                Console.Write("Enter height (m): ");
                height = double.Parse(Console.ReadLine());
                if (height <= 0)
                {
                    Console.WriteLine("Please enter a valid positive height.");
                }
            }

            // Store weight and height in the personData array
            personData[i, 0] = weight;
            personData[i, 1] = height;
            // Calculate BMI
            personData[i, 2] = weight / (height * height);
            // Determine weight status based on BMI
            if (personData[i, 2] < 18.5){
                weightStatus[i] = "Underweight";
            }
            else if (personData[i, 2] < 24.9){
                weightStatus[i] = "Normal weight";
            }
            else if (personData[i, 2] < 29.9){
                weightStatus[i] = "Overweight";
            }
            else{
                weightStatus[i] = "Obese";
            }
        }
        // Display height, weight, BMI, and weight status for each person
        for (int i = 0; i < numPersons; i++){
            Console.WriteLine($"\nPerson {i + 1}:");
            Console.WriteLine($"  Height: {personData[i, 1]} m");
            Console.WriteLine($"  Weight: {personData[i, 0]} kg");
            Console.WriteLine($"  BMI: {personData[i, 2]}");
            Console.WriteLine($"  Weight Status: {weightStatus[i]}");
        }
    }
}

