namespace MyWebAPI.Models;

public class Role
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required ICollection<PermissionGroup> PermissionGroups { get; set; }
}