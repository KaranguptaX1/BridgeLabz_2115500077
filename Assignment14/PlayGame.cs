using System;
class NumberGuessingGame{
    // Method to get user feedback
    static string GetUserFeedback(int guess){
        Console.Write($"Is your number {guess}? (Enter 'H' for too high, 'L' for too low, 'C' for correct): ");
        string input;
        while (true){
            input = Console.ReadLine().Trim().ToUpper();
            if (input == "H" || input == "L" || input == "C")
                break;
            Console.Write("Invalid input! Please enter 'H', 'L', or 'C': ");
        }
        return input;
    }
    // Method to perform the guessing logic
    static void PlayGame(){
        int low = 1, high = 100, guess;
        Console.WriteLine("Think of a number between 1 and 100. I will try to guess it!");
        Console.WriteLine("Respond with 'H' if my guess is too high, 'L' if it's too low, and 'C' if I guessed correctly.");
        while (low <= high){
            guess = (low + high) / 2; // Use binary search strategy to guess efficiently
            string feedback = GetUserFeedback(guess);
            if (feedback == "C"){
                Console.WriteLine($"Great! I guessed your number {guess} correctly!");
                return;
            }
            else if (feedback == "H"){
                high = guess - 1;
            }
            else if (feedback == "L"){
                low = guess + 1;
            }
        }
        Console.WriteLine("Hmm, something went wrong! Did you change your number?");
    }
    static void Main()
    {
        PlayGame();
    }
}
