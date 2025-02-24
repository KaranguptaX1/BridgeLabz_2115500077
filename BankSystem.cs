using System;
class BankAccount{
    //initialize variables
    private string accountHolderName;
    private readonly long accountNumber;
    public static string bankName="State Bank Of India";
    private static int totalAccounts=0;
   
    //Constructor for Bank Account
    public BankAccount(string accountHolderName,long accountNumber){
        this.accountHolderName=accountHolderName;
        this.accountNumber=accountNumber;
        totalAccounts++;
    }
     //method to get total accounts
   
    public static void GetTotalAccounts(){
        Console.WriteLine($"The total numbers of account are: {totalAccounts}");
    }
     //Method to display the details of bank account
    public void DisplayAccountDetails(){
        if(this is BankAccount){
            Console.WriteLine($"Bank Name is :{bankName}");
            Console.WriteLine($"Account Holder Name is :{accountHolderName}");
            Console.WriteLine($"Account Number is :{accountNumber}");
            Console.WriteLine("_____________________________");}
        else{
            Console.WriteLine("Not a Bank account in this Bank.");
        }
    }
}
class Program{
    static void Main(string[] args){
        BankAccount acc1= new BankAccount("rahul",101);
        BankAccount acc2= new BankAccount("karan",103);
        acc1.DisplayAccountDetails();
        acc2.DisplayAccountDetails();
        // Display total number of accounts
        BankAccount.GetTotalAccounts();

    }
}