using System;
using Newtonsoft.Json;
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
            var bmoSavingJson = JsonConvert.SerializeObject(bmoSaving);
            Console.WriteLine(bmoSavingJson);
            var tdSaving = tdClient.CreateSavingAccount($"TD-Saving-{Guid.NewGuid().ToString()}");
            var tdSavingJson = JsonConvert.SerializeObject(tdSaving);
            Console.WriteLine(tdSavingJson);

            // Create checking accounts
            var bmoChecking = bmoClient.CreateCheckingAccount($"BMO-Checking-{Guid.NewGuid().ToString()}");
            var bmoCheckingJson = JsonConvert.SerializeObject(bmoChecking);
            Console.WriteLine(bmoCheckingJson);
            var tdChecking = tdClient.CreateCheckingAccount($"TD-Checking-{Guid.NewGuid().ToString()}");
            var tdCheckingJson = JsonConvert.SerializeObject(tdChecking);
            Console.WriteLine(tdCheckingJson);
        }
    }
}

