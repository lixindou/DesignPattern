using System;

namespace Decorator
{
    public class Video :ILibraryItem
    {
        private readonly string _director;
        private readonly string _title;
        private readonly int _playTime;

        public Video(string director, string title,
            int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            this.NumCopies = numCopies;
            this._playTime = playTime;
        }

        public int NumCopies { get; set; }

        public void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", _director);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
            Console.WriteLine(" Playtime: {0}\n", _playTime);
        }
    }
}