namespace OpenClose
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}