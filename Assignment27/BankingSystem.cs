using System;
using System.Collections.Generic;
class BankingSystem{
    Dictionary<int, double> accounts = new Dictionary<int, double>();
    SortedDictionary<int, double> sortedAccounts = new SortedDictionary<int, double>();
    Queue<Tuple<int, double>> withdrawalQueue = new Queue<Tuple<int, double>>();
    //method to add the account
    public void AddAccount(int id, double balance){
        accounts[id] = balance;
        sortedAccounts[id] = balance;
    }
    //method to request withdrawal
    public void RequestWithdrawal(int id, double amount){
        if (accounts.ContainsKey(id)){
            if (accounts[id] >= amount){
                withdrawalQueue.Enqueue(new Tuple<int, double>(id, amount));
                Console.WriteLine($"Withdrawal of {amount:C} requested for Account {id}");
            }
            else{
                Console.WriteLine($"Insufficient balance in Account {id} for withdrawal of {amount:C}");
            }
        }
        else{
            Console.WriteLine($"Account {id} does not exist.");
        }
    }
    //Method to process Withdrawals
    public void ProcessWithdrawals(){
        while (withdrawalQueue.Count > 0){
            var withdrawal = withdrawalQueue.Dequeue();
            int id = withdrawal.Item1;
            double amount = withdrawal.Item2;
            if (accounts[id] >= amount){
                accounts[id] -= amount;
                sortedAccounts[id] = accounts[id];
                Console.WriteLine($"Balance: {accounts[id]:C} after withdrawal of {amount}.");
            }
            else{
                Console.WriteLine($"Do not have enough money in account.");
            }
        }
    }
    //Method to display the balances of accounts
    public void DisplayBalances(){
        Console.WriteLine("\nAccount Balances:");
        foreach (var account in sortedAccounts){
            Console.WriteLine($"Account {account.Key}: {account.Value:C}");
        }
    }
}

class Banks{
    //Main Method
    static void Main(){
        BankingSystem bank = new BankingSystem();
        bank.AddAccount(1, 5000);
        bank.AddAccount(2, 2000);
        bank.AddAccount(3, 20000);
        bank.AddAccount(4, 55000);
        bank.AddAccount(5, 1000);

        bank.DisplayBalances();

        bank.RequestWithdrawal(1, 1000);
        bank.RequestWithdrawal(2, 2500);  
        bank.RequestWithdrawal(2, 1500);  
        bank.RequestWithdrawal(4, 15000);  

        bank.ProcessWithdrawals();
        bank.DisplayBalances();
    }
}
