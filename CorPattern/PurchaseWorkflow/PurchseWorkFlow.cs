using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace CorPattern
{
    public class PurchseWorkFlow : IWorkflow<IHandler<Purchase>>
    {
        private IHandler<Purchase> _topHandler;
        private IHandler<Purchase> _bottomHandler;

        public void Execute(object data)
        {
            if (!(data is Purchase))
            {
                throw new ArgumentException("Invalid data type", nameof(data));
            }
            _topHandler.Process(data as Purchase);
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