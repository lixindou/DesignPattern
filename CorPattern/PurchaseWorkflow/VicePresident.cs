using System;

namespace CorPattern
{
    public class VicePresident : IHandler<Purchase>
    {
        private IHandler<Purchase> _successor;
        public void SetSuccessor(IHandler<Purchase> successor)
        {
            this._successor = successor;
        }

        public void Process(Purchase data)
        {

            if (data.Amount < 25000.0)
            {
                Console.WriteLine($"{this.GetType().Name} approved request# {data.Number}");
            }
            else
            {
                _successor.Process(data);
            }
        }
    }
}