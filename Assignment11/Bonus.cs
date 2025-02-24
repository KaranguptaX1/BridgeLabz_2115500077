using System;
class Bonus{
    // Mmethod to generate random salary and years of service
    public static double[,] GetData(int num){
        Random random = new Random();
        double[,] salaryYears = new double[num, 2]; 
        for (int i = 0; i < num; i++){
            salaryYears[i, 0] = random.Next(10000, 99999);  
            salaryYears[i, 1] = random.Next(1, 60);          }
        return salaryYears;
    }
    // method to calculate new salary and bonus
    public static double[,] CalculateNewSalaryAndBonus(double[,] salaryYears, int num)
    {
        double[,] newSalaryYears = new double[num, 3]; 
        for (int i = 0; i < num; i++){
            double oldSalary = salaryYears[i, 0];
            double years = salaryYears[i, 1];
            double bonus = 0;
            double newSalary = oldSalary;
            // check for bonus
            if (years > 5){
            	//5% bonus
                bonus = oldSalary * 0.05;              }
            else{
            	//2% bonus
                bonus = oldSalary * 0.02;  
            }
            newSalary = oldSalary + bonus;
            // Save old salary, bonus, and new salary in  newSalaryYears
            newSalaryYears[i, 0] = oldSalary;
            newSalaryYears[i, 1] = bonus;
            newSalaryYears[i, 2] = newSalary;
        }
        return newSalaryYears;
    }

    // method to calculate total old salary, new salary, and total bonus
    public static void CalculateTotals(double[,] newSalaryYears, int num){
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;
        for (int i = 0; i < num; i++){
            totalOldSalary += newSalaryYears[i, 0];
            totalBonus += newSalaryYears[i, 1];
            totalNewSalary += newSalaryYears[i, 2];
        }
        // Display the result
        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
        Console.WriteLine($"Total Bonus Amount: {totalBonus}");
    }
    // method to display the employees data in tabular format
    public static void DisplayData(double[,] updatedData, int numEmployees){
        Console.WriteLine("Employee No   OldSalary   Bonus  New Salary");
        for (int i = 0; i < numEmployees; i++){
            Console.WriteLine($"{i + 1}  {updatedData[i, 0]:C}   {updatedData[i, 1]:C}  {updatedData[i, 2]:C}");
        }
    }

    static void Main(string[] args){
        int num= 10;
        // call the method to get data
        double[,] salaryYears = GetData(num);
        // Calculate the new salary and bonus
        double[,] newSalaryYears = CalculateNewSalaryAndBonus(salaryYears, num);
        // Display the new Sakary and bonus
        DisplayData(newSalaryYears, num);
        // Calculate and display final result 
        CalculateTotals(newSalaryYears, num);
    }
}
