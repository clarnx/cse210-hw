class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nLength: {LengthInSeconds} seconds\nComments ({GetCommentCount()}):");
        foreach (var comment in comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
        }
        Console.WriteLine();
    }
}