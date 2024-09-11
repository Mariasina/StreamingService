namespace MyWebAPI.Models;

public class VideoReaction
{
    public Guid Id { get; set; }
    public required Video Video { get; set; }
    public required Reaction Reaction { get; set; }
    public required User User { get; set; }
}