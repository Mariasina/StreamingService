namespace MyWebAPI.Models;

public class Subscription
{
    public Guid Id { get; set; }
    public required Channel Channel { get; set; }
    public required User User { get; set; }
}