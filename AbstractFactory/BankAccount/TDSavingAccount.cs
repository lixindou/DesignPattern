using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.BankAccount
{
    public class TDSavingAccount : ISavingAccount
    {
        public readonly static int MinimumBalance = 2000;
        public readonly static int MaximumWithdrawAmount = 200;
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
        public double InterestRate => 0.02;
    }
}