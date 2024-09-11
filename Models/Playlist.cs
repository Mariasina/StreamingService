namespace MyWebAPI.Models;

public class Playlist
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required User User { get; set; }
    public required IEnumerable<Video> Video { get; set; }
}