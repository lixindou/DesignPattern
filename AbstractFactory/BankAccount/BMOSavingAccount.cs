using AbstractFactory.Interfaces;

namespace AbstractFactory.BankAccount
{
    public class BMOSavingAccount : ISavingAccount
    {
        public BankCode BankCode { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public double Withdraw(double amount)
        {
            if (amount <= 0) return Balance;
            return Balance - amount;
        }

        public double Deposit(double amount)
        {
            if (amount <= 0) return Balance;
            return Balance + amount;
        }

        public int MinimumBalance => 2000;
        public int MaximumWithdrawAmount => 200;
        public double InterestRate => 0.01;
    }
}