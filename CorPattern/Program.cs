using System;

namespace CorPattern
{
    class Program
    {
        static void Main()
        {
            int expenseNumber = 1;

            Console.WriteLine("Director can approve expenses under 10,000");
            Console.WriteLine("VP can approve expenses under 25,000");
            Console.WriteLine("President can approve expenses under 100,000");
            Console.WriteLine("Expenses exceed 100,000 needs BOD approval");

            while (true)
            {
                Console.WriteLine("Enter Y to process an expense or hit any key to exit.");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    Console.WriteLine("Enter amount of an expense, it should be numbers");
                    double amount = Double.Parse(Console.ReadLine());
                    var purchase1 = new Purchase(expenseNumber, amount, "Training");
                    RunPurchases(purchase1);
                    expenseNumber++;
                }
                else
                {
                    break;
                }
            }
        }

        private static void RunPurchases(Purchase p)
        {
            var purchaseWf = new PurchseWorkFlow(p);

            IHandler<Purchase> director = new Director();
            IHandler<Purchase> vp = new VicePresident();
            IHandler<Purchase> president = new President();
            purchaseWf.AddNextHandler(director);
            purchaseWf.AddNextHandler(vp);
            purchaseWf.AddNextHandler(president);
            purchaseWf.Execute();
        }
    }
}
