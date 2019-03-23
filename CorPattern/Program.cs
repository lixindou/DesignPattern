using System;

namespace CorPattern
{
    class Program
    {
        static void Main()
        {
            var purchase1 = new Purchase(001, 2000, "Traning");
            RunPurchases(purchase1);

            // Wait for user
            Console.ReadKey();
        }

        private static void RunPurchases(Purchase p)
        {
            var purchaseWf = new PurchseWorkFlow(p);

            IHandler<Purchase> director = new Director();
            IHandler<Purchase> vp = new VicePresident();
            IHandler<Purchase> president = new President();
            purchaseWf.AddNextHandler(president);
            purchaseWf.AddNextHandler(vp);
            purchaseWf.AddNextHandler(director);
            purchaseWf.Execute();
        }
    }
}
