using System;
using System.Collections.Generic;
class VotingSystem{
    Dictionary<string, int> votes = new Dictionary<string, int>();
    SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>();
    LinkedList<KeyValuePair<string, int>> voteOrder = new LinkedList<KeyValuePair<string, int>>();
    //Method to cast vote
    public void CastVote(string candidate){
        if (votes.ContainsKey(candidate))
            votes[candidate]++;
        else
            votes[candidate] = 1;
        sortedVotes[candidate] = votes[candidate];
        voteOrder.AddLast(new KeyValuePair<string, int>(candidate, votes[candidate]));
    }
    //Methdo to Display the result in sorted order
    public void DisplayResults(){
        Console.WriteLine("\nSorted Results:");
        foreach (var vote in sortedVotes){
            Console.WriteLine($"{vote.Key}: {vote.Value}");
        }
    }
    //method to Display the voting order
    public void DisplayVotingOrder(){
        Console.WriteLine("\nVoting Order:");
        foreach (var vote in voteOrder){
            Console.WriteLine($"{vote.Key} voted at {vote.Value}");
        }
    }
}
class Program{
    //Main Method
    static void Main(){
        VotingSystem votingSystem = new VotingSystem();
        votingSystem.CastVote("Rahul");
        votingSystem.CastVote("Karan");
        votingSystem.CastVote("Rahul");
        votingSystem.CastVote("Prakhar");
        votingSystem.CastVote("Aman");
        //Display output
        votingSystem.DisplayResults();
        votingSystem.DisplayVotingOrder();
    }
}
