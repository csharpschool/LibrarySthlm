namespace Library.Common.Interfaces;

public interface IBook
{
    public int Id { get; init; }
    public string Title { get; init; }
    public string Description { get; init; }

    int CurrentChapter(int chapter);
}
