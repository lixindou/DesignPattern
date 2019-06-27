using System;

namespace CorPattern
{
    public class President : IHandler<Purchase>
    {
        private readonly IHandler<Purchase> _successor;
        public void SetSuccessor(IHandler<Purchase> successor)
        {
            throw new NotImplementedException();
        }
        public void Process(Purchase data)
        {
            Console.WriteLine(!(data.Amount < 100000.0)
                ? $"Request# {data.Number} requires an executive meeting!"
                : $"{this.GetType().Name} approved request# {data.Number}");
        }
    }
}