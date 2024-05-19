namespace DesignPatterns.Iterator
{
    public class Library : ILibraryCollection
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public IIterator CreateIterator()
        {
            return new LibraryIterator(this);
        }

        public int Count => _books.Count;

        public Book this[int index]
        {
            get { return _books[index]; }
            set { _books[index] = value; }
        }
    }
}
