using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
class Program{
    // Count the number of occurrences of each word in a text file
    public static void CountWords(string path){
        //Try block
        try{
            // Create a dictionary to store the word count
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8)){
                string line;
                // Read each line of the file
                while ((line = reader.ReadLine()) != null){
                    string[] words = line.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    // Count the occurrences of each word
                    foreach (string word in words){
                        if (wordCount.ContainsKey(word))
                            wordCount[word]++;
                        else
                            wordCount[word] = 1;
                    }
                }
            }
            // Get the top 5 most frequently occurring words
            var topWords = wordCount.OrderByDescending(w => w.Value).Take(5);
            Console.WriteLine("Top 5 most frequently occurring words:");
            foreach (var pair in topWords){
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
        //Catch block
        catch (IOException ex){
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }
    public static void Main(string[] args){
        string path = "Assignment28/Sample.txt";
        CountWords(path);
    }
}
