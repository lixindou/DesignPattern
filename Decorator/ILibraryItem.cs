namespace Decorator
{
    public interface ILibraryItem
    {
        int NumCopies { get; set; }
        void Display();
    }
}