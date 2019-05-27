namespace AbstractFactory.Interfaces
{
    public interface ICheckingAccount : IAccount
    {
        void OrderChecks(int numberOfChecks);
    }
}