public class Comment
{
    private string _commenterName;
    private string _textComment;

    public Comment(string commenterName, string textComment)
    {
        _commenterName = commenterName;
        _textComment = textComment;
    }

    public void Display()
    {
        Console.WriteLine($"Commenter Name: {_commenterName}");
        Console.WriteLine($"Text: {_textComment}");
        Console.WriteLine();
    }
    
}