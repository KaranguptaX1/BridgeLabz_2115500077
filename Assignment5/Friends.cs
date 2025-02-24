using System;
class Friends{
    static void Main(string[] args){
        // Input ages and heights for Amar, Akbar, and Anthony
        Console.Write("Enter Amar's age: ");
        int amarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar's height (in cm): ");
        int amarHeight = int.Parse(Console.ReadLine());
        
        Console.Write("Enter Akbar's age: ");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's height (in cm): ");
        int akbarHeight = int.Parse(Console.ReadLine());
        
        Console.Write("Enter Anthony's age: ");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's height (in cm): ");
        int anthonyHeight = int.Parse(Console.ReadLine());

        // Find the youngest friend
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        string youngestFriend;
        if (youngestAge == amarAge)
            youngestFriend = "Amar";
        else if (youngestAge == akbarAge)
            youngestFriend = "Akbar";
        else
            youngestFriend = "Anthony";

        // Find the tallest friend
        int tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
        string tallestFriend;
        if (tallestHeight == amarHeight)
            tallestFriend = "Amar";
        else if (tallestHeight == akbarHeight)
            tallestFriend = "Akbar";
        else
            tallestFriend = "Anthony";

        // Display output
        Console.WriteLine($"\nThe youngest friend is {youngestFriend} with an age of {youngestAge} years.");
        Console.WriteLine($"The tallest friend is {tallestFriend} with a height of {tallestHeight} cm.");
    }
}
