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
            var purchaseWF = new PurchseWorkFlow();

            IHandler<Purchase> larry = new Director();
            IHandler<Purchase> sam = new VicePresident();
            IHandler<Purchase> tammy = new President();
            purchaseWF.AddNextHandler(tammy);
            purchaseWF.AddNextHandler(sam);
            purchaseWF.AddNextHandler(larry);

            Purchase p = new Purchase(2034, 350.00, "Assets");
            purchaseWF.Execute(p);

            p = new Purchase(2035, 32590.10, "Project X");
            purchaseWF.Execute(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            purchaseWF.Execute(p);
        }
    }
}
