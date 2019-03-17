using System;
using System.Collections.Generic;
using System.Text;

namespace CorPattern
{
    interface IWorkflow<THandler, TData>
    {
        void Execute(TData data);
        void AddNextHandler(THandler handler);
    } 
}
