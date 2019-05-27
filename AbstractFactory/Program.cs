using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class MainApp
    {
        static void Main()
        {
            var bmoClient = new Client(new BMOBankAccountFactory());
            var tdClient = new Client(new TDBankAccountFactory());

            // Create saving accounts
            var bmoSaving = bmoClient.CreateSavingAccount($"BMO-Saving-{Guid.NewGuid().ToString()}");
            var tdSaving = tdClient.CreateSavingAccount($"TD-Saving-{Guid.NewGuid().ToString()}");

            // Create checking accounts
            var bmoChecking = bmoClient.CreateCheckingAccount($"BMO-Checking-{Guid.NewGuid().ToString()}");
            var tdChecking = tdClient.CreateCheckingAccount($"TD-Checking-{Guid.NewGuid().ToString()}");

        }
    }
}

