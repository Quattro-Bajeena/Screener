using Game.Enums;
using Screener.Data;

namespace Game.Models;

public class GameState
{
    public Guid Id { get; set; }
    public GamePhase Phase { get; set; }
    public GameRules Rules { get; set; }
    public ApplicationUser ActivePlayer { get; set; }
    public List<PlayerState> Players { get; set; }
    public List<GameImage> Images { get; set; }
    public ImageState CurrentImage { get; set; }
}
