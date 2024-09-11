namespace MyWebAPI.Models;

public class Video
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required Channel Channel { get; set; }
}