namespace AbstractFactory.Interfaces
{
    public interface IAccount
    {
        BankCode BankCode { get; set; }
        string AccountNumber { get; set; }
        double Balance { get; set; }
        double Withdraw(double amount);
        double Deposit(double amount);
    }
}