using System;

class Account
{
    string _firstName;
    string _lastName;

    public Account(string firstName, string lastName, decimal intialBalance = 0.0m)
    {
        _firstName = firstName;
        _lastName = lastName;
        Balance = intialBalance;
    }

    public decimal Balance
    {
        get; set;
    }

    public string AccountOwner
    {
        get => $"{_firstName} {_lastName}";
    }

    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        Balance -= amount;
    }

}