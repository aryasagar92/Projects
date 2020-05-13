using System;
using SplashKitSDK;
using System.Collections.Generic;

public class Account
{
    public decimal _balance;
    public string _name; 

    public Account (string name, decimal startingBalance)
    {
        _name = name;
        _balance = startingBalance;
    }

    public bool Deposit (decimal amountToAdd)
    {
       if (amountToAdd > 0)
       {
            _balance += amountToAdd;
            return true;
       }
       return false;
    }

    public bool Withdraw (decimal amountToSubtract)
    {
        if (amountToSubtract <= _balance && amountToSubtract > 0)
        {
            _balance -= amountToSubtract;
            return true;
        }
        return false;
    }

    public bool Transfer (decimal amountToTransfer)
    {
        if (amountToTransfer < _balance)
        {
            _balance -= amountToTransfer;
            return true;
        }
        return false;
    }


    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public void Print()
    {
        Console.WriteLine ($"Current balance is {_balance}");
        Console.WriteLine ($"Account name is {_name}");
    }
    
}