using Game.Models;
using Screener.Data;

namespace Game.Contracts.Requests;

public class CreateRoomRequest
{
    public string Name { get; set; }
    public bool Private { get; set; }
    public string Password { get; set; }
    public GameRules Rules { get; set; }
    public ApplicationUser Host { get; set; }
}
