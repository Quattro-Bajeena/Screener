using Game.Models;

namespace Game.Contracts.Responses;

public class GetRoomsResponse
{
    public required IEnumerable<GameRoom> Rooms { get; init; }
}
