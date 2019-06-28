using AbstractFactory.BankAccount;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class BMOBankAccountFactory : IBankAccountFactory
    {
        public ISavingAccount CreateSavingAccount(string accountNumber)
        {
            return new BMOSavingAccount() {BankCode = BankCode.BMO, AccountNumber = accountNumber };
        }

        public ICheckingAccount CreateCheckingAccount(string accountNumber)
        {
            return new BMOCheckingAccount() {BankCode = BankCode.BMO, AccountNumber = accountNumber};
        }
    }
}