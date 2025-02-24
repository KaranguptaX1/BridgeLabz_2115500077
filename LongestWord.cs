using System;
class LongestWord{
    //method to get the longest word
    public static string GetLongestWord(string sentence){
        // add last space so we can count last word
        sentence+=" ";
        string newWord="";
        int point=0;//points to starting of word
        for (int i=0;i<sentence.Length;i++){
            //check for empty space
            if((int)sentence[i]==32){
                //if newWord length is less than  word
                if(newWord.Length<(i-point)){
                    newWord="";//make it empty
                    //add the word
                    for(int j=point;j<i;j++){
                        newWord+=sentence[j];
                    }
                }
                point=i+1;//make point it two next

            }
        }
        return newWord;
    }
	
	public static void Main(String[] args){
        //Input from user 
        Console.Write("Enter the Sentence: ");
        string sentence= Console.ReadLine();
        //display output
        Console.WriteLine($"the Longest word is: {GetLongestWord(sentence)}");
	}
}