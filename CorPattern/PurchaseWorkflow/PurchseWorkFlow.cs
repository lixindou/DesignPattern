namespace CorPattern
{
    public class PurchseWorkFlow : IWorkflow<IHandler<Purchase>>
    {
        private readonly Purchase _purchase;
        private IHandler<Purchase> _topHandler;
        private IHandler<Purchase> _bottomHandler;

        public PurchseWorkFlow(Purchase purchase)
        {
            _purchase = purchase;
        }
        public void Execute()
        {
           _topHandler.Process(_purchase);
        }

        public void AddNextHandler(IHandler<Purchase> handler)
        {
            if (_bottomHandler == null)
            {
                _bottomHandler = _topHandler = handler;
            }
            else
            {
                _topHandler = handler;
                _topHandler.SetSuccessor(_bottomHandler);
            }
        }
    }
}