using Screener.Data;

namespace Game.Models;

public class GameRoom
{
    public GameState State { get; set; }
    public GameRules Rules { get; set; }
    public ApplicationUser Host { get; set; }
    public List<ApplicationUser> Users { get; set; }
    public GameImageCollection Images { get; set; }
}
