namespace MyWebAPI.Models;

public class Content
{
    public Guid Id { get; set; }
    public required byte[] Bytes { get; set; }
}