using Game.Models;

namespace Game.Contracts.Responses;

public class GetRoomResponse
{
    required public GameRoom Room { get; init; }
}
