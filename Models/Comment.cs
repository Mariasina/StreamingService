namespace MyWebAPI.Models;

public class Comment
{
    public Guid Id { get; set; }
    public required string Description { get; set; }
    public required Video Video { get; set; }
    public required User User { get; set; }
}