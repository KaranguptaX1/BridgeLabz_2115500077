using System;
using System.Collections.Generic;

// Class to represent a Bank Account
class BankAccount {
    // Properties for account number and balance
    public int accountNumber { get; }
    public double balance { get; private set; }

    // Constructor to initialize account number and initial deposit
    public BankAccount(int accountNumber, double initialDeposit) {
        this.accountNumber = accountNumber;
        this.balance = initialDeposit;
    }

    // Method to deposit money into the account
    public void Deposit(double amount) {
        balance += amount;
    }

    // Method to withdraw money from the account
    public bool Withdraw(double amount) {
        if (amount > balance) {  // Check if withdrawal is possible
            Console.WriteLine("Insufficient Balance.");
            return false;
        }
        balance -= amount;
        return true;
    }

    // Method to display account balance
    public void DisplayBalance() {
        Console.WriteLine($"Account {accountNumber} has Balance: {balance}");
    }
}

// Class to represent a Customer
class Customer {
    public string Name { get; }  // Customer's name

    // List of bank accounts owned by the customer
    private List<BankAccount> accounts = new List<BankAccount>();

    // Constructor to initialize customer's name
    public Customer(string name) {
        Name = name;
    }

    // Method to add a bank account to the customer
    public void AddAccount(BankAccount account) {
        accounts.Add(account);
    }

    // Method to display all account balances of the customer
    public void ViewBalance() {
        Console.WriteLine($"Customer: {Name}");
        foreach (var account in accounts) {
            account.DisplayBalance();
        }
    }
}

// Class to represent a Bank
class Bank {
    public string BankName { get; }  // Name of the bank

    // List of customers who have accounts in the bank
    private List<Customer> customers = new List<Customer>();

    private int accountCounter = 1000;  // Counter to generate unique account numbers

    // Constructor to initialize bank name
    public Bank(string name) {
        BankName = name;
    }

    // Method to open a new bank account for a customer
    public void OpenAccount(Customer customer, double initialDeposit) {
        BankAccount account = new BankAccount(accountCounter++, initialDeposit);  // Create new account
        customer.AddAccount(account);  // Link account to customer

        // Add the customer to the bank if not already present
        if (!customers.Contains(customer)) {
            customers.Add(customer);
        }
    }

    // Method to display all customers and their balances in the bank
    public void DisplayAllCustomers() {
        Console.WriteLine($"Bank: {BankName}");
        foreach (var customer in customers) {
            customer.ViewBalance();
        }
    }
}

// Main program
class Program {
    static void Main(string[] args) {
        // Create a bank
        Bank myBank = new Bank("National Bank");

        // Create customers
        Customer alice = new Customer("Alice");
        Customer bob = new Customer("Bob");

        // Open accounts for customers
        myBank.OpenAccount(alice, 500); // Alice opens an account with $500
        myBank.OpenAccount(bob, 1000);  // Bob opens an account with $1000
        myBank.OpenAccount(alice, 200); // Alice opens another account with $200

        // Display balances of each customer
        alice.ViewBalance();
        bob.ViewBalance();

        // Display all customers and their account balances in the bank
        myBank.DisplayAllCustomers();
    }
}
