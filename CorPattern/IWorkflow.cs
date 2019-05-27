namespace CorPattern
{
    interface IWorkflow<T>
    {
        void Execute();
        void AddNextHandler(T handler);
    } 
}
