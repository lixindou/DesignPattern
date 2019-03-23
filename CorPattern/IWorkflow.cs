using System;
using System.Collections.Generic;
using System.Text;

namespace CorPattern
{
    interface IWorkflow<T>
    {
        void Execute();
        void AddNextHandler(T handler);
    } 
}
