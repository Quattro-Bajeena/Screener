namespace Game.Contracts.Requests;

public class RevealTileRequest
{
    public Guid GameId { get; set; }
    public Guid PlayerId { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
}
