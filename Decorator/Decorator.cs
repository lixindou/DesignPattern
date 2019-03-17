namespace Decorator
{
    public class Decorator : ILibraryItem
    {
        protected ILibraryItem LibraryItem;

        public Decorator(ILibraryItem libraryItem)
        {
            this.LibraryItem = libraryItem;
        }

        public int NumCopies { get; set; }

        public virtual void Display()
        {
            LibraryItem.Display();
        }
    }
}