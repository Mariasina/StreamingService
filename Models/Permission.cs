namespace MyWebAPI.Models;

public class Permission
{
    public Guid Id { get; set; }
    public required string Description { get; set; }
}