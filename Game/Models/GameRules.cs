namespace Game.Models;

public class GameRules
{
    public int TilesAcross { get; set; }
    public int TilesVertical { get; set; }
    public int TileRevealLimit { get; set; }
    public TimeSpan TimeLimit { get; set; }
    public int ImageCount { get; set; }
}
