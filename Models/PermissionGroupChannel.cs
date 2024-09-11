namespace MyWebAPI.Models;

public class PermissionGroupChannel
{
    public Guid Id { get; set; }
    public required string Description { get; set; }
    public required ICollection<PermissionChannel> PermissionsChannels { get; set; }
}