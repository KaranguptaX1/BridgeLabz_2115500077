using System;
class Factor{
	//method to find the factors
	public static int[] FindFactors(int num){
		//Initialize variable
		int count=0;
		//for loop to count factors
		for(int i=1;i<=num;i++){
			if (num%i==0){
				count+=1;}
		}
		//array to store factors
		int[] factors =  new int[count];
		int index=0;
		//for loop to find factors
		for(int i=1;i<=num;i++){
			if (num%i==0){
				factors[index]=i;
				index++;
				}
		}
		//return factor array
		return factors;
		
	}
	//method to find the sum of factors
	public static int SumFactors(int[] factors){
		int sum=0;
		//loop to add the factors
		foreach(int factor in factors){
			sum+=factor;
		}
		return sum;
		
	}
	//method to find product of factors
	public static int ProductFactors(int[] factors){
		int product=1;
		//loop to multiply factors
		foreach(int factor in factors){
			product*=factor;
		}
		return product;
		
	}
	//method to find the sum of squares of factors
	public static int SumOfSquaresFactors(int[] factors){
		int sumOfSquares=0;
		//loop to sum squares of factors
		foreach(int factor in factors){
			sumOfSquares+=(int)Math.Pow(factor,2);
		}
		return sumOfSquares;
		
	}
	static void Main(string[] args){
		//Input number from user
		Console.Write("Enter the number: ");
		int number= Convert.ToInt32(Console.ReadLine());
		//check if number is positive
		if(number<=0){
			Console.WriteLine("Invalid number");
			return;
		}
		
		//call the method to find factor
		int [] factors= FindFactors(number);
		//call the method to find sum of factors
		int sum= SumFactors(factors);
		//call the method to find product of factors
		int product=ProductFactors(factors);
		//call the method to find the sum of squares of factors
		int sumOfSquare=SumOfSquaresFactors(factors);
		//Display output
		Console.WriteLine($"The sum of Factors is: {sum} \nThe Product of Factors is {product} \nThe Sum of Squares of Factors {sumOfSquare}");
		
		
	}

}