using System;
class Search{
    //Method to find the first negative number through linear search
    static void LinearSearch(string[] arr,string word){
        //No element condition
        if(arr.Length==0){
            Console.WriteLine("No element in array");
            return;
        }
        //search word in sentence
        for(int i=0;i<arr.Length;i++){
            foreach(string words in arr[i].Split()){
                if(words==word){
                    Console.WriteLine($"Word: {word} in Sentence :{arr[i]}");
                    return;
            }}
        }
        //If word not found
        Console.WriteLine("Not Found.");
    }
    //Main method
    static void Main(){
        //Input from user
        Console.Write("Enter the number of Inputs: ");
        int number=int.Parse(Console.ReadLine());
        string[] arr= new string[number];
        int index=0;
        while(index<number){
            Console.Write("Enter the Sentence: ");
            arr[index]= Console.ReadLine();
            index++;
        }
        Console.WriteLine("Enter the word to found: ");
        //call the method
        LinearSearch(arr,Console.ReadLine());
    }
}