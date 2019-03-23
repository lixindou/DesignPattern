using System;

namespace Decorator
{
    public class Book : ILibraryItem
    {
        public int NumCopies { get; set; }
        private string _author;
        private string _title;

        // Constructor

        public Book(string author, string title, int numCopies)
        {
            this._author = author ?? throw new ArgumentException();
            this._title = title;
            this.NumCopies = numCopies;
        }

        public void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}
