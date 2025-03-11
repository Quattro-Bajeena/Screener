using Game.Enums;
using Screener.Data;

namespace Game.Models;

public class GameState
{
    public GamePhase Phase { get; set; }
    public GameRules Rules { get; set; }
    public ApplicationUser ActivePlayerId { get; set; }
    public List<PlayerState> Players { get; set; }
    public List<GameImage> Images { get; set; }
    public ImageState CurrentImage { get; set; }
}
