using System;
using SplashKitSDK;
public class DepositTransaction
{
    private Account _account;
    private decimal _amount;
    private bool _executed = false;
    private bool _success = false;
    private bool _reversed = false;

    public bool Executed
    {
        get { return _executed; }
    }

    public bool Success
    {
        get { return _success; }
    }

    public bool Reversed
    {
        get { return _reversed; } 
    }

    public DepositTransaction (Account account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }

    public void Execute()
    {
        if (_executed)
        {
            throw new Exception ("Cannot execute this transaction as it has already been executed");
        }

        _executed = true;
        _success = _account.Deposit(_amount);
    }

    public void Rollback()
    {
        if (!_executed)
        {
            throw new Exception ("Cannot reverse this transaction as it has not been executed");
        }
        else if (_reversed)
        {
            throw new Exception ("Cannot reverse this transaction as it has already been reversed");
        }   
        _reversed = true;
        if (_success) {
            _account.Withdraw(_amount);
        }
        _success = false;
        _executed = false;
        _reversed = true;
    }

    public void Print()
    {
        if ( _executed == true)
        {
            Console.WriteLine($"You have withdrawn {_amount} successfully");
        }
        else if (_reversed == true)
        {
            Console.WriteLine($"You have cancelled the withdrawal of {_reversed}");
        }
        else
        {
            Console.WriteLine("No action was initiated");
        }
    }

}
