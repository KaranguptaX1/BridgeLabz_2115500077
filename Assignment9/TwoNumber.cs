using System;
class TwoNumber{
	//method to calculate the remainder and quotient
	public static int[] FindRemainderAndQuotient(int number, int divisor){
		//Initialize variables
		int quotient,remainder;
		//operations
		quotient= number/divisor;
		remainder = number%divisor;
		return new int[] {remainder,quotient};
	}
	static void Main(string[] args) {
		//Input from user
		Console.Write("Enter the First number: ");
		int number1=int.Parse(Console.ReadLine());
		Console.Write("Enter the second number: ");
		int number2=int.Parse(Console.ReadLine());
		//Call the method
		int[] result= FindRemainderAndQuotient(number1,number2);
		//display output
		Console.WriteLine("Remainder : "+result[0]+ " Quotient: "+result[1] +" of "+ number1 +" and "+ number2);
		
	}
	
}