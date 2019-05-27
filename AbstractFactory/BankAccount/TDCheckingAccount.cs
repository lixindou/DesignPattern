using AbstractFactory.Interfaces;

namespace AbstractFactory.BankAccount
{
    public class TDCheckingAccount : ICheckingAccount
    {
        private const double CheckPrice = 0.15;
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

        public void OrderChecks(int numberOfChecks)
        {
            Balance = Balance - CheckPrice * numberOfChecks;
        }
    }
}