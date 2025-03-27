public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _comments = new List<Comment>();
        
        _title = title;
        _author = author;
        _length = length;
    }
    public int GetCountComments()
    {
        return _comments.Count;
    }

    public void AddComment(string commenterName, string textComment)
    {
        Comment newComment = new Comment(commenterName, textComment);
        _comments.Add(newComment);
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} sec");
        Console.WriteLine($"Number of Comments: {GetCountComments()}");
        
        Console.WriteLine();
        Console.WriteLine("Comments");
        Console.WriteLine();

        int count=1;
        foreach(Comment comment in _comments)
        {
            System.Console.WriteLine($"Comment #{count}");
            comment.Display();
            count++;
        }

        Console.WriteLine();
    }
}