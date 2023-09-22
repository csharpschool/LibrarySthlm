using Library.Common.Classes;
using Library.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Classes
{
    public class TestLibraryData : IData
    {
        List<IBook> _books = new();

        public TestLibraryData()
        {
            _books.Add(new Paperback(3, "Title 2", "Desccr 3"));
            _books.Add(new AudioBook(4, "Audio 2", "Desccr 4"));
        }

        public List<IBook> GetBooks() => _books;

    }
}
