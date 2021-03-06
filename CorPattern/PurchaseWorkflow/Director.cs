﻿using System;

namespace CorPattern
{
    public class Director : IHandler<Purchase>
    {
        private IHandler<Purchase> _successor;
        public void SetSuccessor(IHandler<Purchase> successor)
        {
            this._successor = successor;
        }
        public void Process(Purchase data)
        {
            if (data.Amount < 10000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {data.Number}");
            }
            else
            {
                if (_successor != null)
                {
                    _successor.Process(data);
                }
                Console.WriteLine($"{this.GetType().Name}  cannot approved request# {data.Number} and there is no successor to handle this request# {data.Number}");
            }
        }
    }
}