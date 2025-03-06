using Game.Models;

namespace Game.Contracts.Responses;

public class GetGameResponse
{
    public GameState State { get; set; }
}
