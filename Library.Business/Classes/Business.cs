using Library.Common.Interfaces;

namespace Library.Business.Classes;

public class Business
{
    IData _data;

    public Business(IData data)
    {
        _data = data;
    }

    public List<IBook> GetBooks()
    {
        return _data.GetBooks();
    }
}
