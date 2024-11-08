using System;

namespace BankingApplication;

public class Account
{
    public Account(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public int AccountNumber { get; set; }
    public double Balance { get; set; }
}


/*
Bir Account (Hesap) temel sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:

AccountNumber (Hesap Numarası): Hesap numarası
Balance (Bakiye): Hesap bakiyesi
Bu sınıftan SavingsAccount (Tasarruf Hesabı) ve CheckingAccount (Vadesiz Hesap) sınıflarını türetin. Her hesap türüne özgü işlemler (örneğin, CheckingAccount için WriteCheck (Çek Yaz)) ekleyin.

*/