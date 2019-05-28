namespace AbstractFactory.Interfaces
{
    public interface ISavingAccount : IAccount
    {
        double InterestRate { get; }
    }
}