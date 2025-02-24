using System;
using System.Collections.Generic;
//abstract class
abstract class BankAccount{
    //Private variable and properties
    private long accountNumber;
    private string holderName;
    private double balance;
    public long AccountNumber{get{return accountNumber;}}
    public string HolderName{get{return holderName;}}
    public double Balance{get{return balance;}}
    //Constructor
    public BankAccount(long accountNumber,string holderName,double balance){
        this.accountNumber=accountNumber;
        this.holderName=holderName;
        this.balance=balance;
    }
    //Display details method
    public void DisplayDetails(){
        Console.WriteLine($"Bank Details: \nAccountNumber: {accountNumber}\nHolder Name:{holderName}\nBalance: {balance}");
    }
    //Deposit method
    public void Deposit(double amount){
        if(amount<0){
            Console.WriteLine("Invalid amount");
        }
        else{
            balance+=amount;
            Console.WriteLine($"{amount} is Deposited.\nCurrent Balance: {balance}");
        }
    }
    //withdraw method
    public void Withdraw(double amount){
        if(amount>balance){
            Console.WriteLine("Amount entered is greater than balance");
        }
        else{
            balance-=amount;
            Console.WriteLine($"{amount} is Deposited.\nCurrent Balance: {balance}");
        }
    }
    //abstract method
    public abstract double CalculateInterest();
}
//Interface
interface ILoanable{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}
//SavingAccount subclass of BankAccount
class SavingAccount:BankAccount{
    //Interest rate variable
    private double interestRate=0.04;
    public double InterestRate{get{return interestRate;}
    set{if(value<=0.1){interestRate=value}
    else{Console.WriteLine("Interest rate is too high")}
    }}
    //Constructor
    public SavingAccount(long accountNumber,string holderName,double balance):base(accountNumber,holderName,balance){}
    //Override abstract class method
    public override double CalculateInterest(){
        return Balance*interestRate;
    }

}
//CurrentAccount class
class CurrentAccount:BankAccount,ILoanable{
    //interest rate variable
    private int interestRate=0;
    public int InterestRate{
        get{return interestRate;}
    }
    //Constructor
    public CurrentAccount(long accountNumber,string holderName,double balance):base(accountNumber,holderName,balance){}
    public override double CalculateInterest(){
        return Balance*interestRate;
    }
    //Method to apply for loan
    public void ApplyForLoan(double amount){
        Console.WriteLine($"Apply for loan of {amount} amount");
    }
    //Check Loan Eligibility
    public double CalculateLoanEligibility(){
        return Balance*5;
    }
}
class BankingSystem{
    //Main Method
    static void Main(string[] args){
        List<BankAccount> accounts=new List<BankAccount>();
        SavingAccount account1= new SavingAccount(1234134,"Rahul Kumar",2001);
        CurrentAccount account2= new CurrentAccount(1234019,"Karan",3000);
        accounts.Add(account1);
        accounts.Add(account2);
        account1.Deposit(6003);
        account1.Withdraw(50);
        account1.CalculateInterest();
        account2.Deposit(10000);
        account2.Withdraw(3000);
        account2.CalculateInterest();
        foreach(var account in accounts){
            Console.WriteLine("------------------------------");
            account.DisplayDetails();
            if(account is ILoanable loanable){
                loanable.ApplyForLoan(100000);
                Console.WriteLine($"Loan Amount Eligibility: {loanable.CalculateLoanEligibility()}");
            }
        }
    }
}