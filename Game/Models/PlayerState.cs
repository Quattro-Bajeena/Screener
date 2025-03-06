using Screener.Data;

namespace Game.Models;

public class PlayerState
{
    public int Score { get; set; }
    public string CurrentAnswer { get; set; }
    public ApplicationUser User { get; set; }
}
