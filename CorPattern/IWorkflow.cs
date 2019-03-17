using System;
using System.Collections.Generic;
using System.Text;

namespace CorPattern
{
    interface IWorkflow<T> 
    {
        void Execute(object data);
        void AddNextHandler(T handler);
    } 
}
