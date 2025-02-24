using System;
class Circle{
    private double radius;
    // Default Constructor
    public Circle() : this(1.0) { }
    // Parameterized Constructor
    public Circle(double radius){
        this.radius = radius;
    }
    //method to get area
    public double GetArea(){
        return Math.PI * radius * radius;
    }
    //method to display area
    public void DisplayDetails(){
        Console.WriteLine($"Radius: {radius}, Area: {GetArea():0.0000}");
    }
}

class Program{
    static void Main(){
        Circle circle1 = new Circle();
        Circle circle2 = new Circle(5.0);
		//display output
        circle1.DisplayDetails();
        circle2.DisplayDetails();
    }
}
