using System;
using SplashKitSDK;
using System.Collections.Generic;

public class Bank
{
    private static List<Account> _accounts = new List<Account>();

    public static void AddAccount (Account account)
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
        }
        return null;
    }

    private void ExecuteTransaction (WithdrawTransaction WithdrawTransaction)
    {
        WithdrawTransaction.Execute(); 
    }

    private void ExecuteTransaction (DepositTransaction DepositTransaction)
    {
        DepositTransaction.Execute();
    }

    private void ExecuteTransaction (TransferTransaction TransferTransaction)
    {
        TransferTransaction.Execute();
    }

}