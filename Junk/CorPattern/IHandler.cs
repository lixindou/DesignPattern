namespace CorPattern
{
    public interface IHandler<T>
    {
        void SetSuccessor(IHandler<T> successor);
        void Process(T data);
    }
}