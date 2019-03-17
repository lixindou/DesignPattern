﻿using System.Collections.Generic;
using System.Linq;

namespace CorPattern
{
    public class PurchseWorkFlow : IWorkflow<IHandler<Purchase>, Purchase>
    {
        private IHandler<Purchase> _topHandler;
        private IHandler<Purchase> _bottomHandler;
           
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

        public void Execute(Purchase data)
        {
            _topHandler.Process(data);
        }
    }
}