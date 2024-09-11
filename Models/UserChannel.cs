namespace MyWebAPI.Models;

public class UserChannel
{
    public Guid Id { get; set; }
    public required User User { get; set; }
    public required Channel Channel { get; set; }
    public required RoleChannel RoleChannel { get; set; }
}