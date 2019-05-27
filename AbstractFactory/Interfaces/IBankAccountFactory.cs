namespace AbstractFactory.Interfaces
{
    public interface IBankAccountFactory
    {
        ISavingAccount CreateSavingAccount(string accounNumber);
        ICheckingAccount CreateCheckingAccount(string accounNumber);

        ISavingAccount ConvertCheckingAccountToSavingAccount(ICheckingAccount checkingAccount);
        ICheckingAccount ConvertSavingAccountToCheckingAccount(ISavingAccount savingAccount);
    }
}