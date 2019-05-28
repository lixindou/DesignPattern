namespace CorPattern
{
    public class PurchseWorkFlow : IWorkflow<IHandler<Purchase>>
    {
        private readonly Purchase _purchase;
        private IHandler<Purchase> _firstHandler;
        private IHandler<Purchase> _lastHandler;

        public PurchseWorkFlow(Purchase purchase)
        {
            _purchase = purchase;
        }
        public void Execute()
        {
            _firstHandler.Process(_purchase);
        }

        public void AddNextHandler(IHandler<Purchase> handler)
        {
            if (_firstHandler == null)
            {
                _firstHandler = _lastHandler = handler;
            }
            else
            {
                _lastHandler.SetSuccessor(handler);
                _lastHandler = handler;
            }
        }
    }
}