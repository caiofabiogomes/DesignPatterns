namespace DesignPatterns.Iterator
{
    public class LibraryIterator : IIterator
    {
        private Library _library;
        private int _current = 0;

        public LibraryIterator(Library library)
        {
            _library = library;
        }

        public Book First()
        {
            _current = 0;
            return _library[_current];
        }

        public Book Next()
        {
            _current++;
            return !IsDone() ? _library[_current] : null;
        }

        public bool IsDone()
        {
            return _current >= _library.Count;
        }

        public Book CurrentItem()
        {
            return _library[_current];
        }
    }

}
