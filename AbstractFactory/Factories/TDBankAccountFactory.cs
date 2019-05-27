using AbstractFactory.BankAccount;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class TDBankAccountFactory : IBankAccountFactory
    {
        public ISavingAccount CreateSavingAccount(string accountNumber)
        {
            return new TDSavingAccount() { BankCode = BankCode.TD, AccountNumber = accountNumber };
        }

        public ICheckingAccount CreateCheckingAccount(string accountNumber)
        {
            return new TDCheckingAccount() { BankCode = BankCode.TD, AccountNumber = accountNumber };
        }

        public ISavingAccount ConvertCheckingAccountToSavingAccount(ICheckingAccount checkingAccount)
        {
            throw new System.NotImplementedException();
        }

        public ICheckingAccount ConvertSavingAccountToCheckingAccount(ISavingAccount savingAccount)
        {
            throw new System.NotImplementedException();
        }
    }
}