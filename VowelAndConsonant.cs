using System;
class VowelAndConsonant{
	//Method to count Vowels
	public static int[] CountVowelConsonant(string word){
		string vowels = "AEIOUaeiou";
		string consonants="BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
		int vowelsCount=0;
		int consonantCount=0;
		for(int i=0;i<word.Length;i++){
			//loop to match for vowel
			for (int j=0;j<vowels.Length;j++){
				if(word[i]==vowels[j]){
				vowelsCount++;	
			}}
			//loop to match consonants
			for (int j =0; j<consonants.Length;j++){
				if(consonants[j]==word[i]){
					consonantCount++;
				}
			}				
		}
			return new int[]{vowelsCount,consonantCount};
			
	}
		static void Main(string[] args){
		//Input from user
		Console.Write("Enter the word: ");
		string word = Console.ReadLine();
		int[] count=CountVowelConsonant(word);
		Console.WriteLine($"The number of Vowels are: {count[0]} \nThe number of consonant are: {count[1]} " );
			}}