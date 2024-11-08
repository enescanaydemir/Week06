using System;

namespace BankingApplication;

public class CheckingAccount : Account
{
    public CheckingAccount(int accountNumber, double balance) : base(accountNumber, balance)
    {
    }

    public string WriteCheck { get; set; }
}
