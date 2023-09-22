using Library.Common.Interfaces;

namespace Library.Common.Classes;

public class Paperback : IBook
{
    public int Id { get; init; }
    public string Title { get; init; }
    public string Description { get; init; }

    public Paperback(int id, string title, string descr) =>
        (Id, Title, Description) = (id, title, descr);

    /*public Paperback(int id, string title, string descr)
    {
        Id = id;
        Title = title;
        Description = descr;
    }*/

    public int CurrentChapter(int chapter)
    {
        throw new NotImplementedException();
    }

    public void Read()
    { }
}
