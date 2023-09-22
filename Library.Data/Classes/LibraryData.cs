using Library.Common.Classes;
using Library.Common.Interfaces;

namespace Library.Data.Classes;

public class LibraryData : IData
{
    List<IBook> _books = new();

    public LibraryData()
    {
        _books.Add(new Paperback(1, "Title 1", "Desccr 1"));
        _books.Add(new AudioBook(2, "Audio 1", "Desccr 1"));
    }

    public List<IBook> GetBooks() => _books;
    
}
