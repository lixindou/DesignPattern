using AbstractFactory.Interfaces;

namespace AbstractFactory.BankAccount
{
    public class BMOSavingAccount : ISavingAccount
    {
        public readonly static int MinimumBalance = 2000;
        public readonly static int MaximumWithdrawAmount = 200;

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
        public double InterestRate => 0.01;
    }
}