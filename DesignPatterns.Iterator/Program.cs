using DesignPatterns.Iterator;

var library = new Library();
library.AddBook(new Book("Book 1"));
library.AddBook(new Book("Book 2"));
library.AddBook(new Book("Book 3"));
library.AddBook(new Book("Book 4"));


var iterator = library.CreateIterator();

Console.WriteLine("Books in the library:");
for (var book = iterator.First(); !iterator.IsDone(); book = iterator.Next())
{
    Console.WriteLine(book.Title);
}

Console.ReadKey();