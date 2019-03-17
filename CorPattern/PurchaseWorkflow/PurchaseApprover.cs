using System.Runtime.InteropServices.ComTypes;

namespace CorPattern
{
    public class PurchaseApprover : IHandler<Purchase>
    {
        public void Process(Purchase data)
        {
            throw new System.NotImplementedException();
        }

        public void SetSuccessor(IHandler<Purchase> successor)
        {
            throw new System.NotImplementedException();
        }
    }
}