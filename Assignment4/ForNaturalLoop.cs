using System;
class ForNaturalLoops{
	// method to calculate the sum using formula
	static int SumNaturalNumber(int num){
		return (num * (num+1))/2;
	}
	//method to calculate sum using for loop
	static int ForNatural(int num2){
		int sum=0;
		//for loop
		for(int i=1;i<=num2;i++){
			sum+=i;
			Console.Write(sum);
		}
		//return 
		return sum;
	}
	static void Main(string[] args){
		//input number from user
		Console.Write("Enter a natural number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		//check if natural number
		if (number>0){
			//call the methods
			int formula_sum =SumNaturalNumber(number);
			int for_sum = ForNatural(number);
			//display the result
			Console.WriteLine($"The sum of{number} values using Formula n*(n+1)/2 {formula_sum}");
			Console.WriteLine($"The sum of {number} values using while loop {for_sum} ");
			//check if both methods have same results or not
			if (formula_sum == for_sum){
				//Display output
				Console.WriteLine("Both results match. Computation is correct.");
            } else {
                Console.WriteLine("The results do not match. There might be an error in computation.");
            }
			
		}
		else{
			//Display output if not natural number
			Console.WriteLine("Enter a valid natural number ");
		}
		
	}}