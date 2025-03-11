namespace Game.Models;

public class GameRules
{
    public int TilesAcross { get; set; } = 3;
    public int TilesVertical { get; set; } = 3;
    public int TileRevealLimit { get; set; } = 4;
    public TimeSpan TimeLimit { get; set; } = TimeSpan.FromMinutes(5);
    public int ImageCount { get; set; } = 3;
}
