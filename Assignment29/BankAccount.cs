using System;
using System.IO;
//class InsufficientFundsException
class InsufficientFundsException : Exception{
    public InsufficientFundsException(string message) : base(message) { }
}
//BankAccount class
class BankAccount{
    private double balance;
    //Constructor
    public BankAccount(double initialBalance){
        balance = initialBalance;
    }
    public void Withdraw(double amount){
        if (amount < 0){
            throw new ArgumentException("Invalid amount!");
        }
        if (amount > balance){
            throw new InsufficientFundsException("Insufficient balance!");
        }
        balance -= amount;
        Console.WriteLine($"Withdrawal successful, new balance: {balance}");
    }
}
class Program{
    //Main Methods
    static void Main(){
        //try catch block
        try{
            Console.Write("Enter initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            BankAccount account = new BankAccount(initialBalance);
            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex){
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex){
            Console.WriteLine(ex.Message);
        }
        catch (FormatException){
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
        catch (Exception ex){
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}