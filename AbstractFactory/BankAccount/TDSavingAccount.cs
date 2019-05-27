using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.BankAccount
{
    public class TDSavingAccount : ISavingAccount
    {
        public BankCode BankCode { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public double Withdraw(double amount)
        {
            throw new NotImplementedException();
        }

        public double Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public int MinimumBalance => 1000;
        public int MaximumWithdrawAmount => 100;
        public double InterestRate => 0.02;
    }
}