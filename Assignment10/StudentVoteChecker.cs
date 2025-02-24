using System;
class StudentVoteChecker{
	//method to check the vote age
	public bool CanStudentVote(int age){
		//check for negative number
		if (age<0){
			return false;
		}
		//return true if age is 18 or above else negative
		return age>=18;
	}
	static void Main(string[] args) {
		//Initialize age array
		int [] ages = new int [10];
		//call the class instance
		StudentVoteChecker voteChecker = new StudentVoteChecker();
		//for loop to take input
		for (int i=0;i<ages.Length;i++){
			Console.Write($"Enter the age of student {i+1}: ");
			int age=int.Parse(Console.ReadLine());
			ages[i]=age;
		}
		//for loop to check age and display output
		for (int i=0;i<ages.Length;i++){
			int age = ages[i];
			//call the method to check age
			bool voteResult = voteChecker.CanStudentVote(age);
			//display results
			if (voteResult){
				Console.WriteLine($"Student {i+1} can vote");
			}
			else{Console.WriteLine($"Student {i+1} cannot vote");
			}
		}

		
	}
}