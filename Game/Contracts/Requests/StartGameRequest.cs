using Game.Models;
using Screener.Data;

namespace Game.Contracts.Requests;

public class StartGameRequest
{
    public GameRules GameRules { get; set; }
    public List<ApplicationUser> Users { get; set; }
    public int ImageSetId { get; set; }
}
