using Library.Common.Interfaces;

namespace Library.Common.Classes;

public class AudioBook : IBook
{
    public int Id { get; init; }
    public string Title { get; init; }
    public string Description { get; init; }

    public AudioBook(int id, string title, string descr) =>
        (Id, Title, Description) = (id, title, descr);

    public int CurrentChapter(int chapter)
    {
        throw new NotImplementedException();
    }

    public void Listen()
    {  }
}
