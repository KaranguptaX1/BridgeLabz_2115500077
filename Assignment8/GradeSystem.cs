using System;
class GradeSystem{
static void Main(string[] args){
	//Input number from user
	Console.Write("Enter the number of students: ");
	int number=Convert.ToInt32(Console.ReadLine());
	//Initialize the arrays
	double [,] marks = new double[number,3];
	double [] percentage= new double [number];
	string []  grade=new string[number];
	//loop to take input from marks and calculate the percentage and grade
	for (int i=0;i<number;i++){
		//Input marks from user
		Console.Write($"Enter the Chemistry marks of student {i+1}: ");
		double chemMarks=Convert.ToDouble(Console.ReadLine());
		Console.Write($"Enter the Physics marks of student {i+1}: ");
		double physicsMarks=Convert.ToDouble(Console.ReadLine());
		Console.Write($"Enter the Math marks of student {i+1}: ");
		double mathMarks=Convert.ToDouble(Console.ReadLine());
		//Check to see if marks are positive
		if (chemMarks<0 || physicsMarks<0 || mathMarks<0){
			Console.WriteLine("Enter the valid Marks in every subject!");
			i--;
			continue;
		}
		//save the marks
		marks[i,0]=chemMarks;
		marks[i,1]=physicsMarks;
		marks[i,2]=mathMarks;
		
	}
	for (int i=0;i<number;i++){
		//calculate and save percentage
		double percentMarks= (marks[i,0]+marks[i,1]+marks[i,2])/3;
		percentage[i]=percentMarks;
		//calculate  grade based on percentage
		if (percentMarks>=80){
			grade[i]="A";
		}
		else if(percentMarks>=70 && percentMarks<=79){
			grade[i]="B";
		}
		else if(percentMarks>=60 && percentMarks<=69){
			grade[i]="C";
		}
		else if(percentMarks>=50 && percentMarks<=59){
			grade[i]="D";
		}
		else if(percentMarks>=40 && percentMarks<=49){
			grade[i]="E";
		}
		else{
			grade[i]="F";
		}}
		//Display output
		Console.WriteLine("Results of students: ");
		for (int i=0; i<number;i++){
			Console.WriteLine($"The marks of student {i+1} in chemistry is {marks[i,0]}");
			Console.WriteLine($"The marks of student {i+1} in physics is {marks[i,1]}");
			Console.WriteLine($"The marks of student {i+1} in math is {marks[i,2]}");
			Console.WriteLine($"The percentage of student {i+1} is {percentage[i]}");
			Console.WriteLine($"The Grade of student {i+1} is {grade[i]}");
		}
		
	
	
	}}