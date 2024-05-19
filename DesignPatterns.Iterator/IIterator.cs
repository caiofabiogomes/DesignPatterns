namespace DesignPatterns.Iterator
{
    public interface IIterator
    {
        Book First();
        Book Next();
        bool IsDone();
        Book CurrentItem();
    }
}
