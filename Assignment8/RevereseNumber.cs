using System;
class ReverseNumber{
	static void Main(string[] args){
		//Input from user
		Console.Write("Enter the number: ");
		int number= Convert.ToInt32(Console.ReadLine());
		//Count of digits
		int digitsCount=(int)Math.Log10(number) +1;
		//Initialize the variables
		int[] digits= new int[digitsCount];
		int index=0;
		//store digits
		while(number!=0){
			digits[index]=number%10;
			number/=10;
			index++;
		}
		//store digits in reverse order
		int[] reverseDigits= new int[digitsCount];
		for(int i=0; i< digitsCount;i++){
			reverseDigits[i]= digits[digitsCount-i-1];
		}
		Console.Write("Reversed Number: ");
		//Display output
        for(int i= digitsCount-1;i>=0;i--)
        {
            Console.Write(reverseDigits[i]);
        }
	}}