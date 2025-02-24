using System;
class NumberChecker{
	public static int[] GetFactors(int num){
		int count=0;
		//loop to count the factors
		for(int i=1; i<=num ;i++){
			if (num%i==0){
				count++;
			}
			
		}
		int [] factors = new int[count];
		int index = 0;
		//store factors in array
		for (int i=1; i<=num;i++){
			if (num % i ==0){
			factors[index]=i;
			index++;
		}}
		//return factor array
		return factors;
	}
	//method to calulate greatest factor
	public static int GreatestFactor(int [] factors){
		//second last element
		return factors[factors.Length -2];
	}
	public static int SumOfFactors(int [] factors){
		int sum=0;
		//loop to sum the factors
		foreach(int factor in factors){
			sum+=factor;
		}
		return sum;
	}
	//method to get the product of factors
	public static long ProductOfFactors(int [] factors){
		long product =1;
		//loop to product the factors
		foreach(int factor in factors){
			product*=factor;
		}
		return product;
		
	}
	//method to get the product of cubes of factors
	public static long ProductOfCubeOfFactors(int [] factors){
		long product =1;
		//loop to get cubes of factors product
		foreach(int factor in factors){
			product*=(long)Math.Pow(factor,3);
		}
		return product;
		
	}
	// method to check if the number is perfect number or not
   	public static bool IsPerfectNumber(int num){
        int[] factors = GetFactors(num);
        //call the SumOfFactors method
        int sum = SumOfFactors(factors) - num; // do not include the number
        return sum == num;
    }
    public static bool IsAbundantNumber(int num){
        int[] factors = GetFactors(num);
        //call the SumOfFactors method
        int sum = SumOfFactors(factors) - num; // do not include the number
        return sum >num;
    }
    public static bool IsDeficientNumber(int num){
        int[] factors = GetFactors(num);
        //call the SumOfFactors method
        int sum = SumOfFactors(factors) - num; // do not include the number
        return sum <num;
    }
    //method to calculate factorial
    public static long Factorial(int num){
    	int factorial=1;
    	for(int i=2;i<=num;i++){
    		factorial*=i;
    	}
    	return factorial;
    }
    //method to check the strong number(sum of digits==factorial)
    public static bool IsStrongNumber(int num){
    	int sum=0;
    	long factorial =Factorial(num);
    	while(num!=0){
    		sum+=num%10;
    		num/=10;
    	}
    	return sum==factorial;
    	
    }

	
	static void Main(string[] args) {
		//Input from user
		Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Call the method GetFactors
        int[] factors = GetFactors(num);
        //Display output
        Console.WriteLine($"Greatest Factor: {GreatestFactor(factors)}");
        Console.WriteLine($"Sum of Factors: {SumOfFactors(factors)}");
        Console.WriteLine($"Product of Factors: {ProductOfFactors(factors)}");
        Console.WriteLine($"Product of Cubes of Factors: {ProductOfCubeOfFactors(factors)}");
        Console.WriteLine($"Is Perfect Number: {IsPerfectNumber(num)}");
        Console.WriteLine($"Is Abundant Number: {IsAbundantNumber(num)}");
        Console.WriteLine($"Is Deficient Number: {IsDeficientNumber(num)}");
        Console.WriteLine($"Is Strong Number: {IsStrongNumber(num)}");
		
	}}