using System;
public class BankAccount{
    public string accountNumber;
    protected string accountHolder;
    private double balance;
	//Constructor
    public BankAccount(string accountNumber, string accountHolder, double balance){
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
    // Public methods to access and modify balance
    public double GetBalance(){
        return balance;
    }
    public void Deposit(double amount){
        balance += amount;
    }
}

public class SavingsAccount : BankAccount{
    public SavingsAccount(string accountNumber, string accountHolder, double balance)
        : base(accountNumber, accountHolder, balance) { }

    public void DisplayAccountInfo(){
        Console.WriteLine("Account Number: " + accountNumber); // Accessing public member
        Console.WriteLine("Account Holder: " + accountHolder); // Accessing protected member
        Console.WriteLine("Balance: "+ GetBalance()); //Getting  Balance
    }
}

class Program{
    static void Main(string[] args){
        SavingsAccount savingsAccount = new SavingsAccount("ACC123", "Rahul Kumar", 5000.00);
        savingsAccount.DisplayAccountInfo();
        savingsAccount.Deposit(1000);
        Console.WriteLine("New Balance: " + savingsAccount.GetBalance());
    }
}
