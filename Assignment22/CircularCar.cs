using System;
using System.Collections.Generic;

public class CircularTour{
    // Method to find the petrol pump to start tour
    public static int FindStartingPoint(int[] petrol, int[] distance){
        int n = petrol.Length;
        int totalSurplus = 0, surplus = 0, start = 0;
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < n; i++){
            int fuel = petrol[i] - distance[i];
            totalSurplus += fuel;
            surplus += fuel;
            queue.Enqueue(i);
            //if surplus is negative then reset the start index
            if (surplus < 0){
                start = i + 1;
                surplus = 0;
                queue.Clear();
            }
        }
        return (totalSurplus >= 0) ? start : -1;
    }
    public static void Main(){
        int[] petrol = { 5, 8, 3, 6, 7 };
        int[] distance = { 6, 4, 7, 3, 5 };
        // Display output
        Console.WriteLine(FindStartingPoint(petrol, distance));
    }
}
