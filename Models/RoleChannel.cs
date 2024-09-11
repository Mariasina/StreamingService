namespace MyWebAPI.Models;

public class RoleChannel
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required ICollection<PermissionGroupChannel> PermissionGroupChannels { get; set; }
}