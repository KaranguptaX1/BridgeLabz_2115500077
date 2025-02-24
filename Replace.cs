using System;
class Replace{
    //method to replace certain substring of sentence with certain word 
    public static string ReplaceSubstring(string sentence,string remove,string add){
        string newSentence = "";
        //loop over the sentence
        for(int i=0;i<sentence.Length;i++){
            bool match=false;
            int count=0;
            //loop to find the substring to remove
            for(int j=0;j<remove.Length;j++){
                if(i+j<sentence.Length && sentence[i+j]==remove[j]){
                    count++;
                }
                if(count==remove.Length){
                    match=true;   
                }
            }
            //if found match add the newWord and shift i to skip the matched part
            if (match){
                newSentence+=add;
                i+=remove.Length-1;
            }
            else{
            //if not found continue with character of sentence
                newSentence+=sentence[i];
            }
        }
        return newSentence;
    }
    static void Main(string[] args){
        //Input from user
        Console.Write("Enter the String: ");
        string sentence= Console.ReadLine();
        Console.Write("Enter the substring to remoce: ");
        string remove= Console.ReadLine();
         Console.Write("Enter the substring to add: ");
        string addSubstring= Console.ReadLine();
        //call the method
        string result= ReplaceSubstring(sentence,remove,addSubstring);
        //Display output
        Console.WriteLine(result);
    }
}