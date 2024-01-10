namespace Blog.Models;

public class Post
{
    public int Id { get; set; }

    public string Title { get; set; } = default!;
    public string Body { get; set; } = default!;

    public DateTime Created { get; set; } = DateTime.Now;
}