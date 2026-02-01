public class Comment
{
    private string _author;
    private string _text;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"\n\t{_author}:");
        Console.WriteLine($"\t{_text}");
    }
}