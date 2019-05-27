using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public class Client
    {
        private IBankAccountFactory bankAccountFactory;

        public Client(IBankAccountFactory bankAccountFactory)
        {
            this.bankAccountFactory = bankAccountFactory;
        }

        public ISavingAccount CreateSavingAccount(string accountNumber)
        {
            return this.bankAccountFactory.CreateSavingAccount(accountNumber);
        }

        public ICheckingAccount CreateCheckingAccount(string accountNumber)
        {
            return this.bankAccountFactory.CreateCheckingAccount(accountNumber);
        }
    }
}