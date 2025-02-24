using System;
class ReverseString{
	//method to reverse string
	public static string GetReverseString( string word){
		string newWord="";
		for(int i=word.Length-1;i>=0;i--){
			newWord+=word[i];
		}
		return newWord;
	}
	static void Main(string[] args){
		//input from user
		Console.Write("Enter the String: ");
		string word=Console.ReadLine();
		// call the method to get reverse string
		string reverseString= GetReverseString(word);
		//Display output
		Console.WriteLine(reverseString);
		
	} 
	}