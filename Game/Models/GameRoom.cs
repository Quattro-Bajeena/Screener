using Screener.Data;

namespace Game.Models;

public class GameRoom
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Private { get; set; }
    public string Password { get; set; }
    public GameState State { get; set; }
    public GameRules Rules { get; set; }
    public ApplicationUser Host { get; set; }
    public List<ApplicationUser> Users { get; set; }
    public GameImageCollection Images { get; set; }
}
