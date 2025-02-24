using System;
class Trigonometry{
    // Method to calculate sine, cosine, and tangent for a given angle
    public  double[] CalculateTrigonometricFunctions(double angle){
        // Convert angle from degrees to radians
        double angleInRadians = Math.PI * angle / 180.0;
        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(angleInRadians);
        double cosine = Math.Cos(angleInRadians);
        double tangent = Math.Tan(angleInRadians);
        // Return an array
        return new double[] { sine, cosine, tangent };
    }

    static void Main(string[] args){
        // Input angle from user
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());
		//make the class instance
		Trigonometry trigonometry = new Trigonometry();
        // Call the method 
        double[] results = trigonometry.CalculateTrigonometricFunctions(angle);

        // Display the results
        Console.WriteLine($"Sine({angle}°): {results[0]}");
        Console.WriteLine($"Cosine({angle}°): {results[1]}");
        Console.WriteLine($"Tangent({angle}°): {results[2]}");
    }
}
