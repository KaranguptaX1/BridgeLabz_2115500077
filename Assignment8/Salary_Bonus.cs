using System;
class Salary_Bonus{
	static void Main(string[] args){
		//Initialize the variable and arrays
		double bonusAfterFiveYears=5;
		double bonusBeforeFiveYears=2;
		double [,] salaryYears =  new double[10,2];
		double [] newSalaries = new double[10];
		double [] bonusAmounts = new double[10];
		double totalBonus=0;
		double totalOldSalary=0;
		double totalNewSalary=0;
		//For to Input the user salary and years
		for(int i=0;i<salaryYears.GetLength(0);i++){
			Console.Write($"Enter the Salary of Employee {i+1}: ");
			double salary=Convert.ToDouble(Console.ReadLine());
			Console.Write($"Enter the Years of Service of Employee {i+1}: ");
			//check to convert double to int 
			//giving error without (int) if enter double values
			int years= (int)Convert.ToDouble(Console.ReadLine());
			//check to ensure that salary and years are valid
			if (salary<0 || years<0 ){
				Console.WriteLine("Please enter the Valid Years and Salary!");
				//decrement index if not valid
				--i;
				continue;
			}
			salaryYears[i,0]=salary;
			salaryYears[i,1]=years;
		}
		//for loop to calculate the bonus,new salary, 
		//totalBonus,TotalOldSalary,TotalNewSalary
		for (int j=0;j<salaryYears.GetLength(0);j++){
			double salary= salaryYears[j,0];
			double years= salaryYears[j,1];
			double bonusPercent= (years>5)? bonusAfterFiveYears : bonusBeforeFiveYears;
			double bonus = salary *(bonusPercent/100);
			double newSalary= bonus+salary;
			bonusAmounts[j]=bonus;
			newSalaries[j]=newSalary;
			totalBonus+=bonus;
			totalOldSalary+=salary;
			totalNewSalary+=newSalary;
		}
		//Display the output of bonus,new salary, OldSalary,Salary
		for(int index=0; index<bonusAmounts.GetLength(0);index++){
			Console.WriteLine($"Employee {index + 1}:");
            Console.WriteLine($"  Old Salary: {salaryYears[index, 0]:C}");
            Console.WriteLine($"  Years of Service: {salaryYears[index, 1]}");
            Console.WriteLine($"  Bonus: {bonusAmounts[index]:C}");
            Console.WriteLine($"  New Salary: {newSalaries[index]:C}");
		}
		//Display the totalBonus,TotalOldSalary,TotalNewSalary
        Console.WriteLine($"Total Bonus Paid: {totalBonus:C}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
		
	}}