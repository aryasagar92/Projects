using System;
using SplashKitSDK;
using System.Collections.Generic;

public class Bank
{
    private List<Account> _accounts = new List<Account>();

    public void AddAccount (Account account)
    {
            _accounts.Add(account);
    }
    public Account GetAccount (string name) 
    {
        foreach (Account account in _accounts)
        {
            if (name == account.Name) 
            {
                Account value = account;
                return value;
            }
            return null;
        }
        return null;
    }

    private void ExecuteTransaction (transaction WithdrawTransaction)
    {
        transaction.Execute(); // execute on transaction. same for other two
    }

    private void ExecuteTransaction (transaction DepositTransaction)
    {
        transaction.Execute();
    }

    private void ExecuteTransaction (transaction TransferTransaction)
    {
        transaction.Execute();
    }
}