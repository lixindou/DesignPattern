using System;

namespace CorPattern
{
    class Program
    {
        static void Main()
        {
            RunPurchases();

            // Wait for user
            Console.ReadKey();
        }

        private static void RunPurchases()
        {
            var purchaseWf = new PurchseWorkFlow();

            IHandler<Purchase> larry = new Director();
            IHandler<Purchase> sam = new VicePresident();
            IHandler<Purchase> tammy = new President();
            purchaseWf.AddNextHandler(tammy);
            purchaseWf.AddNextHandler(sam);
            purchaseWf.AddNextHandler(larry);

            Purchase p = new Purchase(2034, 350.00, "Assets");
            purchaseWf.Execute(p);

            p = new Purchase(2035, 32590.10, "Project X");
            purchaseWf.Execute(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            purchaseWf.Execute(p);
        }
    }
}
