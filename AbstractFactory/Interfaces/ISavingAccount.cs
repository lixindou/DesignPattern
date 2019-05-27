namespace AbstractFactory.Interfaces
{
    public interface ISavingAccount : IAccount
    {
        int MinimumBalance { get; }
        int MaximumWithdrawAmount { get; }
        double InterestRate { get; }
    }
}