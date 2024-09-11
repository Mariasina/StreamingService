namespace MyWebAPI.Models;

public class PermissionGroup
{
    public Guid Id { get; set; }
    public required string Description { get; set; }
    public required ICollection<Permission> Permissions { get; set; }
}