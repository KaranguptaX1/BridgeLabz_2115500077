using System;
class Prime{
	//MEthod to check the prime Result
	public static void PrimeResult(bool result){
		//if result is true
		if (result){
			//Display output
			Console.WriteLine(" The Number is Prime.");
		}
		else{
			Console.WriteLine(" The Number is not Prime.");
		}
	}
	//Check Prime Number Method
	public static bool CheckPrime(int num){
		if(num<2){
			return false;
		}
		//loop to check Prime 
		for(int i=2;i*i<=num;i++){
			if(num%i==0){
				return false;
			   
			}	
		}
		return true;
	}
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the Number: ");
		int number= int.Parse(Console.ReadLine());
		//call the methods
		bool result= CheckPrime(number);
		PrimeResult(result);
		
	}
	}