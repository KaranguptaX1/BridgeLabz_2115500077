using System;
class CollinearPoints{
    // method to check collinearity using the slope formula
    public static bool CollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3){
        // calculate slopes AB, BC, and AC
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);
        // check if all slopes are equal
        return (slopeAC==slopeBC) && (slopeAB==slopeBC );
    }

    // method to check collinearity using the area of the triangle formula
    public static bool CollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3){
        // calculate area of the triangle formed by the points
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        // if the area is 0
        return area == 0;
    }

    static void Main(string[] args){
        // Input from user
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = Convert.ToDouble(Console.ReadLine());

        // call the method to check collinearity using slope
        bool isCollinearUsingSlope = CollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        if (isCollinearUsingSlope){
            Console.WriteLine("The points are collinear using the slope formula.");
        }
        else{
            Console.WriteLine("The points are not collinear using the slope formula.");
        }

        // call the method to check collinearity using the area formula
        bool isCollinearUsingArea = CollinearUsingArea(x1, y1, x2, y2, x3, y3);
        if (isCollinearUsingArea){
            Console.WriteLine("The points are collinear using the area formula.");
        }
        else{
            Console.WriteLine("The points are not collinear using the area formula.");
        }
    }
}
