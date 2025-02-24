
using System;
//Parent class
class BankAccount{
    //Protected variables
    protected int AccountNumber ;
    protected double Balance ;
    //Constructor
    public BankAccount(int accountnumber, double balance){
        AccountNumber = accountnumber;
        Balance = balance;
    }
    //Display Info method
    public virtual void DisplayAccountInfo(){
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
    //Account type method
    public virtual void DisplayAccountType(){
        Console.WriteLine("Account Type: Normal Bank Account");
    }
}
//Saving account subclass of BankAccount
class SavingsAccount : BankAccount{
    //Other Attribute
    public double InterestRate;
    //Constructor
    public SavingsAccount(int accountnumber, double balance, double interestrate) : base(accountnumber, balance){
        InterestRate = interestrate;
    }
    //Override parent class methods
    public override void DisplayAccountInfo(){
        base.DisplayAccountInfo();
        Console.WriteLine($"Interest Rate: {InterestRate}");
    }
    public override void DisplayAccountType(){
        Console.WriteLine("Account Type: Savings Account");
    }
}
//CheckingAccount subclass of BankAccount
class CheckingAccount : BankAccount{
    public double WithdrawalLimit;
    public CheckingAccount(int accountnumber, double balance, double withdrawallimit) : base(accountnumber, balance){
        WithdrawalLimit = withdrawallimit;
    }
    public override void DisplayAccountInfo(){
        base.DisplayAccountInfo();
        Console.WriteLine($"Withdrawal Limit: {WithdrawalLimit:C}");
    }
    public override void DisplayAccountType(){
        Console.WriteLine("Account Type: Checking Account");
    }
}
//subclass of BankAccount
class FixedDepositAccount : BankAccount{
    public int Year;
    public FixedDepositAccount(int accountnumber, double balance, int year) : base(accountnumber, balance){
        Year=year;
    }
    public override void DisplayAccountInfo(){
        base.DisplayAccountInfo();
        Console.WriteLine($"Years: {Year} Years");
    }
    public override void DisplayAccountType(){
        Console.WriteLine("Account Type: Fixed Deposit Account");
    }
}
class AccountTypes{
    //Main Method
    public static void Main(string[] args){
        BankAccount[] accounts = new BankAccount[3];
        accounts[0] = new SavingsAccount(10000000, 5000, 5);
        accounts[1] = new CheckingAccount(10000001, 10000, 1000);
        accounts[2] = new FixedDepositAccount(10000002, 20000, 12);
        foreach(BankAccount account in accounts){
            account.DisplayAccountType();
            account.DisplayAccountInfo();
            Console.WriteLine("-------------------------");
        }
    }}

