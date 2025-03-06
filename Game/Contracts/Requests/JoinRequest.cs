namespace Game.Contracts.Requests;

public class JoinRequest
{
    public Guid GameId { get; set; }
    public Guid PlayerId { get; set; }
    public string? Password { get; set; }
}
