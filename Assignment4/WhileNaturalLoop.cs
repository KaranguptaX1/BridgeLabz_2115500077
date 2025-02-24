using System;
class WhileNaturalLoops{
	// method to calculate the sum using formula
	static int SumNaturalNumber(int num){
		return (num * (num+1))/2;
	}
	//method to calculate sum using while loop
	static int WhileNatural(int num2){
		int sum=0;
		//while loop
		while(num2>=1){
			sum+=num2;
			num2-=1;
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
			int while_sum = WhileNatural(number);
			//display the result
			Console.WriteLine($"The sum of{number} values using Formula n*(n+1)/2 {formula_sum}");
			Console.WriteLine($"The sum of {number} values using while loop {while_sum} ");
			//check if both methods have same results or not
			if (formula_sum == while_sum){
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