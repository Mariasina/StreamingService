namespace MyWebAPI.Models;

using Microsoft.EntityFrameworkCore;

public class StreamingContext : DbContext{
    public DbSet<Channel> Channels { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Content> Contents { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<PermissionChannel> PermissionChannels { get; set; }
    public DbSet<PermissionGroup> PermissionGroups { get; set; }
    public DbSet<PermissionGroupChannel> PermissionGroupChannels { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<Reaction> Reactions { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RoleChannel> RoleChannels { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserChannel> UserChannels { get; set; }
    public DbSet<Video> Videos { get; set; }
    public DbSet<VideoReaction> VideoReactions { get; set; }

    public StreamingContext(DbContextOptions opt) : base(opt) { }

}