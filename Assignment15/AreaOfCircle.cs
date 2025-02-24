using System;
public class Circle{
    private double radius;
    // Constructor to initialize radius
    public Circle(double radius){
        this.radius = radius;
    }
    // Method to calculate area
    public double GetArea(){
        return Math.PI * radius * radius;
    }
    // Method to calculate circumference
    public double GetCircumference(){
        return 2 * Math.PI * radius;
    }
    // Method to display details
    public void DisplayDetails(){
        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Area: {GetArea():F2}");
        Console.WriteLine($"Circumference: {GetCircumference():F2}");
    }
}

class Program{
    static void Main(){
        // User input for radius
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        // Creating Circle object
        Circle circle = new Circle(radius);
        // Displaying details
        Console.WriteLine("\n=== Circle Details ===");
        circle.DisplayDetails();
    }
}
