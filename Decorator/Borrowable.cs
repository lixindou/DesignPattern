using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Borrowable : Decorator
    {
        protected List<string> Borrowers = new List<string>();
        public Borrowable(ILibraryItem libraryItem) : base(libraryItem)
        {
        }
        public void BorrowItem(string borrowerName)
        {
            Borrowers.Add(borrowerName);
            LibraryItem.NumCopies--;
        }
        public void ReturnItem(string borrowerName)
        {
            Borrowers.Remove(borrowerName);
            LibraryItem.NumCopies++;
        }
        public override void Display()
        {
            base.Display();

            foreach (string borrower in Borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}