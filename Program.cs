using System;
using System.Collections.Generic;

namespace BankingApplication
{
    public class Account 
    {
    public string AccountNumber {get;}
    public string OwnerName {get;}
    public decimal Balance {get; private set; }

    public Account(string accountNumber, string ownerName, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = initialBalance;

    }
    }
}

